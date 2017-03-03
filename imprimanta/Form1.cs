using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imprimanta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrintText_Click(object sender, EventArgs e)
        {

            //string sa = "string to print";
            //string s = textBoxNumeCompanie.Text;
            int suma = 0;
            Int32.TryParse(textBoxSuma.Text, out suma);

            StringBuilder stB = new StringBuilder();
            stB.Append ("<b>+SC BISTRI-VET SRL+</b> \nStr.Libertatii Nr.13, Bistrita - Nasaud\nCIF RO24321865, J06/ 837 / 2008\nCHITANTA\n");
            stB.AppendLine("Seria: " + textBoxSeria.Text + "\nNumarul: " + textBoxNr.Text+" / "+DateTime.Now.ToString("dd/MM/yyyy") + "\n\nAm primit de la\n" + textBoxNumeCompanie.Text + "\nCUI: " + textBoxCUI.Text + "\nAdresa: " + textBoxAdresa.Text + "\n");
            stB.AppendLine("Suma de :" + textBoxSuma.Text + "\nAdica: " + NumberToWords(suma) + " RON\nReprezentand cval Fact. Nr.:\n");
            stB.AppendLine("Emis la data: " + DateTime.Now.ToString() + "\n" + "de catre: " + textBoxNumeAgent.Text + "\n");
            stB.AppendLine("Tiparit pe hartie termosensibila.\nA se proteja de caldura si de lumina\ndirecta a soarelui.\n\nwww.bistrivet.ro\n\nCasier, ");

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {   
                Image imgLogo = Image.FromFile("d://Logo bistrivet2.jpg");
                e1.Graphics.DrawImage(imgLogo, 0, 0);
                RectangleF rectangle=  new RectangleF(0, imgLogo.Height, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height);

                //adaugam textul
                e1.Graphics.DrawString(stB.ToString(), new Font("Times New Roman", 6), new SolidBrush(Color.Black), rectangle);

                //adugam stampiluta               
                Image imgStampiluta = Image.FromFile("d://STAMPILUTA.jpg");
                e1.Graphics.DrawImage(imgStampiluta, 160, 550);
            };



            //deschdem fereastra de dialog pentru imprimare
            PrintDialog pdi = new PrintDialog();
            pdi.Document = p;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                p.Print();
            }
            else
            {
                MessageBox.Show("Print Cancelled");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            string words = "";       

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " mii ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " suta ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "si ";

                var unitsMap = new[] { "zero", "o", "doua", "trei", "patru", "cinci", "sase", "sapte", "opt", "noua", "10", "unsprezece", "doisprezece", "treisprezece", "paisrezece", "cinsprezece", "saisprezece", "saptesprezece", "optsprezece", "nouasprezece" };
                var tensMap = new[] { "zero", "zece", "douazeci", "treizeci", "patruzeci", "cinzeci", "saizeci", "saptezeci", "optezci", "nouazeci" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "si" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
