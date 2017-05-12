using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNM_OOA_NumerosAleatorios
{
    public partial class Form_Main : Form
    {
        private int nextNumber;
        private NoRandomGenerator noGenerator = NoRandomGenerator.Instance;
        private SaveInDisc saveNo = SaveInDisc.Instance;
        private GenerateTxt txtGenerator;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_GenerateNumber_Click(object sender, EventArgs e)
        {
            nextNumber = noGenerator.numberGenerator();

            tb_ShowRandomNumber.Text = nextNumber.ToString();
        }

        private void btn_SaveInDisc_Click(object sender, EventArgs e)
        {
            saveNo.SaveNumber(nextNumber);
        }

        private void btn_GenerateTxt_Click(object sender, EventArgs e)
        {
            List<int> list = saveNo.getNoList();
            txtGenerator = new GenerateTxt(list);
            txtGenerator.printTxt();
        }
    }
}
