using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza_kassa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            aloitus();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //nollaa kaiken
            aloitus();
        }
        private void aloitus()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // laske nappi
            try
            {
                lasku2();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private double lasku1()
        {
            int tx1, tx2, tx3, tx4, tx5, tx6, tx7, tx8, tx9, tx10, tx11, tx12;
            tx1 = 0; tx2 = 0; tx3 = 0; tx4 = 0; tx5 = 0; tx6 = 0; tx7 = 0; tx8 = 0; tx9 = 0; tx10 = 0;
            if (string.IsNullOrEmpty(txt1.Text))
            {
                txt1.Text = "0";
            }
            tx1 = int.Parse(txt1.Text);
            if (string.IsNullOrEmpty(txt2.Text))
            {
                txt2.Text = "0";
            }
            tx2 = int.Parse(txt2.Text);
            if (string.IsNullOrEmpty(txt3.Text))
            {
                txt3.Text = "0";
            }
            tx3 = int.Parse(txt3.Text);
            if (string.IsNullOrEmpty(txt4.Text))
            {
                txt4.Text = "0";
            }
            tx4 = int.Parse(txt4.Text);
            if (string.IsNullOrEmpty(txt5.Text))
            {
                txt5.Text = "0";
            }
            tx5 = int.Parse(txt5.Text);
            if (string.IsNullOrEmpty(txt6.Text))
            {
                txt6.Text = "0";
            }
            tx6 = int.Parse(txt6.Text);
            if (string.IsNullOrEmpty(txt7.Text))
            {
                txt7.Text = "0";
            }
            tx7 = int.Parse(txt7.Text);
            if (string.IsNullOrEmpty(txt8.Text))
            {
                txt8.Text = "0";
            }
            tx8 = int.Parse(txt8.Text);
            if (string.IsNullOrEmpty(txt9.Text))
            {
                txt9.Text = "0";
            }
            tx9 = int.Parse(txt9.Text);
            if (string.IsNullOrEmpty(txt10.Text))
            {
                txt10.Text = "0";
            }
            tx10 = int.Parse(txt10.Text);
            if (string.IsNullOrEmpty(txt11.Text))
            {
                txt11.Text = "0";
            }
            tx11 = int.Parse(txt11.Text);
            if (string.IsNullOrEmpty(txt12.Text))
            {
                txt12.Text = "0";
            }
            tx12 = int.Parse(txt12.Text);

            /*pitsojen hinta*/
            double Margherita = 10;
            double Pepperoni = 12;
            double Hawaiana = 13;
            double Stagioni = 14;
            double Capricciosa = 15;
            double Diavola = 14;
            double Formaggi = 16;
            double Prosciutto = 14;
            double Vegetariana = 13;
            double Marinara = 11;
            double limupieni = 1;
            double limuiso = 3;
            /*määrittelee montako tilausta on*/
            int kaikki = tx1 + tx2 + tx3 + tx4 + tx5 + tx6 + tx7 + tx8 + tx9 + tx10;
            double tilaus = 0;
            //laskee pitsojen hinnan
            if (kaikki < 10 )
            {
                if (checkBox1.Checked)
                {
                  tilaus += tx1 * Margherita;
          
                }
                if (checkBox2.Checked)
                {
                    tilaus += (tx2 * Pepperoni);
                }
                if (checkBox3.Checked)
                {
                    tilaus += tx3 * Hawaiana;
                }
                if (checkBox4.Checked)
                {
                    tilaus += tx4 * Stagioni;
                }
                if (checkBox5.Checked)
                {
                    tilaus += tx5 * Capricciosa;

                }
                if (checkBox6.Checked)
                {
                    tilaus += tx6 * Diavola;
                }
                if (checkBox7.Checked)
                {
                    tilaus += tx7 * Formaggi;
                }
                if (checkBox8.Checked)
                {
                    tilaus += tx8 * Prosciutto;
                }
                if (checkBox9.Checked)
                {
                    tilaus += tx9 * Vegetariana;
                }
                if (checkBox10.Checked)
                {
                    tilaus += tx10 * Marinara;
                }
                if (checkBox11.Checked)
                {
                    tilaus += tx11 * limupieni;
                }
                if (checkBox12.Checked)
                {
                    tilaus += tx12 * limuiso;
                }
            }
            else
            {
                MessageBox.Show("Liian monta tilausta. max 10 pitsaa");
            }
            return tilaus;
        }
        //laskee pitsojen hinnan uudelleen lisämausteiden kera
        private void lasku2()
        {
            double hinta = lasku1();
            double tilaus1 = 0;
            double tilaus = 0;
            int tx1, tx2, tx3, tx4, tx5, tx6, tx7, tx8, tx9, tx10;
            tx1 = 0; tx2 = 0; tx3 = 0; tx4 = 0; tx5 = 0; tx6 = 0; tx7 = 0; tx8 = 0; tx9 = 0; tx10 = 0;
           
            tx1 = int.Parse(txt1.Text);
            
            tx2 = int.Parse(txt2.Text);
           
            tx3 = int.Parse(txt3.Text);
            
            tx4 = int.Parse(txt4.Text);
            
            tx5 = int.Parse(txt5.Text);
            
            tx6 = int.Parse(txt6.Text);
            
            tx7 = int.Parse(txt7.Text);
           
            tx8 = int.Parse(txt8.Text);
            
            tx9 = int.Parse(txt9.Text);
            
            tx10 = int.Parse(txt10.Text);
            int kaikki = tx1 + tx2 + tx3 + tx4 + tx5 + tx6 + tx7 + tx8 + tx9 + tx10;

            if (kaikki < 10)
            {
                if (Lisä1.Checked && tx1 > 0 && checkBox1.Checked)
                {
                    tilaus += 0.50;
                }
                if (lisä2.Checked && tx2 > 0 && checkBox2.Checked)
                {
                    tilaus += 0.50;
                }
                if (Lisä3.Checked && tx3 > 0 && checkBox3.Checked)
                {
                    tilaus += 0.50;
                }
                if (Lisä4.Checked && tx4 > 0 && checkBox4.Checked)
                {
                    tilaus += 0.50;
                }
                if (Lisä5.Checked && tx5 > 0 && checkBox5.Checked)
                {
                    tilaus += 0.50;
                }
                if (lisä6.Checked && tx6 > 0 && checkBox6.Checked)
                {
                    tilaus += 0.50;
                }
                if (Lisä7.Checked && tx7 > 0 && checkBox7.Checked)
                {
                    tilaus += 0.50;
                }
                if (lisä8.Checked && tx8 > 0 && checkBox8.Checked)
                {
                    tilaus += 0.50;
                }
                if (lisä9.Checked && tx9 > 0 && checkBox9.Checked)
                {
                    tilaus += 0.50;
                }
                if (lisä10.Checked && tx10 > 0 && checkBox10.Checked)
                {
                    tilaus += 0.50;
                }
            }
            else
            {
                tilaus1 = hinta;
            }
            tilaus1 = hinta + tilaus;
            Math.Round(tilaus1, 2);
            MessageBox.Show($"Tilauksesi hinta on {tilaus1}€");

        }

        
    }
}

