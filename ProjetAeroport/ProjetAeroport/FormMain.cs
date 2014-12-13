///FormMain.cs
///Stylisé par Antony Garand
///Le 24 novembre 2014
///
///Split containers:
///SplitContainerVertical.Pannel1 = Mises à jour (Haut du form)
///splitContainerAeroport.Panel1 = section "Atterissage"
///splitContainerControls.Panel1 = section "Décollages"
///splitContainerControls.Panel2 = section "contrôles"
///
///Modification le 18 nov: 
///Création des tâches du Background worker
///     Génération de X avions chaque X temps.
///Par Antony Garand
///
/// Par: Alexis Côté
/// Le : 28 novembre 2014
/// Description : Ajoute d'un nouveau form qui sera affiche lors d'un double clique dans le listbox. Comme le listbox utilise un datasource, 
/// il n'a plus de header. Il faudra donc créer un sous objet de ListBox avec une entete ou bien ajouter un composant pour notre entete.
///
/// Par: Alexis Côté
/// Le: 5 décembre 2014
/// Description : 
/// -Ajout des entetes pour les listbox
/// -Modification de la listbox pour que la sélection des objets ne change pas après chaque modification des ses objets

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GestionAeroport;

namespace ProjetAeroport
{
    public partial class FormMain : Form
    {

        //Variables membres
        private Aeroport aeroport;
        private FormInfoObjVolants formInfo;
        private bool backgroundWorkerPaused = false;


        public FormMain()
        {



            InitializeComponent();
        }
        /// <summary>
        /// Cache ou affiche la partie "Actualité" du menu
        /// </summary>
        private void nouvellesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerVertical.Panel1Collapsed)
            {
                splitContainerVertical.Panel1Collapsed = true;
                splitContainerVertical.Panel1.Hide();
            }
            else
            {
                splitContainerVertical.Panel1Collapsed = false;
                splitContainerVertical.Panel1.Show();
            }
        }

        /// <summary>
        /// Cache ou affiche la partie "Atterrissage" du menu
        /// </summary>
        private void atterissagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerAeroport.Panel1Collapsed)
            {
                splitContainerAeroport.Panel1Collapsed = true;
                splitContainerAeroport.Panel1.Hide();
            }
            else
            {
                splitContainerAeroport.Panel1Collapsed = false;
                splitContainerAeroport.Panel1.Show();
            }
        }

        /// <summary>
        /// Cache ou affiche la partie "Décollage" du menu
        /// </summary>
        private void décollagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerControls.Panel1Collapsed)
            {
                splitContainerControls.Panel1Collapsed = true;
                splitContainerControls.Panel1.Hide();
            }
            else
            {
                splitContainerControls.Panel1Collapsed = false;
                splitContainerControls.Panel1.Show();
            }
        }

        /// <summary>
        /// Cache ou affiche la partie "Contrôles" du menu
        /// </summary>
        private void contrôlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!splitContainerControls.Panel2Collapsed)
            {
                splitContainerControls.Panel2Collapsed = true;
                splitContainerControls.Panel2.Hide();
            }
            else
            {
                splitContainerControls.Panel2Collapsed = false;
                splitContainerControls.Panel2.Show();
            }
        }

        

        /// <summary>
        /// Créer un numéro de vol aléatoire (2 lettres, 4 chiffres)
        /// </summary>
        /// <returns>Numéro de vol aléatoire</returns>
        private string NoVolRandom()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 2; i++)
            {
                int noLettre = rnd.Next(0, 26);
                char lettre = (char)('A' + noLettre);
                sb.Append(lettre);
            }
            sb.Append(" " + rnd.Next(1000, 10000));
            Thread.Sleep(20);
            return sb.ToString();
        }

        /// <summary>
        /// Sera appele a chaque minute(seconde). Il ajoute ou enleve les elements dans la listbox selon les avions dans l'aeroport.
        /// </summary>
        private void UpdateListBox()
        {
            //Update Avions en attente
            lock (listBoxAtterissage)
            {
                //On garde en memoire l'index dans la listbox
                int lastSelectionIndex = listBoxAtterissage.SelectedIndex;

                listBoxAtterissage.DataSource = aeroport.AvionsAttentes;

                if (lastSelectionIndex > listBoxAtterissage.Items.Count-1)
                    lastSelectionIndex = listBoxAtterissage.Items.Count-1;

                //On remet l'index avant l'ajout des items
                listBoxAtterissage.SelectedIndex = lastSelectionIndex;
            }
            lock(listBoxDecollage)
            {
                //On garde en memoire l'index dans la listbox
                int lastSelectionIndex = listBoxDecollage.SelectedIndex;
                
                listBoxDecollage.DataSource = aeroport.AvionsDecolles;

                if (lastSelectionIndex > listBoxDecollage.Items.Count - 1)
                    lastSelectionIndex = listBoxDecollage.Items.Count - 1;

                //On remet l'index avant l'ajout des items
                listBoxDecollage.SelectedIndex = lastSelectionIndex;
            }


            
        }

        /// <summary>
        /// Met a jour les groupbox. Il modifie les valeurs de l'utilisation de la piste, le statut de chaque piste et l'heure de l'aeroport.
        /// </summary>
        private void UpdateGroupBox()
        {
            labelUtilisationValue.Text = (aeroport.Count/(double)aeroport.CapaciteObjVolants)*100 + "%";
            if (comboBoxPisteSelectionne.SelectedItem != null)
            {
                Piste piste = comboBoxPisteSelectionne.SelectedItem as Piste;
                labelAvionValue.Text = piste.NoVolAvion;
                if (piste.EstOccupee && piste.NoVolAvion == "")
                    labelStatutValue.Text = "En préparation";
                else if (piste.EstOccupee)
                {
                    labelStatutValue.Text = "Occupée";
                }
                else
                    labelStatutValue.Text = "Libre";
            }
        }

        /// <summary>
        /// Bouton pour demarrer le systeme de l'aeroport. Celui-ci effectuera la gestion a chaque seconde.
        /// </summary>
        /// <param name="sender">Bouton</param>
        /// <param name="e">Evenement</param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!buttonStop.Enabled)
            {
                aeroport = new Aeroport();
                listBoxAtterissage.DataSource = aeroport.AvionsAttentes;
                comboBoxPisteSelectionne.DataSource = aeroport.Pistes;
                listBoxDecollage.DataSource = aeroport.AvionsDecolles;

                timerGenerate.Start();
                
                //Genere les avions
                backgroundWorkerGenerator.RunWorkerAsync();
                
                //On get les news de l'aeroport à chaque 100ms
                backgroundWorkerGetNews.RunWorkerAsync();

                buttonStart.Enabled = false;
                buttonPause.Enabled = true;
                buttonStop.Enabled = true;

                //On met a jour les stats de l'aeroport
                labelNomValue.Text = aeroport.Nom;
                labelCodeValue.Text = aeroport.Code;
                labelVilleValue.Text = aeroport.Location;

                //On clear les trucs
                listBoxNouvelles.Items.Clear();
            }
            else
            {
                timerGenerate.Enabled = true;
                buttonStart.Enabled = false;
                buttonPause.Enabled = true;
                backgroundWorkerPaused = false;
            }

        }

        /// <summary>
        /// Met en pause le systeme de l'aeroport. Il suspend le backgroundworker, 
        /// met a pause de timer et change la propriete Enabled de certains boutons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPause_Click(object sender, EventArgs e)
        {
            timerGenerate.Enabled = false;
            buttonPause.Enabled = false;
            buttonStart.Enabled = true;
            backgroundWorkerPaused = true;
        }

        /// <summary>
        /// Arrete le timer, et demande au backgroundworker de s'arreter.
        /// </summary>
        /// <param name="sender">Bouton Stop</param>
        /// <param name="e">Evenement</param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerGenerate.Stop();
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;

            //Demande l'arret
            backgroundWorkerGenerator.CancelAsync();
            backgroundWorkerGetNews.CancelAsync();
        }

        /// <summary>
        /// A chaque tick(1 secondes), il met a jour l'ensemble de l'aeroport. Par la suite, il met a jour
        /// les differents composants du formulaire.
        /// </summary>
        /// <param name="sender">Timer</param>
        /// <param name="e">Evenement</param>
        private void timerGenerate_Tick(object sender, EventArgs e)
        {
            aeroport.Update();
            UpdateListBox();
            UpdateGroupBox();
            if (formInfo != null)
                formInfo.UpdateInfos();

            labelTempsValeur.Text = aeroport.Temps.ToString("yyyy-MM-dd: H:mm");
        }

        /// <summary>
        /// Lors du chargement du formulaire, il disable certains boutons tel que arreter et pause.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonPause.Enabled = false;
            buttonStop.Enabled = false;
        }

        /// <summary>
        /// Lorsque l'utilisateur double clique sur un item de la listbox, il affiche un fenetre avec les informations relative
        /// a l'avion selectionnee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxAtterissage_DoubleClick(object sender, EventArgs e)
        {
            if (formInfo == null || !formInfo.Visible)
            {
                formInfo = new FormInfoObjVolants(aeroport.AvionsAttentes.ElementAt(listBoxAtterissage.SelectedIndex));
                formInfo.Show();
            }
            else
            {
                formInfo.Focus();
                formInfo.Objet = aeroport.AvionsAttentes.ElementAt(listBoxAtterissage.SelectedIndex);

            }


        }

        /// <summary>
        /// Lorsque la piste selectionnee est modifie, les libeles avec l'information de la piste sont mis a jour
        /// </summary>
        /// <param name="sender">ComboxBoxPiste</param>
        /// <param name="e">Evenement</param>
        private void comboBoxPisteSelectionne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPisteSelectionne.SelectedItem != null)
            {
                Piste piste = comboBoxPisteSelectionne.SelectedItem as Piste;
                labelAvionValue.Text = piste.NoVolAvion;
                if (piste.EstOccupee && piste.NoVolAvion == "")
                    labelStatutValue.Text = "En préparation";
                else if (piste.EstOccupee)
                {
                    labelStatutValue.Text = "Occupée";
                }
                else
                    labelStatutValue.Text = "Libre";
            }
        }


        /// <summary>
        /// Lorsque la listbox des nouvelles est dessine, on empeche que l'image scintille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.Items.Count > 0)
            {
                //
                // Draw the background of the ListBox control for each item.
                // Create a new Brush and initialize to a Black colored brush
                // by default.
                //

                //On cast notre text
                string text = listBoxNouvelles.Items[e.Index].ToString();





                e.DrawBackground();

                Brush myBrush = Brushes.Black;
                //
                // Determine the color of the brush to draw each item based on 
                // the index of the item to draw.
                //

                if (text.Contains("écrasé"))
                    myBrush = Brushes.Red;

                //
                // Draw the current item text based on the current 
                // Font and the custom brush settings.
                //
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                //
                // If the ListBox has focus, draw a focus rectangle 
                // around the selected item.
                //
                e.DrawFocusRectangle();
            }
        }

        
        /// <summary>
        /// Va chercher s'il y a de nouvelles nouvelles de la part de l'aeroport. Si oui, il recupere celle-ci et les affichent.
        /// Il Clear la liste de nouvelles dans l'aeroport par la suite.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerGetNews_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!backgroundWorkerGetNews.CancellationPending)
            {
                while(backgroundWorkerPaused)
                {
                    Thread.Sleep(100);
                    //On attend
                }

                //Nouvelles

                //On ajoute seulement les nouvelles entrees
                List<string> listeTemp = aeroport.StringDump;
                foreach (string str in listeTemp)
                {
                    listBoxNouvelles.Invoke((Action<string>)AddItemToListBoxNouvelles,str);
                }
                //On clear les nouvelles
                aeroport.StringDump.Clear();

                //On attend 100ms
                Thread.Sleep(100);
            }

            backgroundWorkerGetNews.ReportProgress(100);
            e.Cancel = true;
        }

        /// <summary>
        /// Genere des avions de facon random a chaque 3 a 10 secondes. Il genere entre 1 et 3 avions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerGenerator_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rnd = new Random();

            while (!backgroundWorkerGenerator.CancellationPending)
            {
                while (backgroundWorkerPaused)
                {
                    Thread.Sleep(100);
                    //On attend
                }

                //Génère de 1 à 3 avions
                for (int i = 0; i < rnd.Next(1, 4); i++)
                {

                    if (rnd.Next(0, 2) == 0)
                    {
                        //Créer un nouvel avion 
                        aeroport.AjouterAvionAttente(new GrosAvion(NoVolRandom(), rnd.Next(20, 150), new DateTime(rnd.Next(1, 10), rnd.Next(1, 12), rnd.Next(1, 29)), new DateTime(rnd.Next(1, 10), rnd.Next(1, 12), rnd.Next(1, 29)), new DateTime(rnd.Next(1, 10), rnd.Next(1, 12), rnd.Next(1, 29))));
                    }
                    else
                    {
                        aeroport.AjouterAvionAttente(new PetitAvion(NoVolRandom(), rnd.Next(20, 150), new DateTime(rnd.Next(1, 10), rnd.Next(1, 12), rnd.Next(1, 29)), new DateTime(rnd.Next(1, 10), rnd.Next(1, 12), rnd.Next(1, 29)), new DateTime(rnd.Next(1, 10), rnd.Next(1, 12), rnd.Next(1, 29))));
                    }
                }
                //Chaque [3 à 10 sec], génère des avions
                Thread.Sleep(rnd.Next(3000, 10000));
                backgroundWorkerGenerator.ReportProgress(0);
            }
            backgroundWorkerGenerator.ReportProgress(100);

            e.Cancel = true;
        }

        /// <summary>
        /// Lorsqu'il est fini, si l'autre backgroundworker a aussi complete son travail, il enable le bouton demarrer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerGenerator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!backgroundWorkerGetNews.IsBusy)
            buttonStart.Enabled = true;
        }

        /// <summary>
        /// Lorsqu'il est fini, si l'autre backgroundworker a aussi complete son travail, il enable le bouton demarrer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerGetNews_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!backgroundWorkerGenerator.IsBusy)
                buttonStart.Enabled = true;
        }


        /// <summary>
        /// Procedure pour ajouter des strins a la listebox Nouvelles. Utile pour utiliser l'INVOKE pour le backgroundworker
        /// </summary>
        /// <param name="value"></param>
        private void AddItemToListBoxNouvelles(string value)
        {
            listBoxNouvelles.Items.Insert(0,value);
        }

        private void backgroundWorkerGenerator_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Update();
        }
        
    }
}
