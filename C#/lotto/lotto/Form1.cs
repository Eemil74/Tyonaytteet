using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArvoJaTulostaNumerot();
        }

        private void ArvoJaTulostaNumerot()
        {
            int[] lottonumerot = ArvoLottonumerot();
            
            txt_lotto.Clear();

            // Lisää numerot messageboxiin
            foreach (var numero in lottonumerot)
            {
                txt_lotto.AppendText($"{numero} {Environment.NewLine}");
            }
        }

        private int[] ArvoLottonumerot()
        {
            Random random = new Random();
            int[] numerot = new int[7];

            for (int i = 0; i < 7; i++)
            {
                int arvottuNumero;
                do
                {
                    arvottuNumero = random.Next(1, 41);
                } while (numerot[i] == arvottuNumero);
                numerot[i] = arvottuNumero;
            }

            Array.Sort(numerot);

            return numerot;
        }
    }
}