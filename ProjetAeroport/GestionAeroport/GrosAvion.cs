// GrosAvion.cs 
// Description du programme : 
// Programmé par Alexis Coté et Antony Garand ~ Tous drois réservé ~
// Le : 14 novembre 2014         
// Historique des modifications
// Par : Alexis Côté
// Le : 16 novembre 2014
// Modif : Création des constructeurs et de la structure de base de cette classe et de la methode ToString().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    public class GrosAvion:ObjVolants
    {
        //Variables membres


        //Constructeurs

        /// <summary>
        /// Cree un gros avion comme s'il etait neuf.
        /// </summary>
        /// <param name="consommation">Consommation d'essence (L/min)</param>
        /// <param name="maxEssence">Taille maximale du reservoir de kerosene en L</param>
        /// <param name="nbPassagers">Limite maximale de passagers</param>
        public GrosAvion(double consommation, int maxEssence, int nbPassagers)
            : base(3,2,consommation,maxEssence,nbPassagers)
        {

        }


        /// <summary>
        /// Cree un gros avion selon les parametres
        /// </summary>
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
        /// <param name="progressionStatut">Progression par rapport au statut de l'avion</param>
        public GrosAvion(double consommation, int maxEssence, int nbPassagers,string noVol,
            string model,StatutAvion statut,double essenceActuel,DateTime tempsDeVolTotal,DateTime dateDepart,DateTime dateArrivePrevue,int progressionStatut)
            :base(3,2,consommation,maxEssence,nbPassagers,noVol,model,statut,essenceActuel,tempsDeVolTotal,dateDepart,dateArrivePrevue,progressionStatut)
        {

        }
        
        
        //Methodes 

        /// <summary>
        /// Affiche quelques informations essentielles a un gros avion.
        /// </summary>
        /// <returns>Retourne un string contenant :No. Vol, nb. de passagers et le temps maximal qu'il peut passer en vol avec l'essence.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("No. Vol :" + noVol + "|");
            sb.Append("Nb pass. : " + nbPassagers + "|");
            sb.Append("Temps restant : " + essenceActuel / consommation + " minutes.");
            return sb.ToString();

        }
        
        //Proprietes
    }
}
