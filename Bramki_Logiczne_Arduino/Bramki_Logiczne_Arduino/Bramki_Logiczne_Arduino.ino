/*
 Name:		Bramki_Logiczne_Arduino.ino
 Created:	2016-03-04 14:20:22
 Author:	Marcin
*/

/// zmienne
bool stan[6]; // stan wyjœæ z uk³adu
bool aktywnoscWyjsc[6]; // jak aktywne to gdy zmiana zapalamy diodê
byte stan_wejsc = 0; // stan wejœæ do uk³adu
int odcz[] = { A0, A1, A2, A3, A4, A5 }; // nr pinów odczytu
long czas_zapalenia = 0; // czas do jakiego ma byæ zapalona dioda
long czas_wyslania_odczytu = 0; // czas po jakim ma byæ wys³any odczyt
bool stan_polaczenia = false; // stan po³¹czenia z komputerem

/// inicjalizacja pocz¹tkowa programu
void setup() {
	// deklaracja pinów odczytu
	for (int a = 0; a < 6; a++)
		pinMode(odcz[a], INPUT);

	// odczytanie pocz¹tkowych wartoœci pól
	for (int a = 0; a < 6; a++) {
		if (digitalRead(odcz[a]) == HIGH)
			stan[a] = true;
		else stan[a] = false;
	}

	// deklaracja zadajników
	for (int a = 0; a < 8; a++)
		pinMode(a, OUTPUT);

	// ustawienie wszyztkoego na 0V
	for (int a = 0; a < 8; a++)
		digitalWrite(a, LOW);

	// ustawienie wszystkich wyjœæ jako nieaktyenych

	// ustawienie diody do migania oraz miganie na start porgramu
	pinMode(13, OUTPUT);
	szybkie_miganie();
}

/// funkcja ustawia wszystkie wyjœcia jako nie aktywne
void dezaktywujWyjscia() {
	for (int i = 0; i < 6; i++)
		aktywnoscWyjsc[i] = false;
}

///wys³anie odczytanych danych wyjœciowych z uk³adu
void wyslij_odczyt() {
	//stan pinów odczytu
	// czytamy od ostatniego (numerowane s¹ 0-5 czyli 5, 4, 3, 2, 1, 0)
	// jak rozlo¿ymi liczbê binarnie to odpowiednie bity to 
	// np liczba 32 w rozk³adzie to 100000
	byte wysyl[1];
	byte m = 1;
	wysyl[0] = 0;
	for (int a = 0; a < 6; a++) {
		if (stan[a])
			wysyl[0] += m;
		m *= 2;
	}
	Serial.write(wysyl, 1);
}

/// miganie normalne
void miganie() {
	for (int i = 0; i < 4; i++)
	{
		digitalWrite(13, HIGH);
		delay(500);
		digitalWrite(13, LOW);
		delay(500);
	}
}

/// miganie szybkie
void szybkie_miganie() {
	for (int a = 0; a < 8; a++)
	{
		digitalWrite(13, HIGH);
		delay(100);
		digitalWrite(13, LOW);
		delay(200);
	}
}

/// funkcja odbieraj¹ca dane z komputera
void ustaw_odcztywane_wyjscia(byte odczytane) {
	for (byte i = 32, j = 5; i > 0; i /= 2, j--)
	{
		if (odczytane >= i)
		{
			aktywnoscWyjsc[j] = true;
			odczytane -= i;
		}
		else aktywnoscWyjsc[j] = false;
	}
}

/// odczytanie danych z komputera
void odczytPakietu() {
	byte odczyt[2];
	while (Serial.available())
		Serial.readBytes(odczyt, 2);

	if (odczyt[0]==0)
		ustaw_wejscie_ukladu(odczyt[1]);
	else ustaw_odcztywane_wyjscia(odczyt[1]);
}

/// ustawienie wartoœci na wejœcie z uk³adu
void ustaw_wejscie_ukladu(int b) {
	stan_wejsc = b;
	int mnoznik = 128;
	for (int i = 7; i >= 0; i--) {
		if (b >= mnoznik) {
			digitalWrite(i, HIGH);
			b -= mnoznik;
		}
		else 
			digitalWrite(i, LOW);
		mnoznik /= 2;
	}
}

/// sprawdza czy zosta³y zmienione wartoœci na wyjœciu z uk³adu
bool sprawdz_zmiane() {
	bool wys = false;
	for (int a = 0; a < 6; a++) {
		if (aktywnoscWyjsc[a])
		{
			if (digitalRead(odcz[a]) == HIGH) {
				if (!stan[a]) {
					stan[a] = true;
					wys = true;
					czas_zapalenia = millis() + 1000;
					digitalWrite(13, HIGH);
				}
			}
			else if (stan[a]) {
				stan[a] = false;
				wys = true;
				czas_zapalenia = millis() + 1000;
				digitalWrite(13, HIGH);
			}
		}
	}
	if (millis() > czas_zapalenia)
		digitalWrite(13, LOW);

	if (wys)
		wyslij_odczyt();

	return wys;
}

/// pomocna przy tworzeniu programu
void wyswietlanie_stanow_cyfrowych() {
	for (int a = 0; a < 6; a++)
		Serial.print(String(digitalRead(odcz[a])) + " ");
	Serial.println();
}

/// pomocna przy tworzeniu programu
void wyswietlanie_stanow_analogowych() {
	for (int a = 0; a < 6; a++)
		Serial.print(String(analogRead(odcz[a])) + " ");
	Serial.println();
}

/// funkcja loop
void loop() {
	// sprawdzanie po³¹czenia - g³ówny warunek co bêdzie siê wykonywa³o
	if (!Serial) {
		Serial.begin(9600);
		dezaktywujWyjscia();
		stan_polaczenia = false;
	} 
	else if (stan_polaczenia) {
		if (Serial.available())
			odczytPakietu();

		if (!sprawdz_zmiane() && millis() > czas_wyslania_odczytu) {
			czas_wyslania_odczytu = millis() + 1500;
			wyslij_odczyt();
		}
	}
	else {
		String pom = Serial.readStringUntil('\n');
		if (pom == "markowanga")
		{
			Serial.println("Haslo poprawne");
			miganie();
			stan_polaczenia = true;
		}
	}
}