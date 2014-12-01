///FormInfoObjVolants.cs
///Stylisé par Alexis Côté
///Le 28 novembre
///
///Modification le 28 nov: 
/// Affichage des informations de base par rapport aux avions
///
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
using GestionAeroport;

namespace ProjetAeroport
{
    public partial class FormInfoObjVolants : Form
    {
        private ObjVolants objet;


        public FormInfoObjVolants(ObjVolants objet)
        {
            InitializeComponent();
            this.objet = objet;
        }

        /// <summary>
        /// Definie si le texte dans la progress bar doit etre centre ou a gauche.
        /// </summary>
        public enum ProgressBarTextLocation
        {
            Left,
            Centered
        }

        private void FormInfoObjVolants_Load(object sender, EventArgs e)
        {
            labelNoVolValue.Text = objet.NoVol;
            labelStatutValue.Text = objet.Statut.ToString();
            labelNbPassagers.Text = objet.NbPassagers.ToString();
            labelTempsRestant.Text = objet.TempsRestant.ToString() + " minutes";
            progressBarEssence.Value = (int)(objet.EssenceActuel / objet.MaxEssence) * 100;
            progressBarEssence.DisplayStyle = CustomProgressBar.ProgressBarDisplayText.CustomText;
            

        }

        /// <summary>
        /// Met à jour les composants du dialog
        /// </summary>
        public void UpdateInfos()
        {
            if (objet.Statut != ObjVolants.StatutAvion.Ecrase)
            {
                labelNoVolValue.Text = objet.NoVol;
                labelStatutValue.Text = objet.Statut.ToString();
                labelNbPassagers.Text = objet.NbPassagers.ToString();
                labelTempsRestant.Text = objet.TempsRestant.ToString() + " minutes";
                
                //Pourcentage
                int percent = (int)(((double)(objet.EssenceActuel) /
                    (double)(objet.MaxEssence)) * 100);
                
                progressBarEssence.Value = percent;
                progressBarEssence.CustomText = "Niveau essence : " + percent + "%";

            }
            else
            {
                labelNoVolValue.Text = "?";
                labelStatutValue.Text = objet.Statut.ToString();
                labelNbPassagers.Text = "?";
                labelTempsRestant.Text = "?";
                progressBarEssence.Value = 0;
                progressBarEssence.CustomText = "";
            }
        }


       
        
        


        //Proprietes 
        public ObjVolants Objet
        {
            get { return objet; }
            set
            {
                //On set le nouvel objet
                objet = value;

            }
        }

    }
}
