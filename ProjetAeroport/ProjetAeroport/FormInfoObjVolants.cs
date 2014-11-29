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

        private void FormInfoObjVolants_Load(object sender, EventArgs e)
        {

        }

    }
}
