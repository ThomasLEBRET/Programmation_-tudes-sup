using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace voyage_class_test
{
    class Passager
    {
        private int numero;
        private int classe;

        public Passager(int unNumero, int uneClasse)
        {
            numero = unNumero;
            classe = uneClasse;
        }

        public int GetNumero()
        {
            return numero;
        }

        public int GetClasse()
        {
            return classe;
        }
    }
}
