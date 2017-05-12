using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNM_OOA_NumerosAleatorios
{
    public class NoRandomGenerator
    {
        private static NoRandomGenerator instance = new NoRandomGenerator();
        Random randomObj = new Random();
        public int number;

        private NoRandomGenerator()
        {

        }

        public static NoRandomGenerator Instance
        {
            get
            {
                return instance;
            }
        }

        public int numberGenerator ()
        {
            number = randomObj.Next();
            return number;
        }

    }
}
