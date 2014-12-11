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

// Par Alexis Côté
// Le 9 décembre 2014
// Descr: Modification de l'update pour que la classe gere en temps reel la circulation dans l'aeroport
//      : -Modification de l'ajout des string à la stringDump. A la place de faire un .add, on fait un insert(0,string). 
//      :  Ainsi, l'affichage se fait mieux dans le form puisque les derniere information sont en haut.
//      : -La redirection ne fait que detruire l'avions et l'envoyer dans une liste d'avions écrasé.
//      : -MOdification de tous les Foreach, j'ai ajouté un if qui verifie si les elements du foreach e sont pas null
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionAeroport
{
    /// <summary>
    /// Creation d'une classe aeroport. Celle-ci prendra en compte la gestion de l'atterrissage, de decollage et des avions en attente.
    /// </summary>
    public class Aeroport
    {


        //Variables membres
        private Hangar<ObjVolants>_hangar;
        private Heap<ObjVolants> _avionsEnAttentes;
        private List<string> _stringDump;
        private List<Piste> _pistes;
        private List<ObjVolants> _cimetiere;
        private DateTime _temps;
        private string _nom, _location, _code;
        private Embarquadere[] _embarquaderes;
        private List<ObjVolants> _avionsDecolles;

        


        //Constructeur

        /// <summary>
        /// Créer un aéroport avec une seule piste, 
        /// </summary>
        public Aeroport()
        {
            _avionsEnAttentes = new Heap<ObjVolants>();
            _stringDump = new List<string>();
            _pistes = new List<Piste>();
            _pistes.Add(new Piste());
            _temps = new DateTime();
            _temps = DateTime.Now;
            _nom = "Garalex";
            _location = "Victoriaville";
            _code = "VIC";
            _avionsEnAttentes = new Heap<ObjVolants>();
            _cimetiere = new List<ObjVolants>();
            _embarquaderes = new Embarquadere[3];
            for (int i = 0; i < _embarquaderes.Length; i++)
                _embarquaderes[i] = new Embarquadere();
           _hangar = new Hangar<ObjVolants>(10);
           _avionsDecolles = new List<ObjVolants>(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbPistes">Nombre de pistes a ajouter</param>
        public Aeroport(uint nbPistes, string nom, string code, string location, uint nbEmbarquadere, uint nbPlaceHangar)
        {
            _avionsEnAttentes = new Heap<ObjVolants>();
            _pistes = new List<Piste>();
            for (int i = 0; i < nbPistes; i++)
            {
                _pistes.Add(new Piste());
            }
            this._nom = nom;
            this._code = code;
            this._location = location;
            _embarquaderes = new Embarquadere[nbEmbarquadere];
            _hangar = new Hangar<ObjVolants>(nbPlaceHangar);
            _avionsDecolles = new List<ObjVolants>();
        }

        //Methodes

        /// <summary>
        /// Ajoute un objetvolant dans la zone aerienne de l'aeroport.
        /// </summary>
        /// <param name="objetVolant">Avion à ajouter</param>
        public void AjouterAvionAttente(ObjVolants objetVolant)
        {
            _avionsEnAttentes.Ajouter(objetVolant);

        }

        /// <summary>
        /// Redirige un avion vers un autre aeroport
        /// </summary>
        /// <param name="objVolants">Avion à ajouter</param>
        public void RedirigerAvion(ObjVolants objVolants)
        {
            objVolants.Statut = ObjVolants.StatutAvion.Ecrase;
            _stringDump.Insert(0,_temps.ToString("yyyy-MM-dd: H:mm") + "\t: " + "-L'avion " + objVolants.NoVol + " a été redirigé.");
            _cimetiere.Add(objVolants);
        }

        /// <summary>
        /// Gere les avions dans les airs et gere le decollage
        /// </summary>
        public void UpdateGestionAerienne()
        {
            //TODO :  Extra : Implementer la gestion aerienne pour l'ensemble des pistes
            if (!_pistes[0].EstOccupee) //Si la piste est libre
            {
                //Atterir
                if (_avionsEnAttentes.Nombre > 0) //S'il y a un avion qui peut atterrir
                {
                    if (_pistes[0].FileAttente.Count == 0) // Si aucun avions est en attente de decoller, la piste peut être utiliser
                    {
                        //On fait atterrir le premier en attente
                        _pistes[0].Atterrir(_avionsEnAttentes.Extraire());
                    }
                    else if (_avionsEnAttentes.Peek().TempsRestant > _pistes[0].FileAttente.Peek().TempsDecollage + _pistes[0].TempsPreparationPiste) // Pas d'urgence d'atterir
                    {
                        //On a le temps de faire decoller un avion
                        _pistes[0].Decoller();
                    }
                    else
                    {
                        //Il est urgent de faire atterir cet avion
                        _pistes[0].Atterrir(_avionsEnAttentes.Extraire());
                    }


                }
                else if (_pistes[0].FileAttente.Count > 0) // S'il y a des avions qui peuvent decoller
                {
                    //Fait decoller le premier avion dans la file
                    _pistes[0].Decoller();
                }
            }//Fin piste !occupe


            if ((double)(NombreObjVolants / Utilisation) >= 0.8) //On veut remplir l'aeroport a un maximum de 80%
            {
                while (_avionsEnAttentes.Nombre > 0 ) //Pas assez de gaz pour attendre. On fait fois 2 question d'avoir un certaine marge 
                {

                    //Eventuelle redirection
                    /*
                    if(_avionsEnAttentes.Peek().TempsRestant <= _avionsEnAttentes.Peek().TempsAtterissage * 2)
                    RedirigerAvion(_avionsEnAttentes.Extraire());
                    else 
                        break;
                     */
                    if (_avionsEnAttentes.Peek().TempsRestant <= 1)
                    {
                        ObjVolants avions = _avionsEnAttentes.Extraire();
                        avions.Statut = ObjVolants.StatutAvion.Ecrase;
                        _stringDump.Insert(0, _temps.ToString("yyyy-MM-dd: H:mm") + "\t: " + "-L'avion " + avions.NoVol + " s'est écrasé.");
                        _cimetiere.Add(avions);

                    }
                    else
                        break;
                      
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
            _temps = _temps.AddMinutes(1);


            UpdateGestionAerienne();
            UpdateGestionSol();


            foreach(Piste p in _pistes)
            {
                if (p != null)
                    p.Update();
            }
            for (int i = 0; i < _pistes.Count;i++ )
            {
                if (_pistes[i].AvionsDecolles.Count > 0)
                {
                    _avionsDecolles.AddRange(_pistes[i].AvionsDecolles);

                    //On ecrit un message comme quoi les avions on decolle
                    for(int j=0;j<_pistes[i].AvionsDecolles.Count;j++)
                    {
                        ObjVolants avions = _pistes[i].AvionsDecolles[j];
                        _stringDump.Insert(0,_temps.ToString("yyyy-MM-dd: H:mm") + "\t: " + "-L'avions " + avions.NoVol + " a decolle.");
                    }

                    //On efface les avions
                    _pistes[i].AvionsDecolles.Clear();
                }
            }


                //On met à jour les embarquadères
                foreach (Embarquadere t in _embarquaderes)
                {
                    if (t != null)
                        t.Update();
                }

            //Met a jour l'essence des objets volants.
            if (!_avionsEnAttentes.EstVide)
            {
                ObjVolants[] tableauTmp = _avionsEnAttentes.Tableau;
                for (int i = 0; i < tableauTmp.Length; i++)
                {
                    if (tableauTmp[i] != null)
                        tableauTmp[i].EssenceActuel -= tableauTmp[i].Consommation;
                }
            } //FIN S'il y a des avions en attente

        }//Fin update

        public void UpdateGestionSol()
        {
            //1. On vérifie si les embarquadères ont terminés
            foreach (Embarquadere t in _embarquaderes)
            {
                if (t != null)
                {
                    
                    //S'il à terminé
                    if (t.Termine && !t.Libre)
                    {
                        //Si l'avion embarquait des passagers et allait vers la piste de décollage, et qu'il reste de la place dans la file d'attente
                        if (t.Embarquer && _pistes[0].TailleFileAttente > _pistes[0].FileAttente.Count)
                        {
                            ObjVolants avion = t.RetirerAvion();
                            _pistes[0].FileAttente.Enqueue(avion);
                            _stringDump.Insert(0,_temps.ToString("yyyy-MM-dd: H:mm") + "\t: " + "-L'avion " + avion.NoVol + " a quitte l'embarquadere.");
                        }
                        //Si l'avion allait dans un hangar attendre
                        if (!t.Embarquer && _hangar.Count <= _hangar.Grandeur)
                        {
                            ObjVolants avion = t.RetirerAvion();
                            _hangar.Ranger(avion);
                            _stringDump.Insert(0,_temps.ToString("yyyy-MM-dd: H:mm") + "\t: " + "-L'avion " + avion.NoVol + " se stationne dans un hangar.");
                        }
                    }
                }
            }

            //2. On vérifie s'il y a des avions en attente pour débarquer les passagers
            //TODO: Gestion pour plusieurs pistes
            if (_pistes[0].TaxiWay.Count > 0)
            {
                foreach (Embarquadere i in _embarquaderes)
                {
                    if (i != null)
                    {
                        if (i.Libre)
                        {
                            ObjVolants avion = _pistes[0].TaxiWay.Dequeue();
                            //+3 = temps de déplacement pour se rendre à l'embarquadère
                            i.DebarquerAvion(avion.NbPassagers / 20 + 3, avion);
                            _stringDump.Insert(0,_temps.ToString("yyyy-MM-dd: H:mm") + "\t: " + "-L'avion " + avion.NoVol + " debarque ses passagers.");
                            break;
                        }
                    }
                }
            }
            //3. On vérifie si des avions doivent décoller et qu'il y à de la place dans les embarquadères
            foreach (Embarquadere embarq in _embarquaderes)
            {
                if (embarq != null)
                {
                    if (embarq.Libre && _hangar.Regarder())
                    {
                        ObjVolants avion = _hangar.Retirer();
                        Random rnd = new Random();
                        int nbPassagers = rnd.Next(avion.MaxPassager / 5, avion.MaxPassager);
                        embarq.EmbarquerAvion(nbPassagers / 10 + 1, avion, nbPassagers);
                        _stringDump.Insert(0,_temps.ToString("yyyy-MM-dd: H:mm") + "\t: " + "-L'avion " + avion.NoVol + " embarque des passagers.");
                    }
                }
            }
        }

        //Proprietes

        /// <summary>
        /// Retourne le nombre maximum que peut contenir l'aeroport
        /// </summary>
        public uint Utilisation
        {

            //TODO : Complete cette propriete qui devra retourne l'ensemble de places dans l'aeroport
            get
            {
                uint tailleTotal = 0;
               
                for (int i = 0; i < _pistes.Count; i++)
                {
                    tailleTotal += _pistes[i].TailleFileAttente + _pistes[i].TailleTaxiWay;
                }

                return tailleTotal;
            }
        } // Fin propriete capacite


        /// <summary>
        /// Retourne le nombre d'avions qui utilise les les infrastructures de l'aeroport
        /// </summary>
        public uint NombreObjVolants
        {
            //TODO : Calculer le nombre d'objets volants
            get
            {
                uint nombreObjVolants = 0;
                for (int i = 0; i < _pistes.Count;i++ )
                {

                }
                //... 10?
                return 10;
            }
        }


        /// <summary>
        /// Retourne une liste d'avions detruites
        /// </summary>
        public List<string> StringDump
        {
            get { return _stringDump; }
            set { _stringDump = value; }
        }



        /// <summary>
        /// Retourne l'heure de l'aeroport
        /// </summary>
        public DateTime Temps
        {
            get { return _temps; }
        }

        /// <summary>
        /// Code de l'aeroport(3 lettres)
        /// </summary>
        public string Code
        {
            get { return _code; }
        }

        /// <summary>
        /// Retourne le nom de l'aeroport
        /// </summary>
        public string Nom
        {
            get { return _nom; }
        }

        /// <summary>
        /// Retourne le nom de la ville où se situe l'aeroport
        /// </summary>
        public string Location
        {
            get { return _location; }
        }

        /// <summary>
        /// Retourne la liste de toutes les pistes de l'aeroport
        /// </summary>
        public List<Piste> Pistes
        {
            get { return _pistes; }
        }

        /// <summary>
        /// Permet d'obtenir le tableau des avions en attente. 
        /// </summary>
        public ObjVolants[] AvionsAttentes
        {
            get
            {
                return _avionsEnAttentes.Tableau;
            }
        }

        /// <summary>
        /// List avec tous les avions qui ont decolle
        /// </summary>
        public List<ObjVolants> AvionsDecolles
        {
            get { return _avionsDecolles; }
        }


    }
}
