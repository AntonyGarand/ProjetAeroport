// Embarquadere.cs 
// Description du programme : 
// Programé par Antony Garand
// Le : 21 octobre 2014    
using System;
using System.Windows.Forms.VisualStyles;

namespace GestionAeroport
{
    public class Embarquadere
    {
        private bool libre;
        private bool termine;
        private ObjVolants _avion;
        private int tempsActuel;
        private int _tempsRequis;

        /// <summary>
        /// Met à jour le status de l'embarquadère, ***appeler cette fonction à un interval stable***
        /// </summary>
        public void Update()
        {
            if (libre || termine)
                return;
            if (++tempsActuel >= _tempsRequis)
                termine = true;
            else
                tempsActuel++;
        }
        /// <summary>
        /// Permet à un avion de remplir son essence et ses passagers
        /// </summary>
        /// <param name="tempsRequis">Temps requis pour embarquer les passagers</param>
        /// <param name="avion">Avion qui doit embarquer les passagers</param>
        /// <param name="nbPassager">Nombre de passagers qui doivent embarquer dans l'avion</param>
        public void Embarquer(int tempsRequis, ObjVolants avion, int nbPassager)
        {
            _avion = avion;
            tempsActuel = 0;
            _tempsRequis = tempsRequis;
            libre = false;
            termine = false;
            avion.EssenceActuel = avion.MaxEssence;
            avion.NbPassagers = nbPassager;
        }
        /// <summary>
        /// Permet à un avion de se débarasser de ses passagers
        /// </summary>
        /// <param name="tempsRequis">Temps requis à l'avion avant de terminer</param>
        public void Debarquer(int tempsRequis)
        {
            tempsActuel = 0;
            _tempsRequis = 0;
            libre = false;
            termine = false;
        }
        /// <summary>
        /// Permet de retirer l'avion prenant actuellement l'embarquadère
        /// </summary>
        /// <returns>Avion ayant teminé</returns>
        public ObjVolants RetirerAvion()
        {
            if (!termine)
                throw new EmbarquadereNonTermine("L'avion n'à pas encore terminée avec l'embarquadère! Il est impossible de la retirer");
            ObjVolants avionBackup = _avion;
            _avion = default(ObjVolants);
            tempsActuel = 0;
            _tempsRequis = 0;
            libre = true;
            return avionBackup;
        }

        /// <summary>
        /// Permet à l'aéroport de savoir si l'embarquadère est libre
        /// </summary>
        public bool Libre
        {
            get { return libre; }
        }
        /// <summary>
        /// Permet à l'aéroport de savoir si l'avion en place à terminer
        /// </summary>
        public bool Termine
        {
            get { return termine; }
        }

    }    
    /// <summary>
    /// Exception causée par l'essai de retirer un avion lorsqu'elle n'à pas terminé son travail
    /// </summary>
    public class EmbarquadereNonTermine : Exception
    {
        public EmbarquadereNonTermine(string message) : base(message)
        {
        }
    }
}
