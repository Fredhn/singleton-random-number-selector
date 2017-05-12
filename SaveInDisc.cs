using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNM_OOA_NumerosAleatorios
{
    public class SaveInDisc
    {
        private static SaveInDisc instance = new SaveInDisc();
        public List<int> numbers = new List<int>();

        private SaveInDisc()
        {

        }

        public static SaveInDisc Instance
        {
            get
            {
                return instance;
            }
        }

        public void SaveNumber (int no)
        {
            numbers.Add(no);
        }

        public List<int> getNoList ()
        {
            return this.numbers;
        }

    }
}
