using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    public class MaxQueue<T>:Queue<T>
    {
        private int maxLenght = 0;
        public MaxQueue(int maximum)
        {
            MaxLenght = maximum;
        }

        new public bool Enqueue(T data)
        {
            if (Count > MaxLenght)
                return false;
            base.Enqueue(data);
            return true;
        }

        public int MaxLenght
        {
            get { return MaxLenght; }
            set
            {
                if (value >= Count)
                {
                    maxLenght = value;
                    return;
                }
                throw new Exception("Vous devez indiquer un nombre inférieur ou égale à la grandeur actuelle de la MaxQueue!");
            }
        }
    }
}
