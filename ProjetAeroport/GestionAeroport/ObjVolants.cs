// ObjVolants.cs 
// Description du programme : 
// Programmé par Alexis Coté et Antony Garand ~ Tous drois réservé ~
// Le : 14 novembre 2014         
// Historique des modifications
// Par : Alexis Côté
// Le : 16 novembre 2014
// Modif : Création des constructeurs et de la structure de base de cette classe.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    /// <summary>
    /// Cree un objet volants. Il servira de parent aux avions et helicopteres.
    /// </summary>
    public abstract class ObjVolants : IComparable<ObjVolants>
    {
       

        /// <summary>
        /// Represente le statut de l'avion par rapport a l'aeroport.
        /// </summary>
        public enum StatutAvion
        {
            EnVol,
            AuSol,
            Decollage,
            Atterissage,
            SurPisteEnAttente,
            Ecrase
        };


         //Variables membres

        protected double tempsAtterissage, tempsDecollage;
        protected double essenceActuel,consommation;
        protected int maxEssence, nbPassagers, _maxPassager;
        protected string noVol, model;
        protected DateTime dateDepart, dateArrivePrevue;
        protected DateTime tempsDeVolTotal;
        protected StatutAvion statut;

        //Utilise lors de l'atterissage et decollage (ex : atterissage = 3 seconde. La progression augmentera jusqua 3)
        protected int progressionStatut;

        //Constructeur

        /// <summary>
        /// Cree un objet volant. Cree un avion comme si elle arrivait du fournisseur
        /// </summary>
        /// <param name="tempsAtterissage">Nombre de minutes pour atterir</param>
        /// <param name="tempsDecollage">Nombre de minutes pour decoller</param>
        /// <param name="consommation">Consommation d'essence (L/min)</param>
        /// <param name="maxEssence">Taille du reservoir en Litres</param>
        /// <param name="nbPassagers">Nombre maximum de passagers incluant l'equipage</param>
        public ObjVolants(double tempsAtterissage,double tempsDecollage,double consommation,int maxEssence,int nbPassagers)
        {
            this.TempsAtterissage = tempsAtterissage;
            this.TempsDecollage = tempsDecollage;
            this.Consommation = consommation;
            this.MaxEssence = maxEssence;
            this.NbPassagers = nbPassagers;
            this.noVol = GetCode();
            this.model = "A14";
            this.statut = StatutAvion.AuSol;
            this.essenceActuel = 0;
            this.tempsDeVolTotal = new DateTime(0,0,0);
            this.dateDepart = new DateTime(0, 0, 0);
            this.dateArrivePrevue = new DateTime(0, 0, 0);
            this.progressionStatut = 0;
        }

        /// <summary>
        /// Cree un objet volant. Cet objet volant aura sera definie completement lors de son instanciation.
        /// </summary>
        /// <param name="tempsAtterissage">Nombre de minutes pour atterir</param>
        /// <param name="tempsDecollage">Nombre de minutes pour decoller</param>
        /// <param name="consommation">Consommation d'essence (L/min)</param>
        /// <param name="maxEssence">Taille du reservoir en L</param>
        /// <param name="nbPassagers">Nombre maximum de passagers incluant l'equipage</param>
        /// <param name="noVol">Nom de code du numero de vol.</param>
        /// <param name="model">Nom du model d'avion</param>
        /// <param name="statut">Statut de l'avion</param>
        /// <param name="essenceActuel">Quantite d'essence actuelle en L</param>
        /// <param name="tempsDeVolTotal">Temps de vol total de l'avion</param>
        /// <param name="dateDepart">Date de depart de l'avion</param>
        /// <param name="dateArrivePrevue">Date d'arrivee prevue</param> 
        public ObjVolants(double tempsAtterissage, double tempsDecollage, double consommation, int maxEssence, int nbPassagers, int maxPassager,string noVol,
            string model,StatutAvion statut,double essenceActuel,DateTime tempsDeVolTotal,DateTime dateDepart,DateTime dateArrivePrevue)
        {
            this.TempsAtterissage = (tempsAtterissage >= 0) ? tempsAtterissage: tempsAtterissage * -1;
            this.TempsDecollage = (tempsDecollage >= 0) ? tempsDecollage: tempsDecollage * -1;
            this.Consommation = consommation;
            this.MaxEssence = maxEssence;
            this.nbPassagers = nbPassagers;
            this.noVol = noVol;
            this.Model = model;
            this.Statut = statut;
            _maxPassager = maxPassager;
            this.EssenceActuel = essenceActuel;
            this.TempsDeVolTotal = tempsDeVolTotal;
            this.DateDepart = dateDepart;
            this.DateArrivePrevue = dateArrivePrevue;
        }

        //Methodes

        

        public int CompareTo(ObjVolants other)
        {
            return this.TempsRestant - other.TempsRestant;
        }

        /// <summary>
        /// Cree un code selon 
        /// </summary>l'ISO 6346 de maniere tout a fait aleatoire. Par : Alexis C.
        /// <returns>Retourne un code en string d'une longueur de 10 caracteres</returns>
        private string GetCode()
        {
            string code ="";
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] nombres = "1234567890".ToCharArray();
            Random rnd = new Random();
            for(int i=0;i<4;i++)
            {
                code += alphabet[rnd.Next(0, alphabet.Length)];
            }
            for(int i=0;i<6;i++)
            {
                code += nombres[rnd.Next(0, nombres.Length)];
            }
            return code;
        }

        //Proprietes

        //TODO : De Alexis -> Gerer les valeurs entrees pour les variables

        public double TempsDecollage
        {
            get { return tempsDecollage; }
            set { tempsDecollage = value; }
        }

        public double TempsAtterissage
        {
            get { return tempsAtterissage; }
            set { tempsAtterissage = value; }
        }

        public double Consommation
        {
            get { return consommation; }
            set { consommation = value; }
        }

        public double EssenceActuel
        {
            get { return essenceActuel; }
            set { essenceActuel = value; }
        }

        public int NbPassagers
        {
            get { return nbPassagers; }
            set { nbPassagers = value; }
        }

         public int MaxPassager
        {
            get
            {
                return _maxPassager;
            }
        }

        public int MaxEssence
        {
            get { return maxEssence; }
            set { maxEssence = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string NoVol
        {
            get { return noVol; }
            set { noVol = value; }
        }

        public DateTime DateArrivePrevue
        {
            get { return dateArrivePrevue; }
            set { dateArrivePrevue = value; }
        }

        protected DateTime DateDepart
        {
            get { return dateDepart; }
            set { dateDepart = value; }
        }

        protected DateTime TempsDeVolTotal
        {
            get { return tempsDeVolTotal; }
            set { tempsDeVolTotal = value; }
        }

        public StatutAvion Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        public int ProgressionStatut
        {
            get { return progressionStatut; }
            set { progressionStatut = value; }
        }
        public int TempsRestant
        {
            get { return (int)(essenceActuel / consommation); }
        }


    }
}
