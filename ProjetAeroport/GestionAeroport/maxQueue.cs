using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    public class MaxQueue<T>:Queue<T>
    {
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

        public int MaxLenght { get; set; }
    }
}
