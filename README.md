# CSharp-programmieren-Teil-1
## UE Programmieren I, WS18/19: 
### Inhalt: Arithmetische Operatoren, If – Else, Switch, Loops, Methoden, Arrays

#### Konsole Eingabe und Ausgabe

T1K1 – Eingabe
Implementieren Sie ein Programm, welches einen String, ein einzelnes Zeichen, einen Integerwert und eine Fließkommazahl von der Konsole einliest.

#### Arithmetische Operatoren

T1O1 – Fahrkartenschalter
Implementieren Sie den Fahrkartenschalter anhand des Struktogramms.

T1O2 - Zahlen Quadrieren
Implementieren Sie ein Programm zum Quadrieren einer Zahl, die über die Konsole eingegeben wird.

T1O3 – Rechteck berechnen
Implementieren Sie ein Programm zur Berechnung von Umfang und Fläche eines Rechtecks. Die Seitenlängen des Rechtecks werden über Konsole eingegeben.

T1O4 – Kreis berechnen
Implementieren Sie ein Programm zur Berechnung von Umfang (U) und Fläche (A) eines Kreises. Der Radius des Kreises wird über Konsole eingegeben. 𝑈=2∙𝑟∙𝜋
𝐴=𝑟∙𝑟∙𝜋

T1O5 – Inhalt Geldbörse berechnen
Geben Sie über Konsole die Zahl der 1 Euro, 2 Euro Münzen und 5 Euro Scheine in Ihrer Geldbörse ein. Berechnen Sie den Gesamtbetrag und geben Sie diesen auf der Konsole aus.

T1O6 –Mwst Berechnung
Geben Sie über Konsole den Bruttopreis und den Mwst Satz einer Ware an. Berechnen Sie dann den Nettopreis sowie den Mwst Betrag und geben Sie beides auf der Konsole aus.

T1O7 – Berechnung Fahrenheit
Geben Sie eine Temepratur in Celsius über Konsole ein. Rechnen Sie diesen Wert in Fahrenheit um und geben Sie das Resultat auf der Konsole aus.
Die Umrechnung erfolgt nach folgender Formel: TF = 32 + 1,8 * TC

T1O8 – Quadratische Formel
Implementieren Sie ein Programm zur Lösung einer quadratischen Gleichung der Form 𝑎𝑥2+ 𝑏𝑥+𝑐=0 𝑚𝑖𝑡 𝑎≠0
Zur Berechnung der beiden Werte für x verwenden Sie folgende Formel 𝑥=−𝑏±√𝑏2−4𝑎𝑐2𝑎
Die Werte der Koeffizienten a, b und c werden über Konsole eingegeben.
Verwenden Sie Math.Sqrt( d ) zur Berechnung der Quadratwurzel.

T1O9 – Body Mass Index
Geben Sie über Konsole die Werte für Gewicht und Körpergröße (in Meter) ein. Berechnen Sie den Body Mass Index und geben Sie das Resultat auf der Konsole aus. 𝐵𝑀𝐼= 𝐺𝑒𝑤𝑖𝑐ℎ𝑡𝐾ö𝑟𝑝𝑒𝑟𝑔𝑟öß𝑒2

T1O10 – Benzinverbrauch
Geben Sie über Konsole die Anzahl der gefahrenen Kilometer und die verbrauchten Liter Benzin ein. Berechnen Sie den Benzinverbrauch pro 100 km und das für die Strecke angefallene Amtliche Kilometergeld (0.42€/km).

T1O11 – Verkäufergehalt
Geben Sie über Konsole das monatliche Fixgehalt eines Verkäufers ein, sowie der von ihm erzielte Umsatz. Das Monatsgehalt des Verkäufers besteht aus dem Fixgehalt plus 5 Prozent seines Umsatzes.

T1O12 – Gehalt
Geben Sie über Konsole den Stundensatz des Mitarbeiters ein, sowie die Anzahl der geleisteten 50% Überstunden und der 100% Überstunden. Berechnen Sie dann das monatliche Gesamtgehalt. Kalkulieren Sie mit 38.5 Stunden pro Woche und 4 Wochen pro Monat.

T1O13 – Fahrzeit berechnen
Geben Sie über Konsole die Abfahrtszeit des Zuges in Stunden und Minuten und die Ankunftszeit des Zuges in Stunden und Minuten ein. Berechnen Sie die Fahrzeit.

#### If – Else

T1I1 – Kehrwert
Implementieren Sie ein Programm zur Berechnung des Kehrwertes 1/z der Zahl z . Die Eingabe der
Zahl erfolgt über Konsole. Berücksichtigen Sie Division durch 0.

T1I2 – Mitgliedsbeitrag
Ein Verein benötigt ein Programm zur Berechnung von Mitgliedsbeiträgen. Der
Mitgliedsbeitrag beträgt 500 €. Verheiratete Mitglieder bezahlen nur 400 €, Studenten 300
€. Verheiratete Studenten bezahlen 200 €. Das Programm soll abfragen, ob das Mitglied
verheiratet ist und ob es studiert. Ausgegeben werden soll der jeweils gültige
Mitgliedsbeitrag! Erstellen Sie zwei Lösungen: einmal mit geschachteltem if und einmal ohne
geschachteltem if. Erstellen Sie auch die passenden Struktogramme.

T1I3 – Rabatt bei Buchhandlung
Eine Buchhandlung hat folgende Rabattstaffel: Bei einem Einkauf ab
500 € 20% Rabatt, von 300 € bis 499 € 14%, von 200 € bis 299 € 8% und
von 100€ S bis 199 € 3%. Unter 100 € wird kein Rabatt gewährt. Erstellen
Sie ein Programm, das aus dem Einkaufswert den Rabatt und den
rabattierten Preis berechnet!

T1I4 – Erweiterung Fahrkartenschalter
Erweitern Sie das Programm um Prüfungen der Benutzereingaben auf gültige Werte. Insbesondere
muss der Ermäßigungsprozent <= 100 sein und die Zahl der Fahrkarten > 0.

T1I5 – Berechnung der Tagnummer
Berechnen Sie aus den Eingaben für Tag, Monat und Jahr um den wievielten Tag des Jahres es sich
handelt. Gehen Sie davon aus, dass die Eingaben korrekte Datumsangaben darstellen. Das Jahr liegt
zwischen 1601 und 2399. Es gilt weiters:
• Ein Jahr ist Schaltjahr, wenn es durch 4 teilbar ist.
• Ist es aber auch durch 100 teilbar, dann gilt Regel 1 nicht, und es ist kein Schaltjahr.
• Ist es aber auch durch 400 teilbar, dann gilt Regel 2 nicht, und es ist doch ein Schaltjahr.

T1I6 – Einkommensteuer
Berechnen Sie die Einkommensteuer für das über Konsole eingegebene Jahresgehalt. Dabei gelten folgende Regeln: 

![2020-06-11 20_03_25-Window](https://user-images.githubusercontent.com/61902639/84423566-ef2e3280-ac1e-11ea-8307-f41193ad143c.png)

Geben Sie auf der Konsole den Steuerbetrag (StB) aus und den Steuersatz in Bezug auf das Jahresgehalt.

T1I7 – Gehaltsrechner
Über die Konsole wird das Basisgehalt und die Anzahl der Kinder eingegeben. Bei einem Kind gibt es einen Zuschuss von 100 €, bei zwei Kindern gibt es einen Zuschuss von 115 € pro Kind, bei mehr als zwei Kindern gibt es einen Zuschuss von 130 € pro Kind. Berechnen Sie das Endgehalt.

T1I8 – Seidelrechner
Im Kaisertum Österreich wurden Wein und Bier in Fass, Eimer, Maß und Seidel
gemessen. Und zwar galt: 1 Maß hat 4 Seidel, ein Eimer hat 40 Maß (sowohl für Wein als auch
für Bier); 1 Fass Wein hat 10 Eimer, ein Fass Bier hat 2 Eimer. Erstellen Sie ein Programm, das
einliest, ob es sich um Wein oder Bier handelt und danach die Anzahl der Fässer. Es soll die
Anzahl der darin enthaltenen Seidel berechnet werden.

#### Switch

T1S1 – Schulnoten
Erstellen Sie ein Programm, das für eine vom Benutzer eingegebene
Schulnote (1 bis 5), die verbale Bezeichnung ausgibt. Bei einer ungültigen
Eingabe soll eine Fehlermeldung erfolgen. Erstellen Sie zuerst ein
Struktogramm!

T1S2 – Umwandlung von Ziffer in Text
Implementieren Sie ein Programm, das die über Konsole eingegebene Ziffer im Bereich 0 bis 9 in die entsprechende Textausgabe umwandelt. Ist die Ziffer kleiner 4, dann wird der Text „Ziffer ist kleiner 4“ ausgegeben. Ist die Ziffer gleich 4 wird der Text „Vier“ ausgegeben. Ist die Ziffer zwischen 5 und 9 wird der Text „Ziffer ist größer 4“ auf der Konsole ausgegeben. In allen anderen Fällen wird der Text „Falsche Eingabe“ ausgegeben.

T1S3 – Berechnung arithmetischer Ausdruck
Berechnen Sie einen arithmetischen Ausdruck. Die Eingabe über Konsole ist in folgender Reihenfolge
1. Eingabe erster Operand
2. Eingabe zweiter Operand
3. Eingabe Operator
Geben Sie das Ergebnis des arithmetischen Ausdrucks auf der Konsole aus. Verwenden Sie eine switch Anweisung für die Behandlung des Operators.

T1S4 – Berechnung arithmetischer Ausdruck
Wie T1S3 aber unter ausschließlicher Verwendung von ternären Operatoren.

#### Loops

T1L1 – Multiplikation und Division
Schreiben Sie ein Programm für die ganzzahlige Multiplikation und Division zweier int Zahlen i und j. Verwenden Sie aber nur die Operatoren + und –. Bei der Division soll auch der Rest ermittelt werden. Erstellen Sie zuerst ein Struktogramm.

T1L2 - Fakultät
Schreiben Sie ein Programm zur Berechnung von n!, wobei gilt n! = n * (n-1) * (n-2) * … * 1

T1L3 – Größter gemeinsamer Teiler nach Euklid
Implementieren Sie ein Programm zur Berechnung des größten gemeinsamen Teilers zweier Zahlen. Beide Zahlen werden über die Konsole eingegeben. Verwenden Sie den Algorithmus von Euklid: Ziehen Sie von der größeren Zahl die jeweils kleinere Zahl ab, solange bis beide Zahlen gleich sind.

T1L4 – Collatz Folge
Eine Collatz-Folge für den Wert n ist definiert durch n -> n/2, falls n gerade ist, n -> 3n+1, falls n ungerade ist. Die Folge ist beendet, wenn 1 erreicht ist.
Beispiel für n = 7:
7 -> 22 -> 11 -> 34 -> 17 -> 52 -> 26 -> 13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1
Implementieren Sie ein Programm zur Berechnung der Collatzfolge für eine Zahl, die über Konsole eingegeben wird.

T1L5 – Bierverkäufer
Bei Start des Programmes haben Sie 99 Flaschen Bier im Kühlschrank. Über Konsole wird eingegeben, wie viele Bierflaschen Ihr Kunde kaufen will. Das geht solange bis Sie den gesamten Biervorrat verkauft haben.

T1L6 – Quersumme
Berechnen Sie die Quersumme einer Zahl, die über Konsole eingegeben wurde. Die Quersumme bildet man durch die Addition jeder Ziffer der Zahl. Wenn die Zahl etwa 10938 lautet, so ist die Quersumme 1+0+9+3+8 = 21.

T1L7 – Umrechnung in Binärdarstellung
Zeigen Sie die über Konsole eingegebene Integerzahl in der Binärdarstellung an.

T1L8 – Kontotransaktion
Implementieren Sie ein Programm zur Durchführung von Kontotransaktionen, das gesteuert über ein Menu in einer Endlosschleife läuft. Über das Menu stehen folgende Aktionen zur Auswahl:
1. Einzahlen
2. Abheben
3. Beenden
Bei Auswahl 1 oder 2 muss noch ein Betrag eingegeben werden. Abhebungen sind nur bis zu Erreichen eines Überziehungsrahmens möglich.

T1L9 – Zahlen summieren und multiplizieren
Implementieren Sie ein Programm, welches in einer Schleife Zahlen von der Konsole einliest. Die Schleife wird beendet bei Eingabe der Zahl 0. Geben Sie anschließend die Summe und das Produkt der eingelesenen Zahlen auf der Konsole aus.

T1L10 – Eingabefilter
Implementieren Sie ein Programm, welches in einer Endlosschleife ganze Zahlen von der Konsole einliest. Eine positive Zahl wird sofort wieder auf der Konsole ausgegeben. Eine 0 wird das erste Mal ausgegeben, alle weiteren unmittelbar folgenden 0 werden unterdrückt. Negative Zahlen werden ebenso unterdrückt. Die Endlosschleife endet bei Eingabe der Zahl -111.

T1L11 – Newtonverfahren
Implementieren Sie ein Programm welches nach dem Newtonverfahren die Wurzel aus einer Ganzzahl iterativ berechnet.
Berechnung der Quadratwurzel der Zahl z: 

![2020-06-11 20_06_41-Window](https://user-images.githubusercontent.com/61902639/84423699-2997cf80-ac1f-11ea-99e3-281c108e2364.png)

Berechnung der k-ten Wurzel der Zahl z:

![2020-06-11 20_06_53-Window](https://user-images.githubusercontent.com/61902639/84423707-2d2b5680-ac1f-11ea-9c99-1b7103d9c4b9.png)

T1L12 – Zahlensystem
Implementieren Sie ein Programm, das eine Zahl von einem Zahlensystem in ein anderes umwandelt.

T1L13 – Primfaktorenzerlegung
Implementieren Sie ein Programm das eine über Konsole eingegebene Zahl in ihre Primfaktoren zerlegt.

T1L14 – Gambler’s Ruin
Implementieren Sie ein Programm das Spielerwetten durch eine Monte Carlo Simulation evaluiert. Gehen Sie dazu wie folgt vor:
1. Über die Konsole werden Werte für das Startkapital, das gewünschte Zielkapital und die Anzahl der Spielwiederholungen eingegeben.
2. Ein Spiel startet beim Spielkapital. Mit jeder Spielwette wird entweder das Spielkapital um 1 erhöht (Gewinn) oder um 1 erniedrigt (Verlust). Um die Wette zu simulieren verwenden Sie eine Zufallszahl. Ist die erzeugte Zufallszahl < 0.5 haben Sie die Wette verloren ansonsten gewonnen. Das Spiel ist zu Ende, wenn entweder das Zielkapital erreicht wurde oder das gesamte Kapital verloren wurde.
3. Zählen Sie mit falls das Spiel gewonnen wurde.
4. Wiederholen Sie die Schritte 2 und 3 in der gewünschten Zahl der Spielwiederholungen.
5. Geben Sie auf der Konsole aus, wie viele Spiele gewonnen wurden.
Eine Zufallszahl können Sie erzeugen mit
Random rand = new Random();
double zz = rand.NextDouble();

T1L15 – Buchstabengenerator
Implementieren Sie ein Programm welches eine zufällige Anzahl von Großbuchstaben erzeugt und auf der Konsole ausgibt. Dabei werden nur Konsonanten verwendet, Vokale werden ignoriert. Sowohl die Anzahl der Buchstaben als auch die Buchstaben selbst werden durch einen Zufallszahlengenerator bestimmt. Als Zufallszahlengenerator verwenden Sie:
Random r = new Random();
int z = r.Next(20); // erzeugt eine Zufallszahl zwischen 0 und 19

T1L16 – Diamantzeichner
Implementieren Sie ein Programm das einen Diamanten zeichnet. Die Anzahl der * an der breitesten Stelle wird über Konsole eingegeben und muss eine ungerade Zahl sein.

![2020-06-11 16_34_48-Window](https://user-images.githubusercontent.com/61902639/84400751-b8e2ba00-ac02-11ea-9eb1-246ff3503d2e.png)


T1L17 – Temperaturstatistik
Lesen Sie von der Konsole beliebig viele positive ganzzahlige Temperaturwerte ein. Die Eingabe wird dem Wert 1000 beendet. Berechnen Sie den niedrigsten, höchsten und durchschnittlichen Temperaturwert.

T1L18 – Kubensumme
Schreiben Sie ein Programm, das alle dreistelligen Zahlen überprüft, ob sie gleich sind der Summe der Kuben ihrer Ziffern (z.B 153 = 1*1*1 + 5*5*5 + 3*3*3). Die gesuchten Zahlen sind 153, 370, 371, und 407.

#### Methoden

T1M1 – Guthaben berechnen
Implementieren Sie die Methode double EndkapitalBerechnen(int guthaben, int laufzeit, double zinssatz). Diese Methode berechnet den Wert des guthaben nach Ablauf von laufzeit Jahren unter Anwendung von zinssatz mit Berücksichtigung von Zinseszinsen und gibt das Resultat zurück.

T1M2 – Umfang und Fläche berechnen
Implementieren Sie zwei Methoden zur Berechnung von Umfang und Fläche eines Rechtecks bzw Quadrats.
1. int Umfang(int seiteA, int seiteB)
2. int Flaeche(int seiteA, int seiteB)

T1M3 – Eulersche Zahl
Berechnen Sie die Eulersche Zahl e und ex. Über Konsole wird der Wert für n und den Exponenten x eingegeben. Verwenden Sie folgende Formeln:

![2020-06-11 20_09_08-Window](https://user-images.githubusercontent.com/61902639/84423898-7d0a1d80-ac1f-11ea-8b10-166147483164.png)

Zur Berechnung von xi verwenden Sie Math.Pow(x, i). Implementieren Sie folgende Methoden:
• int Fakultaet(int i)
• double Euler(int n)
• double EulerX(int n, int x)

T1M4 – Perfekte Zahl
Implementieren Sie die Methode bool IsPerfekt(int n) welche überprüft ob n eine perfekte Zahl ist. Für eine perfekte Zahl gilt, dass sie gleich der Summe aller ihrer Teiler außer sich selbst ist. Schreiben Sie ein Programm, das die perfekten Zahlen im Bereich bis 10000 berechnet. Als Ergebnis sollten Sie folgende perfekte Zahlen bekommen.
Zahl 6 mit 1 + 2 + 3 = 6
Zahl 28 mit 1 + 2 + 4 + 7 + 14 = 28
Zahl 496 mit 1 + 2 + 4 + 8 + 16 + 31 + 62 + 124 + 248 = 496
Zahl 8128 mit 1 + 2 + 4 + 8 + 16 + 32 + 64 + 127 + 254 + 508 + 1016 + 2032 + 4064 = 8128

T1M5 – Zahlumdrehen
Implementieren Sie die Methode int Umdrehen(int n) welche die Ziffern der Zahl n umdreht und diese neue Zahl zurückliefert. D.h Umdrehen(1234) liefert als Ergebnis die Zahl 4321.

T1M6 – Mirpzahlen
Berechnen Sie die Mirpzahlen im Bereich von 1 bis 1000. Für eine Mirpzahl gilt:
1. Eine Mirpzahl ist eine Primzahl. Die Zahl umgekehrt gelesen ist auch eine Primzahl
2. Eine Mirpzahl ist keine Palindromzahl d.h. sie ist nicht gleich, wenn von vorne bzw von hinten gelesen (z.B 191 ist eine Palindromzahl)
Schreiben Sie folgende Methoden:
• int Umdrehen(int n) aus Beispiel T1M5
• bool IsPrimzahl(int n) liefert true, falls n eine Primzahl ist. Überprüfen Sie alle Zahlen zwischen 2 und Math.Sqrt(n), ob die Zahl ein Teiler von n ist
• bool IsMirp(n)
Zwischen 1 und 1000 gibt es folgende Mirpzahlen:
13 17 31 37 71 73 79 97 107 113 149 157 167 179 199 311 337 347 359 389 701 709
733 739 743 751 761 769 907 937 941 953 967 971 983 991

T1M7 – Primzahlenüberprüfung nach Wilson
Schreiben Sie die Methode boolean isPrime(int p) welche p überprüft, ob es sich um eine Primzahl handelt. Verwenden Sie dazu den Satz von Wilson 𝑝 𝑖𝑠𝑡 𝑃𝑟𝑖𝑚𝑧𝑎ℎ𝑙,𝑤𝑒𝑛𝑛 (𝑝−1)!+1 𝑑𝑢𝑟𝑐ℎ 𝑝 𝑡𝑒𝑖𝑙𝑏𝑎𝑟 𝑖𝑠𝑡
Dieser Satz wurde 1770 veröffentlicht, aber bereits 700 Jahre früher von Abu Ali al-Hasan ibn al-Haitham entdeckt.
Verwenden Sie als Datentyp für die Berechnung der Fakultät long und für p einen Wert kleiner oder gleich 20. Für die Berechnung der Fakultät verwenden Sie die Methode aus Beispiel T1M3.

#### Array

T1A1 – Sieb des Erathosthenes
Implementieren Sie das Sieb des Erathosthenes zur Berechnung der Primzahlen von 1 bis 1500. Gehen Sie dabei wie folgt vor: Aus der Liste der natürlichen Zahlen werden jene Zahlen gestrichen, die Vielfache der jeweils kleinsten noch nicht gestrichenen Zahl sind. Dadurch bleiben am Ende die Primzahlen übrig. Beachten Sie das Abbruchkriterium.

T1A2 – Eingabeparameter vertauschen
Implementieren Sie ein Programm, welches die command line Parameter in umgekehrter Reihenfolge wieder ausgibt.

T1A3 – Matrizen rechnen
Implementieren Sie ein Programm zur Addition und Multiplikation zweier m x n Matrizen. Beschränken Sie sich im Beispiel auf 3 x 3 Matrizen.
Addition zweier Matrizen: (𝑎11⋯𝑎1𝑛⋮⋱⋮𝑎𝑚1⋯𝑎𝑚𝑛)+ (𝑏11⋯𝑏1𝑛⋮⋱⋮𝑏𝑚1⋯𝑏𝑚𝑛)= (𝑐11⋯𝑐1𝑛⋮⋱⋮𝑐𝑚1⋯𝑐𝑚𝑛)
Wobei gilt: 𝑐𝑖𝑗 = 𝑎𝑖𝑗+ 𝑏𝑖𝑗 (1 ≤𝑖 ≤𝑚,1 ≤𝑗 ≤𝑛)
Multiplikation zweier Matrizen: (𝑎11⋯𝑎1𝑛⋮⋱⋮𝑎𝑚1⋯𝑎𝑚𝑛)∗(𝑏11⋯𝑏1𝑟⋮⋱⋮𝑏𝑛1⋯𝑏𝑛𝑟)= (𝑐11⋯𝑐1𝑟⋮⋱⋮𝑐𝑚1⋯𝑐𝑚𝑟)
Wobei gilt: 𝑐𝑖𝑗= 𝑎𝑖1𝑏1𝑗+ 𝑎𝑖2𝑏2𝑗+ …+𝑎𝑖𝑛𝑏𝑛𝑗 (1 ≤𝑖 ≤𝑚,1 ≤𝑗 ≤𝑟)
Implementieren Sie eine Methode void printMatrix(int[,] matrix) zur Ausgabe der Matrix auf der Konsole.

T1A4 – Fibonacci Zahlen
Berechnen Sie die ersten 30 Zahlen der Fibonacci Folge. 𝑓𝑛= 𝑓𝑛−1+ 𝑓𝑛−2 𝑓ü𝑟 𝑛 ≥2 𝑚𝑖𝑡 𝑓0=0 𝑢𝑛𝑑 𝑓1=1

T1A5 – Zinsen für Sparbuch
Berechnen Sie für ein Sparguthaben und einen festen Zinssatz (beide Werte werden über Konsole eingegeben) den Zuwachs des Sparguthabens über einen Zeitraum von 10 Jahren. Speichern Sie die Werte in einem Array und geben Sie dann alles auf der Konsole aus.

T1A6 – Geldbetrag
Stückeln Sie den über Konsole eingegebenen Geldbetrag in möglichst wenig Euro Scheine und Münzen. Unterstützen Sie auch Fliesskommabeträge und alle Euro Scheine und Münzen inkl der Cent Münzen.

T1A7 – Lotto
Implementieren Sie ein Programm, welches aus dem Bereich der Zahlen 1 bis 45 die 6 Lottozahlen und eine Zusatzzahl per Zufallszahlengenerator ermittelt. Stellen Sie sicher, dass dabei nur unterschiedliche Zahlen gezogen werden.
Eine Zufallszahl zwischen 1 und 45 können Sie wie folgt ermitteln:
Random rand = new Random();
int i = rand.Next(1, 46); // wiederholen Sie diese Zeile um eine neue Zufallszahl zu ermitteln

T1A8 – Pascalsches Dreieck
Implementieren Sie ein Programm zur Berechnung des Pascalschen Dreiecks. Jeder Eintrag ist die Summe der zwei darüberstehenden Einträge.
      1
     1 1
    1 2 1
   1 3 3 1
  1 4 6 4 1
1 5 10 10 5 1

T1A9 – Arithmetisches Mittel
Implementieren Sie ein Programm, welches maximal 10 Ganzzahlen von der Konsole einliest und in einem int[] speichert. Danach berechnen Sie das arithmetische Mittel der eingelesenen Zahlen.

T1A10 – Hadamard Matrix
Implementieren Sie ein Programm zur Berechnung der Hadamard Matrix H(N) für N = 2i. Verwenden Sie eine bool Matrix. Es gilt folgende Produktionsregel: 𝐻(1)=(𝑇) 𝐻(2)=(𝑇𝑇𝑇𝐹) 𝐻(4)=(𝑇𝑇𝑇𝑇𝑇𝐹𝑇𝐹𝑇𝑇𝐹𝐹𝑇𝐹𝐹𝑇)
Eine 2N-mal-2N Hadamard Matrix wird erzeugt, indem 4 Kopien der Hadamard n-mal-N Matrix in Form eines 2 mal 2 Rasters angelegt werden. In der rechten unteren N-mal-N Matrix werden die Werte invertiert.

T1A11 – Magisches Quadrat
Implementieren Sie ein Programm das ein Magisches Quadrat erzeugt. Die Anzahl der Zeilen und Spalten n wird über Konsole eingegeben und muss eine ungerade Zahl sein. In die Felder des Magischen Quadrates werden die Zahlen von 1 bis n2 eingesetzt. Allerdings muss die Summe aller Felder pro Zeile, pro Spalte und in den Diagonalen den gleichen Wert ergeben.
Ein einfacher Algorithmus dazu ist in aufsteigender Reihenfolge vorzugehen und die Zahl 1 in die mittlere Zelle der letzten Zeile zuzuordnen. Die nächste Ziffer wird dann der Zelle diagonal rechts unten zugeordnet. Sollte hier bereits eine Zahl zugeordnet sein, dann wird die Zelle in der unmittelbar darüber liegenden Zeile genommen. Für die Randfälle wird wrap-around verwendet.
4 9 2     11 18 25 2 9
3 5 7     10 12 19 21 3
8 1 6     4 6 13 20 22
          23 5 7 14 16
          17 24 1 8 15

T1A12 – Arrayelemente vertauschen
Implementieren sie die Methode int[] SwapCopy(int[] iArray) welche alle Elemente von iArray in verkehrter Reihenfolge in ein neues Array ablegt und dieses zurückgibt. Implementieren Sie zusätzlich die Methode void PrintArray(int[] iArray), welche die Elemente von iArray auf der Konsole ausgibt.

T1A13 – Multiplikationstafel
Implementieren Sie ein Programm zur Berechnung der Zahlen von 1*1 bis 12*12. Verwenden Sie für die Speicherung der Zahlen ein int[,] Array. Geben Sie die Tabelle auf der Konsole aus.

![2020-06-11 16_43_09-Window](https://user-images.githubusercontent.com/61902639/84400922-f0e9fd00-ac02-11ea-98df-30804a4ee51b.png)
