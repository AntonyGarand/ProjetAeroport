// Hangar.cs 
// Description du programme : Unité de stoquage d'objets avec taille maximale
// Programmé par Antony Garand ~ Tous drois réservé ~
// Le : 28 novembre 2014        
using System;

namespace GestionAeroport
{
    public class Hangar<T> where T : class
    {
        private readonly int _grandeur;
        private int _count;
        public T[] Stoquage;
        /// <summary>
        /// Créer un nouveau hangar vide
        /// </summary>
        /// <param name="capaciteMaximale">Grandeur maximale du hangar</param>
        public Hangar(int capaciteMaximale)
        {
            _count = 0;
            _grandeur = capaciteMaximale;
            Stoquage = new T[_grandeur];
        }
        /// <summary>
        /// Range un objet dans le hangar
        /// </summary>
        /// <param name="objet"></param>
        public void Ranger(T objet)
        {
            for(int i = 0; i < _grandeur; i++)
            {
                //Si la place du hangar est vide
                if (Stoquage[i] == default(T))
                {
                    Stoquage[i] = objet;
                    _count++;
                    return;
                }
            }
            throw new HangarPleinException("Le hangar à une capacité maximale de " + _grandeur + "! Il est plein.");
        }
        /// <summary>
        /// Retire un objet du hangar
        /// </summary>
        /// <returns>Objet rangé dans le hangar</returns>
        public T Retirer()
        {
            for (int i = 0; i < _grandeur; i++)
            {
                //Si la place du hangar n'est pas vide
                if (Stoquage[i] != default(T))
                {
                    T retour = Stoquage[i];
                    Stoquage[i] = default(T);
                    _count--;
                    return retour;
                }
            }
            throw new HangarVideException("Le hangar est vide! Il est impossible de retirer un objet");
        }

        /// <summary>
        /// Permet d'accéder au nombre d'avions dans le hangar
        /// </summary>
        public int Count
        {
            get { return _count; }
        }
    }
    /// <summary>
    /// Exception causée par l'essai d'ajouter un objet dans un hangar plein
    /// </summary>
    public class HangarPleinException : Exception
    {
        public HangarPleinException(string message) : base(message)
        {
        }
    }
    /// <summary>
    /// Exception causée par l'essai de retirer un objet dans un hangar vide
    /// </summary>
    public class HangarVideException : Exception
    {
        public HangarVideException(string message) : base(message)
        {
        }
    }
}
