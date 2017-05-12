using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNM_OOA_NumerosAleatorios
{
    class GenerateTxt
    {
        private static GenerateTxt instance = new GenerateTxt();
        private List<int> noList = new List<int>();
        private String path = "C:\\Users\\FRED\\Desktop\\numeros_aleatorios.txt";

        public GenerateTxt()
        {

        }

        public GenerateTxt(List<int> noList)
        {
            this.noList = noList;
        }

        public void printTxt ()
        {
            StreamWriter tw = new StreamWriter(path);
            noList.ForEach(tw.WriteLine);
            tw.Close();
        }
    }
}
