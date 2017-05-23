namespace Bramki_logiczne_Arduino___app
{
    partial class FormApp
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.stan_napis = new System.Windows.Forms.Label();
            this.stan_polaczenia = new System.Windows.Forms.Label();
            this.przycisk_polaczenia = new System.Windows.Forms.Button();
            this.grupa_wejscia = new System.Windows.Forms.GroupBox();
            this.zadajnik8 = new System.Windows.Forms.Button();
            this.zadajnik7 = new System.Windows.Forms.Button();
            this.zadajnik6 = new System.Windows.Forms.Button();
            this.zadajnik5 = new System.Windows.Forms.Button();
            this.zadajnik4 = new System.Windows.Forms.Button();
            this.zadajnik3 = new System.Windows.Forms.Button();
            this.zadajnik2 = new System.Windows.Forms.Button();
            this.zadajnik1 = new System.Windows.Forms.Button();
            this.aktywnosc_wej8 = new System.Windows.Forms.Button();
            this.aktywnosc_wej7 = new System.Windows.Forms.Button();
            this.aktywnosc_wej6 = new System.Windows.Forms.Button();
            this.aktywnosc_wej5 = new System.Windows.Forms.Button();
            this.aktywnosc_wej4 = new System.Windows.Forms.Button();
            this.aktywnosc_wej3 = new System.Windows.Forms.Button();
            this.aktywnosc_wej2 = new System.Windows.Forms.Button();
            this.aktywnosc_wej1 = new System.Windows.Forms.Button();
            this.nr_zadajnika6 = new System.Windows.Forms.Label();
            this.nr_zadajnika7 = new System.Windows.Forms.Label();
            this.nr_zadajnika8 = new System.Windows.Forms.Label();
            this.nr_zadajnika2 = new System.Windows.Forms.Label();
            this.nr_zadajnika3 = new System.Windows.Forms.Label();
            this.nr_zadajnika4 = new System.Windows.Forms.Label();
            this.nr_zadajnika5 = new System.Windows.Forms.Label();
            this.nr_zadajnika1 = new System.Windows.Forms.Label();
            this.grupa_wyjscia = new System.Windows.Forms.GroupBox();
            this.nr_wyj6 = new System.Windows.Forms.Button();
            this.nr_wyj5 = new System.Windows.Forms.Button();
            this.nr_wyj4 = new System.Windows.Forms.Button();
            this.nr_wyj3 = new System.Windows.Forms.Button();
            this.nr_wyj2 = new System.Windows.Forms.Button();
            this.nr_wyj1 = new System.Windows.Forms.Button();
            this.odcz6 = new System.Windows.Forms.Label();
            this.odcz5 = new System.Windows.Forms.Label();
            this.odcz4 = new System.Windows.Forms.Label();
            this.odcz3 = new System.Windows.Forms.Label();
            this.odcz2 = new System.Windows.Forms.Label();
            this.odcz1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grupa_wejscia.SuspendLayout();
            this.grupa_wyjscia.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // stan_napis
            // 
            this.stan_napis.AutoSize = true;
            this.stan_napis.Location = new System.Drawing.Point(12, 9);
            this.stan_napis.Name = "stan_napis";
            this.stan_napis.Size = new System.Drawing.Size(88, 13);
            this.stan_napis.TabIndex = 0;
            this.stan_napis.Text = "Stan połączenia:";
            // 
            // stan_polaczenia
            // 
            this.stan_polaczenia.AutoSize = true;
            this.stan_polaczenia.ForeColor = System.Drawing.Color.Red;
            this.stan_polaczenia.Location = new System.Drawing.Point(106, 9);
            this.stan_polaczenia.Name = "stan_polaczenia";
            this.stan_polaczenia.Size = new System.Drawing.Size(75, 13);
            this.stan_polaczenia.TabIndex = 1;
            this.stan_polaczenia.Text = "nie połączono";
            // 
            // przycisk_polaczenia
            // 
            this.przycisk_polaczenia.Location = new System.Drawing.Point(222, 5);
            this.przycisk_polaczenia.Name = "przycisk_polaczenia";
            this.przycisk_polaczenia.Size = new System.Drawing.Size(55, 21);
            this.przycisk_polaczenia.TabIndex = 2;
            this.przycisk_polaczenia.Text = "Połącz";
            this.przycisk_polaczenia.UseVisualStyleBackColor = true;
            this.przycisk_polaczenia.Click += new System.EventHandler(this.przycisk_polaczenia_Click);
            // 
            // grupa_wejscia
            // 
            this.grupa_wejscia.Controls.Add(this.zadajnik8);
            this.grupa_wejscia.Controls.Add(this.zadajnik7);
            this.grupa_wejscia.Controls.Add(this.zadajnik6);
            this.grupa_wejscia.Controls.Add(this.zadajnik5);
            this.grupa_wejscia.Controls.Add(this.zadajnik4);
            this.grupa_wejscia.Controls.Add(this.zadajnik3);
            this.grupa_wejscia.Controls.Add(this.zadajnik2);
            this.grupa_wejscia.Controls.Add(this.zadajnik1);
            this.grupa_wejscia.Controls.Add(this.aktywnosc_wej8);
            this.grupa_wejscia.Controls.Add(this.aktywnosc_wej7);
            this.grupa_wejscia.Controls.Add(this.aktywnosc_wej6);
            this.grupa_wejscia.Controls.Add(this.aktywnosc_wej5);
            this.grupa_wejscia.Controls.Add(this.aktywnosc_wej4);
            this.grupa_wejscia.Controls.Add(this.aktywnosc_wej3);
            this.grupa_wejscia.Controls.Add(this.aktywnosc_wej2);
            this.grupa_wejscia.Controls.Add(this.aktywnosc_wej1);
            this.grupa_wejscia.Controls.Add(this.nr_zadajnika6);
            this.grupa_wejscia.Controls.Add(this.nr_zadajnika7);
            this.grupa_wejscia.Controls.Add(this.nr_zadajnika8);
            this.grupa_wejscia.Controls.Add(this.nr_zadajnika2);
            this.grupa_wejscia.Controls.Add(this.nr_zadajnika3);
            this.grupa_wejscia.Controls.Add(this.nr_zadajnika4);
            this.grupa_wejscia.Controls.Add(this.nr_zadajnika5);
            this.grupa_wejscia.Controls.Add(this.nr_zadajnika1);
            this.grupa_wejscia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grupa_wejscia.Location = new System.Drawing.Point(12, 38);
            this.grupa_wejscia.Name = "grupa_wejscia";
            this.grupa_wejscia.Size = new System.Drawing.Size(553, 94);
            this.grupa_wejscia.TabIndex = 3;
            this.grupa_wejscia.TabStop = false;
            this.grupa_wejscia.Text = "Wejścia do układu";
            // 
            // zadajnik8
            // 
            this.zadajnik8.FlatAppearance.BorderSize = 0;
            this.zadajnik8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadajnik8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadajnik8.Location = new System.Drawing.Point(477, 57);
            this.zadajnik8.Name = "zadajnik8";
            this.zadajnik8.Size = new System.Drawing.Size(56, 19);
            this.zadajnik8.TabIndex = 24;
            this.zadajnik8.Text = "OFF";
            this.zadajnik8.UseVisualStyleBackColor = true;
            this.zadajnik8.Click += new System.EventHandler(this.zadajnik8_Click);
            // 
            // zadajnik7
            // 
            this.zadajnik7.FlatAppearance.BorderSize = 0;
            this.zadajnik7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadajnik7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadajnik7.Location = new System.Drawing.Point(410, 57);
            this.zadajnik7.Name = "zadajnik7";
            this.zadajnik7.Size = new System.Drawing.Size(56, 19);
            this.zadajnik7.TabIndex = 23;
            this.zadajnik7.Text = "OFF";
            this.zadajnik7.UseVisualStyleBackColor = true;
            this.zadajnik7.Click += new System.EventHandler(this.zadajnik7_Click);
            // 
            // zadajnik6
            // 
            this.zadajnik6.FlatAppearance.BorderSize = 0;
            this.zadajnik6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadajnik6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadajnik6.Location = new System.Drawing.Point(341, 57);
            this.zadajnik6.Name = "zadajnik6";
            this.zadajnik6.Size = new System.Drawing.Size(56, 19);
            this.zadajnik6.TabIndex = 22;
            this.zadajnik6.Text = "OFF";
            this.zadajnik6.UseVisualStyleBackColor = true;
            this.zadajnik6.Click += new System.EventHandler(this.zadajnik6_Click);
            // 
            // zadajnik5
            // 
            this.zadajnik5.FlatAppearance.BorderSize = 0;
            this.zadajnik5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadajnik5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadajnik5.Location = new System.Drawing.Point(279, 57);
            this.zadajnik5.Name = "zadajnik5";
            this.zadajnik5.Size = new System.Drawing.Size(56, 19);
            this.zadajnik5.TabIndex = 21;
            this.zadajnik5.Text = "OFF";
            this.zadajnik5.UseVisualStyleBackColor = true;
            this.zadajnik5.Click += new System.EventHandler(this.zadajnik5_Click);
            // 
            // zadajnik4
            // 
            this.zadajnik4.FlatAppearance.BorderSize = 0;
            this.zadajnik4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadajnik4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadajnik4.Location = new System.Drawing.Point(212, 57);
            this.zadajnik4.Name = "zadajnik4";
            this.zadajnik4.Size = new System.Drawing.Size(56, 19);
            this.zadajnik4.TabIndex = 20;
            this.zadajnik4.Text = "OFF";
            this.zadajnik4.UseVisualStyleBackColor = true;
            this.zadajnik4.Click += new System.EventHandler(this.zadajnik4_Click);
            // 
            // zadajnik3
            // 
            this.zadajnik3.FlatAppearance.BorderSize = 0;
            this.zadajnik3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadajnik3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadajnik3.Location = new System.Drawing.Point(147, 57);
            this.zadajnik3.Name = "zadajnik3";
            this.zadajnik3.Size = new System.Drawing.Size(56, 19);
            this.zadajnik3.TabIndex = 19;
            this.zadajnik3.Text = "OFF";
            this.zadajnik3.UseVisualStyleBackColor = true;
            this.zadajnik3.Click += new System.EventHandler(this.zadajnik3_Click);
            // 
            // zadajnik2
            // 
            this.zadajnik2.FlatAppearance.BorderSize = 0;
            this.zadajnik2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadajnik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadajnik2.Location = new System.Drawing.Point(82, 57);
            this.zadajnik2.Name = "zadajnik2";
            this.zadajnik2.Size = new System.Drawing.Size(56, 19);
            this.zadajnik2.TabIndex = 18;
            this.zadajnik2.Text = "OFF";
            this.zadajnik2.UseVisualStyleBackColor = true;
            this.zadajnik2.Click += new System.EventHandler(this.zadajnik2_Click);
            // 
            // zadajnik1
            // 
            this.zadajnik1.FlatAppearance.BorderSize = 0;
            this.zadajnik1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadajnik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadajnik1.Location = new System.Drawing.Point(17, 57);
            this.zadajnik1.Name = "zadajnik1";
            this.zadajnik1.Size = new System.Drawing.Size(56, 19);
            this.zadajnik1.TabIndex = 16;
            this.zadajnik1.Text = "OFF";
            this.zadajnik1.UseVisualStyleBackColor = true;
            this.zadajnik1.Click += new System.EventHandler(this.zadajnik1_Click);
            // 
            // aktywnosc_wej8
            // 
            this.aktywnosc_wej8.FlatAppearance.BorderSize = 0;
            this.aktywnosc_wej8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktywnosc_wej8.Location = new System.Drawing.Point(477, 34);
            this.aktywnosc_wej8.Margin = new System.Windows.Forms.Padding(0);
            this.aktywnosc_wej8.Name = "aktywnosc_wej8";
            this.aktywnosc_wej8.Size = new System.Drawing.Size(56, 19);
            this.aktywnosc_wej8.TabIndex = 15;
            this.aktywnosc_wej8.Text = "Blokada";
            this.aktywnosc_wej8.UseVisualStyleBackColor = true;
            this.aktywnosc_wej8.Click += new System.EventHandler(this.aktywnosc_wej8_Click);
            // 
            // aktywnosc_wej7
            // 
            this.aktywnosc_wej7.FlatAppearance.BorderSize = 0;
            this.aktywnosc_wej7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktywnosc_wej7.Location = new System.Drawing.Point(410, 34);
            this.aktywnosc_wej7.Margin = new System.Windows.Forms.Padding(0);
            this.aktywnosc_wej7.Name = "aktywnosc_wej7";
            this.aktywnosc_wej7.Size = new System.Drawing.Size(56, 19);
            this.aktywnosc_wej7.TabIndex = 14;
            this.aktywnosc_wej7.Text = "Blokada";
            this.aktywnosc_wej7.UseVisualStyleBackColor = true;
            this.aktywnosc_wej7.Click += new System.EventHandler(this.aktywnosc_wej7_Click);
            // 
            // aktywnosc_wej6
            // 
            this.aktywnosc_wej6.FlatAppearance.BorderSize = 0;
            this.aktywnosc_wej6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktywnosc_wej6.Location = new System.Drawing.Point(344, 34);
            this.aktywnosc_wej6.Margin = new System.Windows.Forms.Padding(0);
            this.aktywnosc_wej6.Name = "aktywnosc_wej6";
            this.aktywnosc_wej6.Size = new System.Drawing.Size(56, 19);
            this.aktywnosc_wej6.TabIndex = 13;
            this.aktywnosc_wej6.Text = "Blokada";
            this.aktywnosc_wej6.UseMnemonic = false;
            this.aktywnosc_wej6.UseVisualStyleBackColor = true;
            this.aktywnosc_wej6.Click += new System.EventHandler(this.aktywnosc_wej6_Click);
            // 
            // aktywnosc_wej5
            // 
            this.aktywnosc_wej5.FlatAppearance.BorderSize = 0;
            this.aktywnosc_wej5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktywnosc_wej5.Location = new System.Drawing.Point(279, 34);
            this.aktywnosc_wej5.Margin = new System.Windows.Forms.Padding(0);
            this.aktywnosc_wej5.Name = "aktywnosc_wej5";
            this.aktywnosc_wej5.Size = new System.Drawing.Size(56, 19);
            this.aktywnosc_wej5.TabIndex = 12;
            this.aktywnosc_wej5.Text = "Blokada";
            this.aktywnosc_wej5.UseVisualStyleBackColor = true;
            this.aktywnosc_wej5.Click += new System.EventHandler(this.aktywnosc_wej5_Click);
            // 
            // aktywnosc_wej4
            // 
            this.aktywnosc_wej4.FlatAppearance.BorderSize = 0;
            this.aktywnosc_wej4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktywnosc_wej4.Location = new System.Drawing.Point(212, 34);
            this.aktywnosc_wej4.Margin = new System.Windows.Forms.Padding(0);
            this.aktywnosc_wej4.Name = "aktywnosc_wej4";
            this.aktywnosc_wej4.Size = new System.Drawing.Size(56, 19);
            this.aktywnosc_wej4.TabIndex = 11;
            this.aktywnosc_wej4.Text = "Blokada";
            this.aktywnosc_wej4.UseVisualStyleBackColor = true;
            this.aktywnosc_wej4.Click += new System.EventHandler(this.aktywnosc_wej4_Click);
            // 
            // aktywnosc_wej3
            // 
            this.aktywnosc_wej3.FlatAppearance.BorderSize = 0;
            this.aktywnosc_wej3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktywnosc_wej3.Location = new System.Drawing.Point(147, 34);
            this.aktywnosc_wej3.Margin = new System.Windows.Forms.Padding(0);
            this.aktywnosc_wej3.Name = "aktywnosc_wej3";
            this.aktywnosc_wej3.Size = new System.Drawing.Size(56, 19);
            this.aktywnosc_wej3.TabIndex = 10;
            this.aktywnosc_wej3.Text = "Blokada";
            this.aktywnosc_wej3.UseVisualStyleBackColor = true;
            this.aktywnosc_wej3.Click += new System.EventHandler(this.aktywnosc_wej3_Click);
            // 
            // aktywnosc_wej2
            // 
            this.aktywnosc_wej2.FlatAppearance.BorderSize = 0;
            this.aktywnosc_wej2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktywnosc_wej2.Location = new System.Drawing.Point(82, 34);
            this.aktywnosc_wej2.Margin = new System.Windows.Forms.Padding(0);
            this.aktywnosc_wej2.Name = "aktywnosc_wej2";
            this.aktywnosc_wej2.Size = new System.Drawing.Size(56, 19);
            this.aktywnosc_wej2.TabIndex = 9;
            this.aktywnosc_wej2.Text = "Blokada";
            this.aktywnosc_wej2.UseVisualStyleBackColor = true;
            this.aktywnosc_wej2.Click += new System.EventHandler(this.aktywnosc_wej2_Click);
            // 
            // aktywnosc_wej1
            // 
            this.aktywnosc_wej1.FlatAppearance.BorderSize = 0;
            this.aktywnosc_wej1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktywnosc_wej1.Location = new System.Drawing.Point(17, 34);
            this.aktywnosc_wej1.Margin = new System.Windows.Forms.Padding(0);
            this.aktywnosc_wej1.Name = "aktywnosc_wej1";
            this.aktywnosc_wej1.Size = new System.Drawing.Size(56, 19);
            this.aktywnosc_wej1.TabIndex = 8;
            this.aktywnosc_wej1.Text = "Blokada";
            this.aktywnosc_wej1.UseVisualStyleBackColor = true;
            this.aktywnosc_wej1.Click += new System.EventHandler(this.aktywnosc_wej1_Click);
            // 
            // nr_zadajnika6
            // 
            this.nr_zadajnika6.AutoSize = true;
            this.nr_zadajnika6.Location = new System.Drawing.Point(350, 16);
            this.nr_zadajnika6.Name = "nr_zadajnika6";
            this.nr_zadajnika6.Size = new System.Drawing.Size(57, 13);
            this.nr_zadajnika6.TabIndex = 7;
            this.nr_zadajnika6.Text = "numer 6    ";
            // 
            // nr_zadajnika7
            // 
            this.nr_zadajnika7.AutoSize = true;
            this.nr_zadajnika7.Location = new System.Drawing.Point(416, 16);
            this.nr_zadajnika7.Name = "nr_zadajnika7";
            this.nr_zadajnika7.Size = new System.Drawing.Size(57, 13);
            this.nr_zadajnika7.TabIndex = 6;
            this.nr_zadajnika7.Text = "numer 7    ";
            // 
            // nr_zadajnika8
            // 
            this.nr_zadajnika8.AutoSize = true;
            this.nr_zadajnika8.Location = new System.Drawing.Point(483, 16);
            this.nr_zadajnika8.Name = "nr_zadajnika8";
            this.nr_zadajnika8.Size = new System.Drawing.Size(57, 13);
            this.nr_zadajnika8.TabIndex = 5;
            this.nr_zadajnika8.Text = "numer 8    ";
            // 
            // nr_zadajnika2
            // 
            this.nr_zadajnika2.AutoSize = true;
            this.nr_zadajnika2.Location = new System.Drawing.Point(88, 16);
            this.nr_zadajnika2.Name = "nr_zadajnika2";
            this.nr_zadajnika2.Size = new System.Drawing.Size(45, 13);
            this.nr_zadajnika2.TabIndex = 4;
            this.nr_zadajnika2.Text = "numer 2";
            // 
            // nr_zadajnika3
            // 
            this.nr_zadajnika3.AutoSize = true;
            this.nr_zadajnika3.Location = new System.Drawing.Point(153, 16);
            this.nr_zadajnika3.Name = "nr_zadajnika3";
            this.nr_zadajnika3.Size = new System.Drawing.Size(57, 13);
            this.nr_zadajnika3.TabIndex = 3;
            this.nr_zadajnika3.Text = "numer 3    ";
            // 
            // nr_zadajnika4
            // 
            this.nr_zadajnika4.AutoSize = true;
            this.nr_zadajnika4.Location = new System.Drawing.Point(218, 16);
            this.nr_zadajnika4.Name = "nr_zadajnika4";
            this.nr_zadajnika4.Size = new System.Drawing.Size(57, 13);
            this.nr_zadajnika4.TabIndex = 2;
            this.nr_zadajnika4.Text = "numer 4    ";
            // 
            // nr_zadajnika5
            // 
            this.nr_zadajnika5.AutoSize = true;
            this.nr_zadajnika5.Location = new System.Drawing.Point(285, 16);
            this.nr_zadajnika5.Name = "nr_zadajnika5";
            this.nr_zadajnika5.Size = new System.Drawing.Size(57, 13);
            this.nr_zadajnika5.TabIndex = 1;
            this.nr_zadajnika5.Text = "numer 5    ";
            // 
            // nr_zadajnika1
            // 
            this.nr_zadajnika1.AutoSize = true;
            this.nr_zadajnika1.Location = new System.Drawing.Point(23, 16);
            this.nr_zadajnika1.Name = "nr_zadajnika1";
            this.nr_zadajnika1.Size = new System.Drawing.Size(57, 13);
            this.nr_zadajnika1.TabIndex = 0;
            this.nr_zadajnika1.Text = "numer 1    ";
            // 
            // grupa_wyjscia
            // 
            this.grupa_wyjscia.Controls.Add(this.nr_wyj6);
            this.grupa_wyjscia.Controls.Add(this.nr_wyj5);
            this.grupa_wyjscia.Controls.Add(this.nr_wyj4);
            this.grupa_wyjscia.Controls.Add(this.nr_wyj3);
            this.grupa_wyjscia.Controls.Add(this.nr_wyj2);
            this.grupa_wyjscia.Controls.Add(this.nr_wyj1);
            this.grupa_wyjscia.Controls.Add(this.odcz6);
            this.grupa_wyjscia.Controls.Add(this.odcz5);
            this.grupa_wyjscia.Controls.Add(this.odcz4);
            this.grupa_wyjscia.Controls.Add(this.odcz3);
            this.grupa_wyjscia.Controls.Add(this.odcz2);
            this.grupa_wyjscia.Controls.Add(this.odcz1);
            this.grupa_wyjscia.Location = new System.Drawing.Point(12, 138);
            this.grupa_wyjscia.Name = "grupa_wyjscia";
            this.grupa_wyjscia.Size = new System.Drawing.Size(552, 111);
            this.grupa_wyjscia.TabIndex = 4;
            this.grupa_wyjscia.TabStop = false;
            this.grupa_wyjscia.Text = "Wyjścia z układu";
            // 
            // nr_wyj6
            // 
            this.nr_wyj6.FlatAppearance.BorderSize = 0;
            this.nr_wyj6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nr_wyj6.Location = new System.Drawing.Point(436, 29);
            this.nr_wyj6.Name = "nr_wyj6";
            this.nr_wyj6.Size = new System.Drawing.Size(56, 19);
            this.nr_wyj6.TabIndex = 30;
            this.nr_wyj6.Text = "numer 6";
            this.nr_wyj6.UseVisualStyleBackColor = true;
            this.nr_wyj6.Click += new System.EventHandler(this.nr_wyj6_Click);
            // 
            // nr_wyj5
            // 
            this.nr_wyj5.FlatAppearance.BorderSize = 0;
            this.nr_wyj5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nr_wyj5.Location = new System.Drawing.Point(360, 29);
            this.nr_wyj5.Name = "nr_wyj5";
            this.nr_wyj5.Size = new System.Drawing.Size(56, 19);
            this.nr_wyj5.TabIndex = 29;
            this.nr_wyj5.Text = "numer 5";
            this.nr_wyj5.UseVisualStyleBackColor = true;
            this.nr_wyj5.Click += new System.EventHandler(this.nr_wyj5_Click);
            // 
            // nr_wyj4
            // 
            this.nr_wyj4.FlatAppearance.BorderSize = 0;
            this.nr_wyj4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nr_wyj4.Location = new System.Drawing.Point(282, 29);
            this.nr_wyj4.Name = "nr_wyj4";
            this.nr_wyj4.Size = new System.Drawing.Size(56, 19);
            this.nr_wyj4.TabIndex = 28;
            this.nr_wyj4.Text = "numer 4";
            this.nr_wyj4.UseVisualStyleBackColor = true;
            this.nr_wyj4.Click += new System.EventHandler(this.nr_wyj4_Click);
            // 
            // nr_wyj3
            // 
            this.nr_wyj3.FlatAppearance.BorderSize = 0;
            this.nr_wyj3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nr_wyj3.Location = new System.Drawing.Point(206, 29);
            this.nr_wyj3.Name = "nr_wyj3";
            this.nr_wyj3.Size = new System.Drawing.Size(56, 19);
            this.nr_wyj3.TabIndex = 27;
            this.nr_wyj3.Text = "numer 3";
            this.nr_wyj3.UseVisualStyleBackColor = true;
            this.nr_wyj3.Click += new System.EventHandler(this.nr_wyj3_Click);
            // 
            // nr_wyj2
            // 
            this.nr_wyj2.FlatAppearance.BorderSize = 0;
            this.nr_wyj2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nr_wyj2.Location = new System.Drawing.Point(131, 29);
            this.nr_wyj2.Name = "nr_wyj2";
            this.nr_wyj2.Size = new System.Drawing.Size(56, 19);
            this.nr_wyj2.TabIndex = 26;
            this.nr_wyj2.Text = "numer 2";
            this.nr_wyj2.UseVisualStyleBackColor = true;
            this.nr_wyj2.Click += new System.EventHandler(this.nr_wyj2_Click);
            // 
            // nr_wyj1
            // 
            this.nr_wyj1.FlatAppearance.BorderSize = 0;
            this.nr_wyj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nr_wyj1.Location = new System.Drawing.Point(55, 29);
            this.nr_wyj1.Name = "nr_wyj1";
            this.nr_wyj1.Size = new System.Drawing.Size(56, 19);
            this.nr_wyj1.TabIndex = 25;
            this.nr_wyj1.Text = "numer 1";
            this.nr_wyj1.UseVisualStyleBackColor = true;
            this.nr_wyj1.Click += new System.EventHandler(this.nr_wyj1_Click);
            // 
            // odcz6
            // 
            this.odcz6.AutoEllipsis = true;
            this.odcz6.AutoSize = true;
            this.odcz6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.odcz6.Location = new System.Drawing.Point(447, 62);
            this.odcz6.Name = "odcz6";
            this.odcz6.Size = new System.Drawing.Size(32, 13);
            this.odcz6.TabIndex = 5;
            this.odcz6.Text = "False";
            // 
            // odcz5
            // 
            this.odcz5.AutoEllipsis = true;
            this.odcz5.AutoSize = true;
            this.odcz5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.odcz5.Location = new System.Drawing.Point(371, 62);
            this.odcz5.Name = "odcz5";
            this.odcz5.Size = new System.Drawing.Size(32, 13);
            this.odcz5.TabIndex = 4;
            this.odcz5.Text = "False";
            // 
            // odcz4
            // 
            this.odcz4.AutoEllipsis = true;
            this.odcz4.AutoSize = true;
            this.odcz4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.odcz4.Location = new System.Drawing.Point(293, 62);
            this.odcz4.Name = "odcz4";
            this.odcz4.Size = new System.Drawing.Size(32, 13);
            this.odcz4.TabIndex = 3;
            this.odcz4.Text = "False";
            // 
            // odcz3
            // 
            this.odcz3.AutoEllipsis = true;
            this.odcz3.AutoSize = true;
            this.odcz3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.odcz3.Location = new System.Drawing.Point(217, 62);
            this.odcz3.Name = "odcz3";
            this.odcz3.Size = new System.Drawing.Size(32, 13);
            this.odcz3.TabIndex = 2;
            this.odcz3.Text = "False";
            // 
            // odcz2
            // 
            this.odcz2.AutoEllipsis = true;
            this.odcz2.AutoSize = true;
            this.odcz2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.odcz2.Location = new System.Drawing.Point(142, 62);
            this.odcz2.Name = "odcz2";
            this.odcz2.Size = new System.Drawing.Size(32, 13);
            this.odcz2.TabIndex = 1;
            this.odcz2.Text = "False";
            // 
            // odcz1
            // 
            this.odcz1.AutoEllipsis = true;
            this.odcz1.AutoSize = true;
            this.odcz1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.odcz1.Location = new System.Drawing.Point(66, 62);
            this.odcz1.Name = "odcz1";
            this.odcz1.Size = new System.Drawing.Size(32, 13);
            this.odcz1.TabIndex = 0;
            this.odcz1.Text = "False";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 261);
            this.Controls.Add(this.grupa_wyjscia);
            this.Controls.Add(this.grupa_wejscia);
            this.Controls.Add(this.przycisk_polaczenia);
            this.Controls.Add(this.stan_polaczenia);
            this.Controls.Add(this.stan_napis);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormApp";
            this.Text = "Bramki logiczne - Arduino";
            this.grupa_wejscia.ResumeLayout(false);
            this.grupa_wejscia.PerformLayout();
            this.grupa_wyjscia.ResumeLayout(false);
            this.grupa_wyjscia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label stan_napis;
        private System.Windows.Forms.Label stan_polaczenia;
        private System.Windows.Forms.Button przycisk_polaczenia;
        private System.Windows.Forms.GroupBox grupa_wejscia;
        private System.Windows.Forms.GroupBox grupa_wyjscia;
        private System.Windows.Forms.Label nr_zadajnika6;
        private System.Windows.Forms.Label nr_zadajnika7;
        private System.Windows.Forms.Label nr_zadajnika8;
        private System.Windows.Forms.Label nr_zadajnika2;
        private System.Windows.Forms.Label nr_zadajnika3;
        private System.Windows.Forms.Label nr_zadajnika4;
        private System.Windows.Forms.Label nr_zadajnika5;
        private System.Windows.Forms.Label nr_zadajnika1;
        public System.Windows.Forms.Label odcz6;
        public System.Windows.Forms.Label odcz5;
        public System.Windows.Forms.Label odcz4;
        public System.Windows.Forms.Label odcz3;
        public System.Windows.Forms.Label odcz2;
        public System.Windows.Forms.Label odcz1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button zadajnik8;
        private System.Windows.Forms.Button zadajnik7;
        private System.Windows.Forms.Button zadajnik6;
        private System.Windows.Forms.Button zadajnik5;
        private System.Windows.Forms.Button zadajnik4;
        private System.Windows.Forms.Button zadajnik3;
        private System.Windows.Forms.Button zadajnik2;
        private System.Windows.Forms.Button zadajnik1;
        private System.Windows.Forms.Button aktywnosc_wej8;
        private System.Windows.Forms.Button aktywnosc_wej7;
        private System.Windows.Forms.Button aktywnosc_wej6;
        private System.Windows.Forms.Button aktywnosc_wej5;
        private System.Windows.Forms.Button aktywnosc_wej4;
        private System.Windows.Forms.Button aktywnosc_wej3;
        private System.Windows.Forms.Button aktywnosc_wej2;
        private System.Windows.Forms.Button aktywnosc_wej1;
        private System.Windows.Forms.Button nr_wyj6;
        private System.Windows.Forms.Button nr_wyj5;
        private System.Windows.Forms.Button nr_wyj4;
        private System.Windows.Forms.Button nr_wyj3;
        private System.Windows.Forms.Button nr_wyj2;
        private System.Windows.Forms.Button nr_wyj1;
    }
}

