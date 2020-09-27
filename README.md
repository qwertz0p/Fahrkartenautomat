# Fahrkartenautomat

## Anforderungen:
- [x] Abgabe per Repository
- [x] Saubere Trennung zwischen GUI & Logik
- [x] Umsetzung einer ansprechenden GUI
- [x] Bezahlung mit M�nzen
- [x] Bezahlung mit Scheinen
- [ ] Erhalt von Wechselgeld
- [x] Auswahl der Berlin Einzeltickets
- [x] Kauf mehrerer Fahrscheine

## MyTasks - L�schen wenn fertig!!!
- Wenn genug Geld eingeworfen wird Ticketkauf beendet
- Wechselgeld in Euro-W�hrungseinheiten umrechnen
- Wechselgeld Ausgabe
- Ticket Ausgabe
- FensterIcon anpassen
- Button Template
- Inserted Coins implementieren
- Nach Finish dump l�schen

## Benutzerhandbuch:

## �bersicht Aufbau:

### Klassen:
#### Ticket:
Beinhaltet alle Eigenschaften, die ein Ticket haben kann

1. Felder/Properties:
   - ***Area***:
   - ***Preis***:  Enum Areas2Price
2. Methoden:
   - ***Print()***: Definition des Drucklayouts f�r Ausgabe an Kunden

#### Verkauf:
Beinhaltet alle Eigenschaften, die ein Verkaufsvorgang haben kann

1. Felder/Properties:
   - ***Amount(!)***: Menge der Tickets (es k�nnen nur mehrere *gleiche* Tickets in einem Verkaufsvorgang gekauft werden)
   - ***Ticket***: der Ticket-Typ, den der Kunde ausgew�hlt hat (Preisberechnung erfolgt auf Grundlage des Basispreises)
   - ***Moneyin(!)***:  Geld, dass der Kunde schon in den Automaten geworfen hat, um zu bezahlen
   - ***InsertCoins***: M�nzen, die der Kunde eingeworfen hat (falls Verkauf abgebrochen wird)
   - ***Priceshow(!)***: Anzeige des Preises der ausgew�hlten Tickets in Euro
   - ***ToPay***: Anzeige des Differenzwertes zwischen Preis und Geldeinwurf, der vom Kunden noch zu bezahlen ist
   - ***FullyPaid***: boolscher Wert der Angibt ob gew�nschte Produkte vollkommen bezahlt sind
2. Konstruktoren:
   - ***Verkauf(Ticket)***: Der Verkauf wird anhand des Preises eines ausgew�hlten Tickets initalisiert; Der Geldeinwurf steht zu Beginn jedes Verkaufs auf Null
3. Methoden:
   - ***AusgebenWechselgeld()***: Errechnung der Anzahl der einzelnen Geldwerte, um Wechselgeld an Kunden zu geben
   - ***Bezahlen()***: Kunde wirft Geld ein und ver�ndert Werte f�r Geldeinwurf und ToPay
   - ***AbbrechenVerkauf()***: Kunde entscheidet sich mitten im Verkauf zum Abbruch

(!) : TwoWayBinding-Modus mit �berwachung von �nderungen
### Enumerationen:
- ***Areas2Price***: Preismatrix f�r die einzelnen Areale (Bei Preis�nderung seitens der BVG m�ssen hier die Preise aktualisiert werden) - Preise in Cent!
- ***Geldwerte***: Alle Geldwerte, die der BVG-Automat akzeptiert - Geldwerte in Cent!




