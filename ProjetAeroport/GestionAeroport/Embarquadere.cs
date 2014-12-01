using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    class Embarquadere
    {
        private bool libre;
        private bool termine;
        private ObjVolants avion;
        private int tempsActuel;
        private int _tempsRequis;
        public void Embarquer(int tempsRequis)
        {
            tempsActuel = 0;
            _tempsRequis = tempsRequis;
            libre = false;
            termine = false;
            avion.EssenceActuel = avion.MaxEssence;
        }

        public void Update()
        {
            if (libre)
                return;
            if (++tempsActuel >= _tempsRequis)
                termine = true;
            else
            {
                //TODO
                throw new NotImplementedException();
            }
        }

        public ObjVolants Debarquer()
        {
            tempsActuel = 0;
            _tempsRequis = 0;
            libre = false;
            termine = false;
            return avion;
        }
        /*
        -Bool libre
        -Bool termine
        -ObjVolants Avion
        -Methode Embarquer->On fuel
        -Methode Debarquer
         */
    }
}
