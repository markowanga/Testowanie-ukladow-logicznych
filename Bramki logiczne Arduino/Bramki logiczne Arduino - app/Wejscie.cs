using System.Drawing;
using System.Windows.Forms;

namespace Bramki_logiczne_Arduino___app
{
    class Wejscie
    {
        /// <summary>
        /// zmienne
        /// </summary>
        FormApp sender;
        public bool value; // true - on, false - off
        public Label labelNumber; // napis naszego wejścia
        public Button buttonActive; // przycisk aktywności naszego wejścia
        public Button buttonOnOff; // przycisk wartości naszego wejścia
        public bool czyAktywny; // informacja o tym czy dana wartość jest aktywna

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="label"></param>
        /// <param name="avtiveButton"></param>
        /// <param name="changeValue"></param>
        public Wejscie(Label label, Button avtiveButton, Button changeValue, FormApp senderForm)
        {
            labelNumber = label;
            buttonActive = avtiveButton;
            buttonOnOff = changeValue;
            value = false;
            sender = senderForm;
            czyAktywny = false;
        }

        /// <summary>
        /// zamienia stan na wejściu na przeciwny
        /// </summary>
        public void zmien_on_off()
        {
            if (sender.polaczono && buttonActive.Text == "Aktywny")
            {
                if (buttonOnOff.Text == "OFF")
                {
                    buttonOnOff.Text = "ON";
                    buttonOnOff.ForeColor = Color.Green;
                    value = true;
                }
                else
                {
                    buttonOnOff.Text = "OFF";
                    buttonOnOff.ForeColor = Color.Red;
                    value = false;
                }
            }
        }

        /// <summary>
        /// zmienia aktywność na przeciwną
        /// </summary>
        public void zmien_aktywnosc()
        {
            if (sender.polaczono)
            {
                if (buttonActive.Text == "Blokada")
                {
                    czyAktywny = true;
                    buttonActive.Text = "Aktywny";
                    buttonActive.ForeColor = Color.Green;
                    buttonOnOff.Text = "OFF";
                    buttonOnOff.ForeColor = Color.Red;
                    buttonOnOff.Show();
                }
                else
                {
                    czyAktywny = false;
                    buttonActive.Text = "Blokada";
                    buttonActive.ForeColor = Color.DeepSkyBlue;
                    buttonOnOff.ForeColor = Color.Gray;
                    value = false;
                    buttonOnOff.Text = "OFF";
                    buttonOnOff.Hide();
                }
            }
        }

        /// <summary>
        /// blokuje wejście
        /// wykonywane jak rozłączono z urządzeniem
        /// </summary>
        public void blokuj()
        {
            value = false;
            labelNumber.ForeColor = Color.Gray;
            buttonActive.Text = "Blokada";
            buttonActive.ForeColor = Color.Gray;
            buttonOnOff.Hide();
        }

        /// <summary>
        /// odblokowywuje wejście
        /// jak połączono z urządzeniem
        /// </summary>
        public void odblokuj()
        {
            value = false;
            labelNumber.ForeColor = Color.Black;
            buttonActive.ForeColor = Color.DeepSkyBlue;
        }
    }
}