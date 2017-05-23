using System.Drawing;
using System.Windows.Forms;

namespace Bramki_logiczne_Arduino___app
{
    class Wyjscie
    {
        /// <summary>
        /// zmienne
        /// </summary>
        public Label wartosc_wyswietana;
        public Button nr_wyswietlany;
        public bool aktywny = true;
        public bool wartosc; // true - 1, false - 0

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="w"></param>
        /// <param name="n"></param>
        public Wyjscie(Label w,  Button n)
        {
            wartosc_wyswietana = w;
            nr_wyswietlany = n;
            wartosc = false;
        }

        /// <summary>
        /// ustawia wartość na taką jakie jest pole wartość
        /// </summary>
        public void ustaw()
        {
            if (aktywny)
            {
                if (wartosc)
                {
                    wartosc_wyswietana.Text = "true";
                    wartosc_wyswietana.ForeColor = Color.Green;
                }
                else
                {
                    wartosc_wyswietana.Text = "false";
                    wartosc_wyswietana.ForeColor = Color.DeepSkyBlue;
                }
            }
        }

        /// <summary>
        /// blokuje wyjście (jak rozłączono z urządzeniem)
        /// </summary>
        public void blokuj()
        {
            nr_wyswietlany.ForeColor = Color.Gray;
            wartosc_wyswietana.Text = "Nieaktywny";
            wartosc_wyswietana.ForeColor = Color.Gray;
            aktywny = false;
            wartosc_wyswietana.Hide();
        }

        /// <summary>
        /// odblokowywuje urządzenie (jak połączono z urządzeniem)
        /// </summary>
        public void odblokuj()
        {
            aktywny = true;
            zmien_aktywnosc();
        }

        /// <summary>
        /// zmienia aktywność wyjścia (aktywny/nieaktywny)
        /// </summary>
        public void zmien_aktywnosc()
        {
            if (aktywny)
            {
                wartosc_wyswietana.Hide();
                nr_wyswietlany.ForeColor = Color.Gray;
                aktywny = false;
            }
            else
            {
                wartosc_wyswietana.Show();
                nr_wyswietlany.ForeColor = Color.Black;
                aktywny = true;
            }
        }
    }
}