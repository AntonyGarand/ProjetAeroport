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
        private Heap<ObjVolants> avionsEnAttentes;
        private List<Piste> pistes;

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

            //Todo : mettre a jour les differents elements de l'aeroport


            //Met a jour l'essence des objets volants.
            if (!avionsEnAttentes.EstVide)
            {
                ObjVolants[] tableauTmp = avionsEnAttentes.Tableau;
                for (int i = 0; i < tableauTmp.Length; i++)
                {
                    tableauTmp[i].EssenceActuel = tableauTmp[i].EssenceActuel -= tableauTmp[i].Consommation;
                }
            }

        }



    }
}
