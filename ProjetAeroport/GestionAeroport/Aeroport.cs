// Aeroport.cs 
// Description du programme : 
// Programmé par Alexis Coté et Antony Garand ~ Tous drois réservé ~
// Le : 14 novembre 2014         
// Historique des modifications
// Par : Alexis Côté
// Le : 18 novembre 2014
// Description : Creation des methodes pour la gestion des avions en attente

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GestionAeroport
{
    /// <summary>
    /// Creation d'une classe aeroport. Celle-ci prendra en compte la gestion de l'atterrissage, de decollage et des avions en attente.
    /// </summary>
    public class Aeroport
    {


        //Variables membres
        private MaxQueue<ObjVolants> attentePiste;
        private MaxQueue<ObjVolants> taxiWay;
        private Hangar<ObjVolants> hangarPrincipal; 
        private Heap<ObjVolants> avionsEnAttentes;
        private List<Piste> pistes;
        private uint nombreObjVolants;

        

        //Constructeur

        /// <summary>
        /// 
        /// </summary>
        public Aeroport()
        {
            avionsEnAttentes = new Heap<ObjVolants>();
            pistes = new List<Piste>();
            pistes.Add(new Piste());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbPistes">Nombre de pistes a ajouter</param>
        public Aeroport(int nbPistes)
        {
            avionsEnAttentes = new Heap<ObjVolants>();
            pistes = new List<Piste>();
            for(int i=0;i<nbPistes;i++)
            {
                pistes.Add(new Piste());
            }
        }

        //Methodes




        /// <summary>
        /// Ajoute un objetvolant dans la zone aerienne de l'aeroport.
        /// </summary>
        /// <param name="objetVolant"></param>
        public void AjouterAvionAttente(ObjVolants objetVolant)
        {
            avionsEnAttentes.Ajouter(objetVolant);
        }

        /// <summary>
        /// Permet d'obtenir le tableau des avions en attente. 
        /// </summary>
        /// <returns>Tableau d'avions en attente. Retourne leur NoVol, leur temps restant en vol et leur nombre de passagers</returns>
        public string[] GetAvionsAttente()
        {
            string[] copieAvion = new string[avionsEnAttentes.Nombre];
            ObjVolants[] avions = avionsEnAttentes.Tableau;
            for (int i = 0; i < copieAvion.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(avions[i].NoVol);
                sb.Append("\t" + avions[i].TempsRestant);
                sb.Append("\t\t" + avions[i].NbPassagers);
                copieAvion[i] = sb.ToString();
            }
            return copieAvion;
        }

        /// <summary>
        /// Met a jour les elements de l'aeroport.(Considerant cet appel comme une minute)
        /// </summary>
        public void Update()
        {

            //TODO : mettre a jour les differents elements de l'aeroport
            //TODO : Bug avec la quantite d'essence

            //Met a jour l'essence des objets volants.
            if (!avionsEnAttentes.EstVide)
            {
                ObjVolants[] tableauTmp = avionsEnAttentes.Tableau;
                for (int i = 0; i < tableauTmp.Length; i++)
                {
                    tableauTmp[i].EssenceActuel -= tableauTmp[i].Consommation;
                }
            }

        }

        /// <summary>
        /// Redirige un avion vers un autre aeroport
        /// </summary>
        public void RedirigerAvion(ObjVolants objVolants)
        {
            //TODO: Gerer la redirection de l'avion
        }


        public void GestionAerienne()
        {
            //TODO : Implementer la gestion aerienne pour l'ensemble des pistes
            if(!pistes[0].EstOccupee) //Si la piste est libre
            {
                //Atterir
                if (avionsEnAttentes.Nombre > 0) //S'il y a un avion qui peut atterrir
                {
                    if (pistes[0].FileAttente.Count == 0) // Si aucun avions est en attente de decoller, la piste peut être utiliser
                    {
                        //On fait atterrir le premier en attente
                        if (pistes[0].Atterrir(avionsEnAttentes.Extraire()))
                            nombreObjVolants++;
                    }
                    else if (avionsEnAttentes.Peek().TempsRestant > pistes[0].FileAttente.Peek().TempsDecollage+pistes[0].TempsPreparationPiste) // Pas d'urgence d'atterir
                    {
                        //On a le temps de faire decoller un avion
                        if (pistes[0].Decoller())
                            nombreObjVolants--;
                    }
                    else
                    {
                        //Il est urgent de faire atterir cet avion
                        if (pistes[0].Atterrir(avionsEnAttentes.Extraire()))
                            nombreObjVolants++;
                    }

                    
                }
                else if(pistes[0].FileAttente.Count > 0) // S'il y a des avions qui peuvent decoller
                {
                    //Fait decoller le premier avion dans la file
                    if (pistes[0].Decoller())
                        nombreObjVolants--;
                }
            }//Fin piste !occupe

            //Redirection
            if ((double)(nombreObjVolants / Capacite) >= 0.8) //On veut remplir l'aeroport a un maximum de 80%
            {
                while (avionsEnAttentes.Peek().TempsRestant <= avionsEnAttentes.Peek().TempsAtterissage * 2) //Pas assez de gaz pour attendre. On fait fois 2 question d'avoir un certaine marge 
               {
                 RedirigerAvion(avionsEnAttentes.Extraire());
                 nombreObjVolants--;
               }
            }
            else //On verifie le temps d'attente dans les airs
            {
                //TODO : Verifier le temps d'attente des avions ->Implementer des variables initialiser lors d'envoi vers autres aeroport
                //On utilisation d'un dictionnary les keys seraient les objets et la valeur serait le temps d'Attente
            }
            
        }//Fin gestion aerienne

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
                for(int i=0;i<pistes.Count;i++)
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
            get { return nombreObjVolants; }
        }


    }
}
