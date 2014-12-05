// Piste.cs 
// Description du programme : 
// Programmé par Alexis Coté et Antony Garand ~ Tout droits réservés ~
// Le : 23 novembre 2014         
// Historique des modifications
// Par : Alexis Côté
// Le : 23 novembre 2014
// Description : Creation de la structure de base et la gestion de decollage et d'atterissage
// -Ajout de la methode de decollage
// -Ajout de la methode d'atterissage
// -Ajout de la methode Update qui met a jour la piste. Il faut cependant reviser le principe de la piste. Pour l'instant, elle fait atterir le plus d'avions possibles
//  et peut garder un avion atteri en attente sur la piste.
//
// Le: 5 décembre
// Par: Antony Garand
// Description: Ajout d'une MaxQueue comme taxiway et fileAttente

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    public class Piste
    {
        //Variables membres

        private bool occupee;
        //TODO : Faire une classe personnalise d'une Queue. Elle devra avoir une taille fixe.
        private MaxQueue<ObjVolants> taxiWay;
        private MaxQueue<ObjVolants> fileAttente;
        private uint tailleTaxiWay;
        private uint tailleFileAttente;
        private uint progressionPiste;
        private uint tempsPreparationPiste;
        private uint noPiste;
        private ObjVolants utilisateur;

        //Constructeur
        
        /// <summary>
        /// Cree une piste pour d'objets volants. Cette piste a par defaut un taxi way de 3 places ainsi qu'une file attente pour le decollage de 3 places.
        /// Le temps pour preparer la piste apres un atterissage est de 1 seconde par defaut.
        /// </summary>
        public Piste()
        {
            tailleFileAttente = 3;
            tailleTaxiWay = 3;
            taxiWay = new MaxQueue<ObjVolants>((int)tailleTaxiWay);
            fileAttente = new MaxQueue<ObjVolants>((int)tailleFileAttente);
            occupee = false;
            progressionPiste = 0;
            tempsPreparationPiste = 1;
            noPiste = 1;
        }

        /// <summary>
        /// Cree une piste pour les objVolants. Cette piste a un taxi way pour l'atterissage et une file d'attente pour le decollage.
        /// </summary>
        /// <param name="longueurTaxiWay"></param>
        /// <param name="longueurfileAttente"></param>
        public Piste(uint longueurTaxiWay,uint longueurfileAttente,uint tempsPreparationPiste,uint noPiste)
        {
            this.tailleFileAttente = longueurfileAttente;
            this.tailleTaxiWay = longueurTaxiWay;
            taxiWay = new MaxQueue<ObjVolants>((int)longueurTaxiWay);
            fileAttente = new MaxQueue<ObjVolants>((int)longueurfileAttente);
            occupee = false;
            progressionPiste = 0;
            this.tempsPreparationPiste = tempsPreparationPiste;
            this.noPiste = noPiste;
            

        }

        //Methodes

        /// <summary>
        /// Determine si un avion peut decoller  et si celle-ci peut, elle quittera la zone d'attente et decollera.
        /// </summary>
        /// <returns></returns>
        public bool Decoller()
        {
            if (!occupee)
            {
                //SI la piste est libre
                if (fileAttente.Count != 0) //S'il y a des avions qui veulent decoller
                {
                    occupee = true;
                    utilisateur = fileAttente.Dequeue();
                    utilisateur.Statut = ObjVolants.StatutAvion.Decollage;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Deifinie s'il est possible ou pas d'atterir. S'il est possible, l'avion sera prise en charge par la piste et procedera a l'atterrisage.
        /// </summary>
        /// <param name="objet">Objet volant qui tente d'atterir sur la piste.</param>
        /// <returns>Vrai si l'objet a atterie ou Faux si elle n'est pas pu</returns>
        public bool Atterrir(ObjVolants objet)
        {
            if(!occupee) // Si la piste n'est pas occupee
            {
                //On ajoute l'Avion à la piste
                utilisateur = objet;
                utilisateur.Statut = ObjVolants.StatutAvion.Atterissage;
                occupee = true;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Met a jour different composants de la piste. Par exemple, si la piste a besoin d'être prepare, elle le sera. Si un avion est en train de coller
        /// ou bien d'atterrir, la progression continuera.
        /// </summary>
        public void Update()
        {
            if(occupee)
            {
                if(utilisateur == null) // Si un objVolants vient d'atterir/decoller mais que la piste est en preparation
                {
                    if (progressionPiste < tempsPreparationPiste) // Si la preparation n'est pas fini
                        progressionPiste++;
                    else
                    {
                        occupee = false;
                        progressionPiste = 0;
                    }
                }
                else //Si un avion est encore en train d'atterir ou decoller
                {
                    if (utilisateur.Statut == ObjVolants.StatutAvion.Decollage)
                    {
                        if (progressionPiste < utilisateur.TempsDecollage) // Si l'objets volants n'a pas fini de decoller
                            progressionPiste++;
                        else //L'avion s'envole et on prepare la piste
                        {
                            //TODO : Envoyer l'avion somewhere
                            utilisateur.Statut = ObjVolants.StatutAvion.EnVol;
                            utilisateur = null;
                            progressionPiste = 0;
                        }
                    }
                    else if(utilisateur.Statut == ObjVolants.StatutAvion.Atterissage) 
                    {
                        if(progressionPiste < utilisateur.TempsAtterissage) // Si l'avion n'a pas atteri
                            progressionPiste++;
                        else //L'avion a atteri
                        {
                            if(taxiWay.Count < tailleTaxiWay) // S'il reste de la place dans le taxi way
                            {
                                //On l'ajout au taxi way
                                utilisateur.Statut = ObjVolants.StatutAvion.AuSol;
                                taxiWay.Enqueue(utilisateur);

                                //On prepare la piste
                                progressionPiste = 0;
                            }
                            else //Si le taxi way est plein, on fait attendre l'avion sur la piste
                            {
                                utilisateur.Statut = ObjVolants.StatutAvion.SurPisteEnAttente;
                            }
                        } // Fin si avion atteri
                    } // Fin si avion en atterissage
                    else if(utilisateur.Statut == ObjVolants.StatutAvion.SurPisteEnAttente)
                    {
                        if(taxiWay.Count < tailleTaxiWay) // Si il y a de la place dans le taxi way
                        {
                            utilisateur.Statut = ObjVolants.StatutAvion.AuSol;
                            //On ajoute l'avion au taxi way
                            taxiWay.Enqueue(utilisateur);
                            //On libere la piste et la prepare
                            utilisateur = null;
                            progressionPiste = 0;
                        } // Fin si on peut ajouter l'avion en attente sur le taxi way


                    } //Fin si avion est en attente sur piste
                }//Fin si avion en train de decoller ou atterir
            } // Fin si la piste est utilisee
        }


        /// <summary>
        /// Retourne et supprime un element dans le taxiway de cette piste
        /// </summary>
        /// <returns>ObjVolants dans la file</returns>
        public ObjVolants DeQueueTaxiWay()
        {
            return taxiWay.Dequeue();
        }

        /// <summary>
        /// Ajoute un objet volant dans la file d'attente si possible
        /// </summary>
        /// <returns>Vrai si l'ajout a ete fait et Faux si l'ajout n'a pas ete possible</returns>
        public bool EnQueueFileAttente(ObjVolants objet)
        {
            if(fileAttente.Count < tailleFileAttente)
            {
                fileAttente.Enqueue(objet);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return noPiste.ToString();
        }

        //Proprietes

        /// <summary>
        /// Definie si la piste est occupee ou pas
        /// </summary>
        public bool EstOccupee
        {
            get { return occupee; }
        }


        /// <summary>
        /// Get qui retourne  la queue avec les objVolants qui ont atteri
        /// </summary>
        public Queue<ObjVolants> TaxiWay
        {
            get { return taxiWay; }
        }

        /// <summary>
        /// Retourne une queue avec les avions en attente pour decoller.
        /// </summary>
        public Queue<ObjVolants> FileAttente
        {
            get { return fileAttente; }
        }


        /// <summary>
        /// Retourne le necessaire aux unites de l'aeroport pour preparer la piste suite a un decolage ou atterissage.
        /// </summary>
        public uint TempsPreparationPiste
        {
            get { return tempsPreparationPiste; }
            set { tempsPreparationPiste = value; }
        }

        /// <summary>
        /// Retourne la taille du taxiway
        /// </summary>
        public uint TailleTaxiWay
        {
            get { return tailleTaxiWay; }
        }
        
        /// <summary>
        /// Retourne la taille de la file attente
        /// </summary>
        public uint TailleFileAttente
        {
            get { return tailleFileAttente; }
        }

        /// <summary>
        /// Retourne le NoVol de l'avion qui utilise la piste
        /// </summary>
        public string NoVolAvion
        {
            get
            {
                if (utilisateur != null)
                    return utilisateur.NoVol;
                else
                    return "";
            }
        }

        
    }
}
