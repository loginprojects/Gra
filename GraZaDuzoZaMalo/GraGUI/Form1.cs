using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraLib;

namespace GraGUI
{
    public partial class Form1 : Form
    {

        private ModelGry gra;

        public Form1()
        {
            InitializeComponent();
            buttonLosuj.Enabled = false;
            groupBoxStatystyki.Visible = false;
        }

        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            groupBoxLosowanie.Visible = true;
            buttonNowaGra.Enabled = false;
            buttonPoddaj.Visible = true;
            groupBoxLosowanie.Enabled = true;
            textBoxOd.Clear();
            textBoxDo.Clear();

        }

        private void buttonPoddaj_Click(object sender, EventArgs e)
        {
            buttonPoddaj.Visible = false;
            buttonNowaGra.Enabled = true;
            groupBoxLosowanie.Visible = false;
            statystyki();
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            int x, y;
            try
            {
                x = int.Parse(textBoxOd.Text);
                y = int.Parse(textBoxDo.Text);
            }
            catch (FormatException)
            {
                textBoxOd.BackColor = Color.Red;
                return;
            }

            textBoxOd.BackColor = textBoxDo.BackColor = Color.White;



            groupBoxOdgadywanie.Visible = true;
            groupBoxLosowanie.Enabled = false;


            gra = new ModelGry(x, y);

        }

        private bool losujZablokowaneOd = true;
        private bool losujZablokowaneDo = true;

        private bool blokada() => losujZablokowaneDo || losujZablokowaneOd;



        private void textBoxDo_TextChanged(object sender, EventArgs e)
        {

            int wynik;
            if (int.TryParse(textBoxDo.Text, out wynik))
            {


                textBoxDo.BackColor = Color.GreenYellow;
                losujZablokowaneDo = false;
            }
            else
            {
                textBoxDo.BackColor = Color.LightPink;
                losujZablokowaneDo = true;
            }
            buttonLosuj.Enabled = !blokada();
        }

        private void textBoxOd_TextChanged(object sender, EventArgs e)
        {
            int wynik;
            if (int.TryParse(textBoxOd.Text, out wynik))
            {
                textBoxOd.BackColor = Color.GreenYellow;
                losujZablokowaneOd = false;
            }
            else
            {
                textBoxOd.BackColor = Color.LightPink;
                losujZablokowaneOd = true;
            }
            
            buttonLosuj.Enabled = !blokada();
        }

        private void statystyki()
        {
            groupBoxStatystyki.Visible = true;
            labelLiczbaRuchow.Text = $"Liczba ruchów = {gra.Historia.Count}";                   //lub po "" dajemy '+ gra.Historia.Count.ToString' - wymagana konwersja typów
            TimeSpan czas = gra.Historia[gra.Historia.Count - 1].Czas - gra.Historia[0].Czas;  //Historia to tabela, więc odnosimy się do pirwszej i osatniej komórki oraz do parametru czas
            labelCzasGry.Text = $"Czas gry: {czas}";                                            
        }

        private void buttonWyślij_Click(object sender, EventArgs e)
        {
            int propozycja = int.Parse(textBoxPropozycja.Text);
            var odpowiedz = gra.Ocena(propozycja);
            switch (odpowiedz)
            {
                case ModelGry.Odp.ZaMalo:
                    labelOcena.Text = "Za mało";
                    labelOcena.ForeColor = Color.Red;
                    break;
                case ModelGry.Odp.Trafione:
                    labelOcena.Text = "Trafione";
                    labelOcena.ForeColor = Color.Green;
                    buttonWyślij.Enabled = false;
                    buttonNowaGra.Enabled = true;
                    groupBoxStatystyki.Visible = true;
                    break;
                case ModelGry.Odp.ZaDuzo:
                    labelOcena.Text = "Za dużo";
                    labelOcena.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }

        }

        private void textBoxPropozycja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
