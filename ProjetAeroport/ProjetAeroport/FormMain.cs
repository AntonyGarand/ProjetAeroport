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
///

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

        private void backgroundWorkerGenerator_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rnd = new Random();
            //Chaque [3 à 10 sec], génère des avions
            Thread.Sleep(rnd.Next(3000, 10000));
            //Génère de 1 à 3 avions
            for (int i = 0; i < rnd.Next(1,4); i++)
            {
                //TODO - Corriger l'implémentation des avions
                //heap.Add((rnd.next(0,2)?new GrosAvion()
                //new GrosAvion()
            }
        }
    }
}
