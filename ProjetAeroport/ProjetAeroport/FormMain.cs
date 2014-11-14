///FormMain.cs
///Stylisé par Antony Garand
///Le 24 novembre 2014
///Split containers:
///SplitContainerVertical.Pannel1 = Mises à jour (Haut du form)
///SplitContainerVertical.Pannel2 = Bas du form, 3 sections
///SplitContainerVertical.Pannel1.
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


    }
}
