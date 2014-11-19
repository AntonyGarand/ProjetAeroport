// Heap.cs 
// Description du programme : 
// Programé par Alexis Coté
// Le : 21 octobre 2014           
// Historique des modifications
// Par : Alexis Côté
// Le : 18 novembre 2014
// Modif : -Modifier l'accesseur du tableau pour qu'il retourne un tableau correcte.
//         -Modification de la heap pour qu'elle soit minimum

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    /// <summary>
    /// Structure de donnee en tas. Les donnes dans ce tas doivent etre IComparable. Heap min
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Heap<T> where T : IComparable<T>
    {
        //Variables membres
        private int nombre;
        private T[] tableau;


        //Constructeur

        /// <summary>
        /// Initialise un tas
        /// </summary>
        public Heap()
        {
            tableau = new T[1];
            nombre = 0;
        }


        //Methodes

        /// <summary>
        /// Ajoute une donne dans le tas la ou il y a de la place. Elle sera ensuite classee.
        /// </summary>
        /// <param name="data">Donnee qui sera ajoutee.</param>
        public void Ajouter(T data)
        {
            //Si le tableau est plein
            bool estPlein = true;

            //On cherche le dernier element ajoute
            for (int i = 0; i < tableau.Length; i++)
            {
                //Au premier trou vide
                if (tableau[i] == null)
                {
                    tableau[i] = data;
                    nombre++;
                    estPlein = false;
                    SaucerDuBas(i);
                    break;
                }
            }

            if (estPlein)
            {
                //Resize
                Array.Resize<T>(ref tableau, tableau.Length * 2);
                //On insère le data
                tableau[tableau.Length / 2] = data;
                nombre++;
                //On classe
                SaucerDuBas(tableau.Length / 2);
            }

        }

        /// <summary>
        /// Supprime le premier element de la heap.
        /// </summary>
        /// <param name="tab">Tableau dans lequel sera supprime l'element.</param>
        public T Extraire()
        {
            int curseur = -1;
            //On cherche le dernier element ajoute
            for (int i = 0; i < tableau.Length; i++)
            {
                //Au premier trou vide
                if (tableau[i] == null)
                {
                    curseur = i - 1;
                    break;
                }
            }
            if (curseur == -1)
                throw new InvalidOperationException("Votre tas ne contient aucun elements!");
            else
                return SaucerDuHaut(curseur);
        }

        /// <summary>
        /// Classe les elements a partir du bas du tas.
        /// </summary>
        /// <param name="tableau">Tableau du tas qui sera modifie</param>
        /// <param name="dernierePosition">Derniere position dans le tableau</param>
        private void SaucerDuBas(int dernierePosition)
        {
            int curseur = dernierePosition;
            T valeurTampon;
            while (curseur > 0) // Tant que le parent n'est pas null
            {

                int valeurCompareTo = tableau[curseur].CompareTo(tableau[(int)Math.Floor((double)((curseur - 1) / 2))]);
                if (valeurCompareTo < 0) // On swap
                {
                    //On stock le parent
                    valeurTampon = tableau[(int)Math.Floor((double)((curseur - 1) / 2))];

                    //On swap
                    tableau[(int)Math.Floor((double)((curseur - 1) / 2))] = tableau[curseur];
                    tableau[curseur] = valeurTampon;

                    //curseur = parent
                    curseur = (int)Math.Floor((double)((curseur - 1) / 2));
                }
                else // Rien faire
                    return;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="dernierePosition"></param>
        /// <returns></returns>
        private T SaucerDuHaut(int dernierePosition)
        {
            int curseur = 0; //Racine
            //On swap
            T noeudSupprime = tableau[0];
            tableau[0] = tableau[dernierePosition];
            //On supprr
            tableau[dernierePosition] = default(T);
            nombre--;

            while (tableau[curseur] != null && curseur * 2 + 2 < tableau.Length)
            {
                //Le while regarde s'il peut y avoir des enfants
                if (tableau[(curseur * 2 + 1)] == null && tableau[(curseur * 2 + 2)] == null)
                {
                    return noeudSupprime;
                }
                else if (tableau[curseur * 2 + 1] == null) //Enfant droit n'est pas null 
                {
                    if (tableau[curseur].CompareTo(tableau[curseur * 2 + 2]) > 0) //On swap
                    {
                        T noeudTemp = tableau[curseur];
                        tableau[curseur] = tableau[curseur * 2 + 2];
                        tableau[curseur * 2 + 2] = noeudTemp;
                    } //Sinon on swap pas
                }
                else if (tableau[curseur * 2 + 2] == null) //Enfant gauche n'est pas null
                {
                    if (tableau[curseur].CompareTo(tableau[curseur * 2 + 1]) > 0) //On swap
                    {
                        T noeudTemp = tableau[curseur];
                        tableau[curseur] = tableau[curseur * 2 + 1];
                        tableau[curseur * 2 + 1] = noeudTemp;
                    } //Sinon on swap pas
                }
                else //Si les deux sont pas nul
                {
                    if (tableau[curseur * 2 + 1].CompareTo(tableau[curseur * 2 + 2]) < 0) //Celui de gauche est plus grand
                    {
                        if (tableau[curseur].CompareTo(tableau[curseur * 2 + 1]) > 0) //On swap
                        {
                            T noeudTemp = tableau[curseur];
                            tableau[curseur] = tableau[curseur * 2 + 1];
                            tableau[curseur * 2 + 1] = noeudTemp;
                        } //Sinon on swap pas
                    }
                    else //Celui de droit est plus grand ou egal
                    {
                        if (tableau[curseur].CompareTo(tableau[curseur * 2 + 2]) > 0) //On swap
                        {
                            T noeudTemp = tableau[curseur];
                            tableau[curseur] = tableau[curseur * 2 + 2];
                            tableau[curseur * 2 + 2] = noeudTemp;
                        } //Sinon on swap pas
                    }
                }


            }
            return noeudSupprime;
        }



        /// <summary>
        /// Prend une liste chainee et la met dans un tas. On retourne ensuite une nouvelle liste chainee
        /// en ordre.
        /// </summary>
        /// <param name="liste">Liste qui sera inserer dans la heap.</param>
        /// <returns>Liste chainee en ordre du tas.</returns>
        public static LinkedList<T> HeapSort(LinkedList<T> liste)
        {
            if (liste.Count > 0) //Liste n'est pas vide
            {
                Heap<T> heap = new Heap<T>();
                foreach (T element in liste)
                {
                    heap.Ajouter(element);
                }
                LinkedList<T> nouvelleListe = new LinkedList<T>();
                while (!heap.EstVide)
                {
                    nouvelleListe.AddLast(heap.Extraire());
                }
                return nouvelleListe;

            }
            else
                throw new InvalidOperationException("La liste est vide.");
        }



        /// <summary>
        /// Retourne la valeur maximum du tas.
        /// </summary>
        /// <returns>Valeur maximum du tas.</returns>
        public T Peek()
        {
            if (!EstVide)
            {
                return tableau[0];
            }
            else
                throw new InvalidOperationException("Le tas est vide!");
        }

        /// <summary>
        /// Vide la heap au complet.
        /// </summary>
        public void Vider()
        {
            for (int i = 0; i < nombre; i++)
            {
                tableau[i] = default(T);
            }
            nombre = 0;
        }

        //Proprietes

        /// <summary>
        /// Retourne le nombre d'element dans la heap
        /// </summary>
        public int Nombre
        {
            get { return nombre; }
        }

        /// <summary>
        /// Definie si cette heap est vide.
        /// </summary>
        public bool EstVide
        {
            get
            {
                if (nombre == 0)
                    return true;
                return false;
            }
        }



        /// <summary>
        /// Retourne la heap en tableau
        /// </summary>
        public T[] Tableau
        {
            get
            {
                T[] tabtmp = new T[nombre];
                for (int i = 0; i < nombre; i++)
                {
                    tabtmp[i] = tableau[i];
                }
                return tabtmp;
            }
        }
    }//Fin class Heap


    /// <summary>
    /// Permet d'aller chercher les donnés dans l'arbre.
    /// </summary>
    /// <param name="cle">Cle du noeud à aller chercher.</param>
    /// <returns>Retourne le Data du noeud avec la clé précisé. Le data est de type : T.</returns>
    /// <typeparam name="T">Type que contiendra le noeud </typeparam>
    public class Noeud<T> where T : IComparable<T>
    {
        //Variables membres

        Noeud<T> enfantGauche = null;
        Noeud<T> enfantDroit = null;
        T data;


        //Constructeur

        /// <summary>
        /// Cree un noeud et lui assigne sa donee.
        /// </summary>
        /// <param name="data">Donnee qui lui sera assigne.</param>
        public Noeud(T data)
        {
            this.data = data;
        }

        //Proprietes


        public Noeud<T> EnfantGauche
        {
            get { return enfantGauche; }
            set { enfantGauche = value; }
        }

        public Noeud<T> EnfantDroit
        {
            get { return enfantDroit; }
            set { enfantDroit = value; }
        }

        public T Data
        {
            get { return data; }
        }
    }//Fin class Noeud
}


