using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Drawing;

namespace Bramki_logiczne_Arduino___app
{
    public partial class FormApp : Form
    {
        /// <summary>
        /// zmienne
        /// </summary>
        int wart_wejscia = 0; // pomocne przy doczycie pakietu, oznacza stany sygnałów odebranych przez arduino, jak jest takie samo to nie ma sensu liczyć bo nic się nie zmieni 
        long licznik_czasu = 0; // liczy ms od uruchomienia - jak jest %100==0 to wysyła pakiet z danymi wejsciowymi 
        Wejscie[] wej = new Wejscie[8]; // obiekty reprezentujące wejście do naszego układu
        Wyjscie[] wyj = new Wyjscie[6]; // obiekty reprezentujące wyjście od naszego układu
        public bool polaczono = false; // zmienna statyczne oszaczająca czy połączono z naszym arduino
        string odczyt_pak = ""; // zmienna wykorzystywana przy łączeniu z arduino

        /// <summary>
        /// konstruktor - inicjalizacja programu
        /// </summary>
        public FormApp()
        {
            // utworzenie okna
            InitializeComponent();

            // ustawienie parametrów serialPort 
            serialPort.BaudRate = 9600;
            serialPort.DtrEnable = true;

            // tworzenie obiektów wejścia
            wej[0] = new Wejscie(nr_zadajnika1, aktywnosc_wej1, zadajnik1, this);
            wej[1] = new Wejscie(nr_zadajnika2, aktywnosc_wej2, zadajnik2, this);
            wej[2] = new Wejscie(nr_zadajnika3, aktywnosc_wej3, zadajnik3, this);
            wej[3] = new Wejscie(nr_zadajnika4, aktywnosc_wej4, zadajnik4, this);
            wej[4] = new Wejscie(nr_zadajnika5, aktywnosc_wej5, zadajnik5, this);
            wej[5] = new Wejscie(nr_zadajnika6, aktywnosc_wej6, zadajnik6, this);
            wej[6] = new Wejscie(nr_zadajnika7, aktywnosc_wej7, zadajnik7, this);
            wej[7] = new Wejscie(nr_zadajnika8, aktywnosc_wej8, zadajnik8, this);

            // tworzenie obiektów wyjścia
            wyj[0] = new Wyjscie(odcz1, nr_wyj1);
            wyj[1] = new Wyjscie(odcz2, nr_wyj2);
            wyj[2] = new Wyjscie(odcz3, nr_wyj3);
            wyj[3] = new Wyjscie(odcz4, nr_wyj4);
            wyj[4] = new Wyjscie(odcz5, nr_wyj5);
            wyj[5] = new Wyjscie(odcz6, nr_wyj6);

            // blokuje wejscia do momentu jak się nie połączy z Arduino
            foreach (Wejscie ww in wej)
                ww.blokuj();

            // blokuje wyjscia do momentu jak się nie połączy z Arduino
            foreach (Wyjscie ww in wyj)
                ww.blokuj();
        }

        /// <summary>
        /// funkcja wykonywana w momencie odebrania danych przez serialPort
        /// odbierane są albo dane do utworzenia połączenia, albo układ wyjść z naszego układu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try // wychwytujemy wyjątek - jeśli stałoby się coś z naszym urządzeniem, rozłączamy je
            {
                // jak połączono to odbiera dane odczytu
                if (polaczono)
                {
                    byte[] b = new byte[1];
                    serialPort.Read(b, 0, 1);
                    analiza_odczytu(b[0]);
                }
                // odczytuje stringi do identyfikacji urządzenia
                else
                    odczyt_pak = serialPort.ReadLine();
            } catch (Exception) { rozlaczenie(); }
        }

        /// <summary>
        /// funkcja zamieniająca byte odczytany przez serialPort
        /// na ustawienia konkretnych kontrolek (napisów czy true czy false odczytanych danych)
        /// </summary>
        /// <param name="b"></param>
        private void analiza_odczytu(int b)
        {
            // funkcja odczytu która zamienia liczbę podaną na wejściu
            // na dane
            if (wart_wejscia != b)
            {
                wart_wejscia = b;
                int mnoznik = 32;
                for (int a=5; a>=0; a--)
                {
                    if (mnoznik<=b)
                    {
                        b -= mnoznik;
                        wyj[a].wartosc = true;
                    }
                    else
                        wyj[a].wartosc = false;
                    mnoznik /= 2;
                }
            }
            // ustawienie wyjść odbywa się synchronicznie co 1ms przez nasz timer
        }

        /// <summary>
        /// funkcja ustawiająca wyjścia z układu
        /// </summary>
        private void ustaw_wyjscia()
        {
            for (int a = 0; a < 6; a++)
                wyj[a].ustaw();
        }

        /// <summary>
        /// funkcja wysyłająca wejścia do arduino (wejścia układu)
        /// </summary>
        public void wyslij_wejscia()
        {
            byte []l = new byte[2];
            l[0] = 0;
            l[1] = 0;
            for (byte a = 0, m = 1; a < 8; a++, m *= 2)
                if (wej[a].value)
                    l[1] += m;
            serialPort.Write(l, 0, 2);
        }

        public void wyslij_jakie_wyjscia_do_odczytania()
        {
            byte[] l = new byte[2];
            l[0] = 1;
            l[1] = 0;
            for (byte a = 0, m = 1; a < 6; a++, m *= 2)
                if (wyj[a].aktywny)
                    l[1] += m;
            serialPort.Write(l, 0, 2);
        }

        /// <summary>
        /// ustawienie kontrolki stanu połączenia na połączono
        /// </summary>
        private void ustaw_POLOCZONO()
        {
            stan_polaczenia.Text = serialPort.PortName + " połączono ✔";
            stan_polaczenia.ForeColor = Color.Green;
        }

        /// <summary>
        /// ustawienie kontrolki stanu połączenia na nie połączono
        /// </summary>
        private void ustaw_NIE_POLOCZONO()
        {
            stan_polaczenia.Text = "nie połączono";
            stan_polaczenia.ForeColor = Color.Red;
        }

        /// <summary>
        /// ustawienie kontrolki stanu połączenia na utracono połączenie
        /// </summary>
        private void ustaw_ROZLACZONO()
        {
            stan_polaczenia.Text = "utracono połączenie";
            stan_polaczenia.ForeColor = Color.Red;
        }

        /// <summary>
        /// funkcja próbująca utworzyć połączenie z arduino
        /// - wywoływana poprzez wciśnięcie przycisku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void przycisk_polaczenia_Click(object sender, EventArgs e)
        {
            // zablokowanie przycisku, dzięki temu nie nawiążemy 2 prób połączenia jednocześnie
            przycisk_polaczenia.Enabled = false;

            // zmienne wykorzystywane do łączenia
            int liczba_portow = 0;
            bool czy_dobry_port = false;
            odczyt_pak = "";
            
            // pobranie nazw portów
            string[] porty = SerialPort.GetPortNames();

            // odczytanie liczby portów
            liczba_portow = porty.Length;

            // sprawdzanie każdego portu - jak jakiś dobry przerywamy funkcję łączenia
            // i kończymy pętlę
            for (int a = 0; a < liczba_portow; a++)
            {
                // zamknięcie portu jak otwarty
                if (serialPort.IsOpen)
                    serialPort.Close();

                // nowa nazwa portu i oznaczenie go pocz. że dobry
                serialPort.PortName = porty[a];
                bool czy_mozliwy_port = true;
                czy_dobry_port = false;

                // sprawdzenie czy można połączyć się z portem
                try { serialPort.Open(); }
                catch (Exception) // jeśli nie można (port zajęty)
                { czy_mozliwy_port = false; MessageBox.Show("zajety port"); }
                    // tego MessageBox-a nie musi być

                if (czy_mozliwy_port == true)
                {
                    // teraz jak port połączony to sprawdzenie czy to ten port
                    try
                    {
                        serialPort.WriteLine("markowanga");
                    }
                    catch (Exception) { MessageBox.Show("Err"); }
                    // odczytanie danych tu czekamy i robimy event jak odebrane dane na serialu
                    Thread.Sleep(2000);
                    //MessageBox.Show(odczyt_pak);
                    if (odczyt_pak == "Haslo poprawne" + (char)13)
                    {
                        czy_dobry_port = true;
                        polaczono = true;
                        wyslij_wejscia();
                    }
                }

                if (czy_dobry_port == true)
                    break;
                else serialPort.Close();
            }

            if (czy_dobry_port == true)
            {
                ustaw_POLOCZONO();

                foreach (Wejscie ww in wej)
                    ww.odblokuj();

                foreach (Wyjscie ww in wyj)
                    ww.odblokuj();
            }
            else // jak nie połączono z niczym
            {
                serialPort.Close();
                przycisk_polaczenia.Enabled = true;
                MessageBox.Show("Nie wykryto urządzenia\n\nSprawdź czy jest ono podłączone", "Komunikat");
                ustaw_NIE_POLOCZONO();
            }
        }

        /// <summary>
        /// funkcja rołączająca z arduino
        /// wywołana jeśli port był połączony a nie jest otwarty
        /// sprawdzane co 1ms
        /// </summary>
        private void rozlaczenie()
        {
            przycisk_polaczenia.Enabled = true;
            polaczono = false;
            ustaw_ROZLACZONO();

            // blokuje wejscia do momentu jak się nie połączy z Arduino
            foreach (Wejscie ww in wej)
                ww.blokuj();

            // blokuje wyjscia do momentu jak się nie połączy z Arduino
            foreach (Wyjscie ww in wyj)
                ww.blokuj();
        }

        /// <summary>
        /// reakcja na przełączenie jednego przycisku odpowiadającaego za wartość na wejściu do układu
        /// </summary>
        /// <param name="sender"></param>
        private void obsluz_on_off_zadajnika(Object sender)
        {
            int i;
            for (i = 0; (Button)sender != wej[i].buttonOnOff; i++) ; // szukanie obiektu reprezentującego dany przycisk
            wej[i].zmien_on_off();
            wyslij_wejscia();
        }

        /// <summary>
        /// funkcja zmieniająca aktywność danego zadajnika, dzięki niej dezaktywujemy dane wejście do układu
        /// </summary>
        /// <param name="sender"></param>
        private void ustaw_aktywnosc_zadajnika(Object sender)
        {
            if (polaczono)
            {
                int i;
                for (i = 0; (Button)sender != wej[i].buttonActive; i++) ; // szukanie obiektu reprezentującego dany przycisk
                wej[i].zmien_aktywnosc();
                wyslij_jakie_wyjscia_do_odczytania();
                wyslij_wejscia();
            }
        }

        /// <summary>
        /// wykonanie funkcji co 1 ms (tak mamy ustawiony timer)
        /// rozłączamu jak rozłączono, oraz co 100 razy wysyłamy wejścia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            ustaw_wyjscia();
            if (!serialPort.IsOpen && polaczono)
                rozlaczenie();

            if (polaczono && licznik_czasu++ % 100 == 0)
            {
                wyslij_wejscia();
                wyslij_jakie_wyjscia_do_odczytania();
            }
        }

        /// <summary>
        /// ustawia aktywność wyjścia z układu
        /// </summary>
        /// <param name="sender"></param>
        private void aktywnosc_wyjscia(object sender)
        {
            if (polaczono)
            {
                int a;
                for (a = 0; (Button)sender != wyj[a].nr_wyswietlany; a++) ;
                wyj[a].zmien_aktywnosc();
            }
        }

        /// <summary>
        /// funkcje odpowiadające za wciskanie odpowiednich przycisków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void aktywnosc_wej1_Click(object sender, EventArgs e)
        {
            ustaw_aktywnosc_zadajnika(sender);
        }

        private void aktywnosc_wej2_Click(object sender, EventArgs e)
        {
            ustaw_aktywnosc_zadajnika(sender);
        }

        private void aktywnosc_wej3_Click(object sender, EventArgs e)
        {
            ustaw_aktywnosc_zadajnika(sender);
        }

        private void aktywnosc_wej4_Click(object sender, EventArgs e)
        {
            ustaw_aktywnosc_zadajnika(sender);
        }

        private void aktywnosc_wej5_Click(object sender, EventArgs e)
        {
            ustaw_aktywnosc_zadajnika(sender);
        }

        private void aktywnosc_wej6_Click(object sender, EventArgs e)
        {
            ustaw_aktywnosc_zadajnika(sender);
        }

        private void aktywnosc_wej7_Click(object sender, EventArgs e)
        {
            ustaw_aktywnosc_zadajnika(sender);
        }

        private void aktywnosc_wej8_Click(object sender, EventArgs e)
        {
            ustaw_aktywnosc_zadajnika(sender);
        }

        private void zadajnik1_Click(object sender, EventArgs e)
        {
            obsluz_on_off_zadajnika(sender);
        }

        private void zadajnik2_Click(object sender, EventArgs e)
        {
            obsluz_on_off_zadajnika(sender);
        }

        private void zadajnik3_Click(object sender, EventArgs e)
        {
            obsluz_on_off_zadajnika(sender);
        }

        private void zadajnik4_Click(object sender, EventArgs e)
        {
            obsluz_on_off_zadajnika(sender);
        }

        private void zadajnik5_Click(object sender, EventArgs e)
        {
            obsluz_on_off_zadajnika(sender);
        }

        private void zadajnik6_Click(object sender, EventArgs e)
        {
            obsluz_on_off_zadajnika(sender);
        }

        private void zadajnik7_Click(object sender, EventArgs e)
        {
            obsluz_on_off_zadajnika(sender);
        }

        private void zadajnik8_Click(object sender, EventArgs e)
        {
            obsluz_on_off_zadajnika(sender);
        }

        private void nr_wyj1_Click(object sender, EventArgs e)
        {
            aktywnosc_wyjscia(sender);
        }

        private void nr_wyj2_Click(object sender, EventArgs e)
        {
            aktywnosc_wyjscia(sender);
        }

        private void nr_wyj3_Click(object sender, EventArgs e)
        {
            aktywnosc_wyjscia(sender);
        }

        private void nr_wyj4_Click(object sender, EventArgs e)
        {
            aktywnosc_wyjscia(sender);
        }

        private void nr_wyj5_Click(object sender, EventArgs e)
        {
            aktywnosc_wyjscia(sender);
        }

        private void nr_wyj6_Click(object sender, EventArgs e)
        {
            aktywnosc_wyjscia(sender);
        }
    }
}