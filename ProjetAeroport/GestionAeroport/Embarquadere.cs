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
        private bool libre = true;
        private bool termine = false;
        private ObjVolants _avion;
        private int tempsActuel;
        private int _tempsRequis;
        private bool embarquer;

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
        public void EmbarquerAvion(int tempsRequis, ObjVolants avion, int nbPassager)
        {
            embarquer = true;
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
        public void DebarquerAvion(int tempsRequis, ObjVolants avion)
        {
            embarquer = false;
            _avion = avion;
            tempsActuel = 0;
            _tempsRequis = tempsRequis;
            libre = false;
            termine = false;
            avion.NbPassagers = 0;
        }
        /// <summary>
        /// Permet de retirer l'avion prenant actuellement l'embarquadère
        /// </summary>
        /// <returns>Avion ayant teminé ainsi que bool (Est-ce que l'avion embarquait), pour savoir si l'avion embarquais ou débarquais des passagers</returns>
        public ObjVolants RetirerAvion()
        {
            if (!termine)
                throw new EmbarquadereNonTermine("L'avion n'à pas encore terminée avec l'embarquadère! Il est impossible de la retirer");
            ObjVolants avionBackup = _avion;
            _avion = default(ObjVolants);
            tempsActuel = 0;
            _tempsRequis = 0;
            libre = true;
            termine = false;
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

        public bool Embarquer { get { return embarquer; } }
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
