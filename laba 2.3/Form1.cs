using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace laba_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Mentol(double chto)
        {
            if (comboBoxZapyat.SelectedItem == null)
            {
                int stri = 0;
                int y = Convert.ToInt32(stri);
                double min = Math.Round(chto, y);
                return min;
            }
            else
            {
                string selectedState = comboBoxZapyat.SelectedItem.ToString();
                int y = Convert.ToInt32(selectedState);
                double min = Math.Round(chto, y);
                return min;
            }
        }


 

        private void TextReaumur_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47||e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39||e.KeyChar >= 46) && number != 47 && number != 61) 
                {
                e.Handled = true;
            }
        }

        private void TextCelsius_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47||e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39||e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void TextKelvin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47  ||e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39||e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void TextFahrenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47||e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39||e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void TextCelsius_Leave(object sender, EventArgs e)
        {
            String s, s1;
            s = TextCelsius.Text;

            if (!string.IsNullOrEmpty(TextCelsius.Text))
            {
                s1 = s.Substring(TextCelsius.Text.Length - 1, 1);

                if (s1 == ",")
                {

                }
                if (s1 == "-")
                {

                }

                else if ((s1 == "0") | (s1 == "1") | (s1 == "2") | (s1 == "3") | (s1 == "4") | (s1 == "5") | (s1 == "6") | (s1 == "7") | (s1 == "8") | (s1 == "9"))
                {


                    new Thread(() =>
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {



                            double nutre = Convert.ToDouble(TextCelsius.Text);
                            TextCelsius.Text = nutre.ToString();

                            double kelvin = nutre - 273.15;
                            double kusok = Mentol(kelvin);
                            TextKelvin.Text = kusok.ToString();

                            double farengeyt = (nutre * 9 / 5) + 32;
                            double chel = Mentol(farengeyt);
                            TextFahrenheit.Text = chel.ToString();

                            double rumka = nutre * 8 / 10;
                            double nine = Mentol(rumka);
                            TextReaumur.Text = nine.ToString();

                        }));


                    }).Start();
                }
            }
        }

        private void TextFahrenheit_Leave(object sender, EventArgs e)
        {

            String s, s1;
            s = TextFahrenheit.Text;

            if (!string.IsNullOrEmpty(TextFahrenheit.Text))
            {
                s1 = s.Substring(TextFahrenheit.Text.Length - 1, 1);

                if (s1 == ",")
                {

                }
                if (s1 == "-")
                {

                }

                else if ((s1 == "0") | (s1 == "1") | (s1 == "2") | (s1 == "3") | (s1 == "4") | (s1 == "5") | (s1 == "6") | (s1 == "7") | (s1 == "8") | (s1 == "9"))
                {
                    new Thread(() =>
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {
                            var might = Convert.ToDouble(TextFahrenheit.Text);
                            TextFahrenheit.Text = might.ToString();

                            double celsius = (might - 32) * 5 / 9;
                            double nemo = Mentol(celsius);
                            TextCelsius.Text = nemo.ToString();

                            double kelvin = (might - 32) * 5 / 9 + 273.15;
                            double kapitan = Mentol(kelvin);
                            TextKelvin.Text = kapitan.ToString();

                            double rumka = (might - 32) * 4 / 9;
                            double miron = Mentol(rumka);
                            TextReaumur.Text = miron.ToString();

                        }));


                    }).Start();
                }
            }
        }

        private void TextKelvin_Leave(object sender, EventArgs e)
        {


            String s, s1;
            s = TextKelvin.Text;

            if (!string.IsNullOrEmpty(TextKelvin.Text))
            {
                s1 = s.Substring(TextKelvin.Text.Length - 1, 1);

                if (s1 == ",")
                {

                }
                if (s1 == "-")
                {

                }

                else if ((s1 == "0") | (s1 == "1") | (s1 == "2") | (s1 == "3") | (s1 == "4") | (s1 == "5") | (s1 == "6") | (s1 == "7") | (s1 == "8") | (s1 == "9"))
                {
                    new Thread(() =>
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {


                            var night = Convert.ToDouble(TextKelvin.Text);
                            TextKelvin.Text = night.ToString();

                            double celsius = night + 273.15;
                            double kazaxi = Mentol(celsius);
                            TextCelsius.Text = kazaxi.ToString();

                            double farengeyt = (night - 273.15) * 9 / 5 + 32;
                            double nositeli = Mentol(farengeyt);
                            TextFahrenheit.Text = nositeli.ToString();

                            double rumka = (night - 273.15) * 0.8;
                            double koron = Mentol(rumka);
                            TextReaumur.Text = koron.ToString();

                        }));


                    }).Start();
                }
            }
        }

        private void TextReaumur_Leave(object sender, EventArgs e)
        {
            String s, s1;
            s = TextReaumur.Text;

            if (!string.IsNullOrEmpty(TextReaumur.Text))
            {
                s1 = s.Substring(TextReaumur.Text.Length - 1, 1);

                if (s1 == ",")
                {

                }
                if (s1 == "-")
                {

                }

                else if ((s1 == "0") | (s1 == "1") | (s1 == "2") | (s1 == "3") | (s1 == "4") | (s1 == "5") | (s1 == "6") | (s1 == "7") | (s1 == "8") | (s1 == "9"))
                {
                    new Thread(() =>
                    {
                        BeginInvoke((MethodInvoker)(() =>
                        {
                            var bight = Convert.ToDouble(TextReaumur.Text);
                            TextReaumur.Text = bight.ToString();

                            double celsius = bight * 5 / 4;
                            double tite = Mentol(celsius);
                            TextCelsius.Text = tite.ToString();

                            double kelvin = (bight * (5 / 4)) + 273.15;
                            double meme = Mentol(kelvin);
                            TextKelvin.Text = meme.ToString();

                            double farengeyt = (bight * (9 / 4) + 32);
                            double nene = Mentol(farengeyt);
                            TextFahrenheit.Text = nene.ToString();

                        }));


                    }).Start();


                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
    


