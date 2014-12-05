// Aeroport.cs 
// Description du programme : 
// Programmé par Alexis Coté et Antony Garand ~ Tous drois réservé ~
// Le : 14 novembre 2014         
// Historique des modifications
// Par : Alexis Côté
// Le : 18 novembre 2014
// Description : Creation des methodes pour la gestion des avions en attente

// Par Alexis Côté
// Le : 28 Novembre 2014
// Description : Finalisation de la gestion aerienne. Ajout d'une méthode qui retourne un tableau avec les objets des avions en attente.

// Par Antony Garand
// Le 5 décembre 2014
// Description: Ajout de la gestion des avions au sol, ajout des embarquadères et Hangar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionAeroport
{
    /* TODO : Simon veut un temps d'attente dans les taxi way et autres
       TODO : Le temps est pour transporter un avion à ailleurs*/

    /// <summary>
    /// Creation d'une classe aeroport. Celle-ci prendra en compte la gestion de l'atterrissage, de decollage et des avions en attente.
    /// </summary>
    public class Aeroport
    {


        //Variables membres
        private Hangar<ObjVolants>hangar;
        private Heap<ObjVolants> avionsEnAttentes;
        private List<string> stringDump;
        private List<Piste> pistes;
        private DateTime temps;
        private string nom, location, code;
        private Embarquadere[] embarquadere;


        //Constructeur

        /// <summary>
        /// Créer un aéroport avec une seule piste, 
        /// </summary>
        public Aeroport()
        {
            avionsEnAttentes = new Heap<ObjVolants>();
            stringDump = new List<string>();
            pistes = new List<Piste>();
            pistes.Add(new Piste());
            temps = new DateTime();
            temps = DateTime.Now;
            nom = "Garalex";
            location = "Victoriaville";
            code = "VIC";

            embarquadere = new Embarquadere[3];
            hangar = new Hangar<ObjVolants>(10);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbPistes">Nombre de pistes a ajouter</param>
        public Aeroport(uint nbPistes, string nom, string code, string location, uint nbEmbarquadere, uint nbPlaceHangar)
        {
            avionsEnAttentes = new Heap<ObjVolants>();
            pistes = new List<Piste>();
            for (int i = 0; i < nbPistes; i++)
            {
                pistes.Add(new Piste());
            }
            this.nom = nom;
            this.code = code;
            this.location = location;
            embarquadere = new Embarquadere[nbEmbarquadere];
            hangar = new Hangar<ObjVolants>(nbPlaceHangar);
        }

        //Methodes

        /// <summary>
        /// Ajoute un objetvolant dans la zone aerienne de l'aeroport.
        /// </summary>
        /// <param name="objetVolant">Avion à ajouter</param>
        public void AjouterAvionAttente(ObjVolants objetVolant)
        {
            avionsEnAttentes.Ajouter(objetVolant);

        }

        /// <summary>
        /// Redirige un avion vers un autre aeroport
        /// </summary>
        /// <param name="objVolants">Avion à ajouter</param>
        public void RedirigerAvion(ObjVolants objVolants)
        {
            //TODO: Gerer la redirection de l'avion
            throw new NotImplementedException("Alexis fais mal ça job.. Sorry!");
        }

        /// <summary>
        /// Gere les avions dans les airs et gere le decollage
        /// </summary>
        public void UpdateGestionAerienne()
        {
            //TODO :  Extra : Implementer la gestion aerienne pour l'ensemble des pistes
            if (!pistes[0].EstOccupee) //Si la piste est libre
            {
                //Atterir
                if (avionsEnAttentes.Nombre > 0) //S'il y a un avion qui peut atterrir
                {
                    if (pistes[0].FileAttente.Count == 0) // Si aucun avions est en attente de decoller, la piste peut être utiliser
                    {
                        //On fait atterrir le premier en attente
                        pistes[0].Atterrir(avionsEnAttentes.Extraire());
                    }
                    else if (avionsEnAttentes.Peek().TempsRestant > pistes[0].FileAttente.Peek().TempsDecollage + pistes[0].TempsPreparationPiste) // Pas d'urgence d'atterir
                    {
                        //On a le temps de faire decoller un avion
                        pistes[0].Decoller();
                    }
                    else
                    {
                        //Il est urgent de faire atterir cet avion
                        pistes[0].Atterrir(avionsEnAttentes.Extraire());
                    }


                }
                else if (pistes[0].FileAttente.Count > 0) // S'il y a des avions qui peuvent decoller
                {
                    //Fait decoller le premier avion dans la file
                    pistes[0].Decoller();
                }
            }//Fin piste !occupe


            if ((double)(NombreObjVolants / Capacite) >= 0.8) //On veut remplir l'aeroport a un maximum de 80%
            {
                while (avionsEnAttentes.Peek().TempsRestant <= avionsEnAttentes.Peek().TempsAtterissage * 2) //Pas assez de gaz pour attendre. On fait fois 2 question d'avoir un certaine marge 
                {
                    RedirigerAvion(avionsEnAttentes.Extraire());
                }
            }
            else //On verifie le temps d'attente dans les airs
            {
                //TODO : Verifier le temps d'attente des avions ->Implementer des variables initialiser lors d'envoi vers autres aeroport
            }

        }//Fin gestion aerienne

        /// <summary>
        /// Met a jour les elements de l'aeroport.(Considerant cet appel comme une minute)
        /// </summary>
        public void Update()
        {
            //On met a jour le temps
            temps = temps.AddMinutes(1);

            //TODO : mettre a jour les differents elements de l'aeroport

            //On met à jour les embarquadères
            foreach (Embarquadere t in embarquadere)
            {
                t.Update();
            }

            //Met a jour l'essence des objets volants.
            if (!avionsEnAttentes.EstVide)
            {
                ObjVolants[] tableauTmp = avionsEnAttentes.Tableau;
                for (int i = 0; i < tableauTmp.Length; i++)
                {
                    if (tableauTmp[i] != null)
                        tableauTmp[i].EssenceActuel -= tableauTmp[i].Consommation;
                }
                //On regarde le niveau d'essence

                //gestion des avions qui crash

                while (avionsEnAttentes.Peek().TempsRestant <= 0)
                {
                    //On l'ajoute aux avions detuites
                    ObjVolants avions = avionsEnAttentes.Extraire();
                    avions.Statut = ObjVolants.StatutAvion.Ecrase;
                    stringDump.Add(temps.ToString("yyyy-MM-dd: H:mm") + "\t: " + "-L'avion " + avions.NoVol + " s'est écrasé.");
                }
            } //FIN S'il y a des avions en attente

        }//Fin update

        public void UpdateGestionSol()
        {
            //1. On vérifie si les embarquadères ont terminés
            foreach (Embarquadere t in embarquadere)
            {
                //S'il à terminé
                if (t.Termine && !t.Libre)
                {
                    //Si l'avion embarquait des passagers et allait vers la piste de décollage, et qu'il reste de la place dans la file d'attente
                    if (t.Embarquer && pistes[0].TailleFileAttente > pistes[0].FileAttente.Count)
                    {
                        ObjVolants avion = t.RetirerAvion();

                    }
                    
                }
            }


            //1. On vérifie s'il y a des avions en attente pour débarquer les passagers
            //TODO: Gestion pour plusieurs pistes
            if (pistes[0].TaxiWay.Peek() != null)
            {
                foreach (Embarquadere i in embarquadere)
                {
                    if (i.Libre)
                    {
                        ObjVolants avion = pistes[0].TaxiWay.Dequeue();
                        //+3 = temps de déplacement pour se rendre à l'embarquadère
                        i.Debarquer(avion.NbPassagers/20 + 3,avion);
                        break;
                    }
                }
            }
            //2. On vérifie s'il y a des avions terminées avec l'embarquadère
        }

        //Proprietes

        /// <summary>
        /// Retourne le nombre maximum que peut contenir l'aeroport
        /// </summary>
        public uint Capacite
        {

            //TODO : Complete cette propriete qui devra retourne l'ensemble de places dans l'aeroport
            get
            {
                uint capacite = 0;
                for (int i = 0; i < pistes.Count; i++)
                {
                    capacite += pistes[i].TailleFileAttente + pistes[i].TailleTaxiWay;
                }

                return capacite;
            }
        } // Fin propriete capacite


        /// <summary>
        /// Retourne le nombre d'avions qui utilise les les infrastructures de l'aeroport
        /// </summary>
        public uint NombreObjVolants
        {
            //TODO : Calculer le nombre d'objets volants
            get { return 10; }
        }


        /// <summary>
        /// Retourne une liste d'avions detruites
        /// </summary>
        public List<string> StringDump
        {
            get { return stringDump; }
            set { stringDump = value; }
        }



        /// <summary>
        /// Retourne l'heure de l'aeroport
        /// </summary>
        public DateTime Temps
        {
            get { return temps; }
        }

        /// <summary>
        /// Code de l'aeroport(3 lettres)
        /// </summary>
        public string Code
        {
            get { return code; }
        }

        /// <summary>
        /// Retourne le nom de l'aeroport
        /// </summary>
        public string Nom
        {
            get { return nom; }
        }

        /// <summary>
        /// Retourne le nom de la ville où se situe l'aeroport
        /// </summary>
        public string Location
        {
            get { return location; }
        }

        /// <summary>
        /// Retourne la liste de toutes les pistes de l'aeroport
        /// </summary>
        public List<Piste> Pistes
        {
            get { return pistes; }
        }

        /// <summary>
        /// Permet d'obtenir le tableau des avions en attente. 
        /// </summary>
        public ObjVolants[] AvionsAttentes
        {
            get
            {
                return avionsEnAttentes.Tableau;
            }
        }


    }
}
