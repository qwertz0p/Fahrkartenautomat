# Fahrkartenautomat

## Anforderungen:
- [x] Abgabe per Repository
- [x] Saubere Trennung zwischen GUI & Logik
- [x] Umsetzung einer ansprechenden GUI
- [x] Bezahlung mit Münzen
- [x] Bezahlung mit Scheinen
- [ ] Erhalt von Wechselgeld
- [x] Auswahl der Berlin Einzeltickets
- [x] Kauf mehrerer Fahrscheine

## MyTasks - Löschen wenn fertig!!!
- Wenn genug Geld eingeworfen wird Ticketkauf beendet
- Wechselgeld in Euro-Währungseinheiten umrechnen
- Wechselgeld Ausgabe
- Ticket Ausgabe
- FensterIcon anpassen
- Button Template
- Inserted Coins implementieren
- Nach Finish dump löschen

## Benutzerhandbuch:

## Übersicht Aufbau:

### Klassen:
#### Ticket:
Beinhaltet alle Eigenschaften, die ein Ticket haben kann

1. Felder/Properties:
   - ***Area***:
   - ***Preis***:  Enum Areas2Price
2. Methoden:
   - ***Print()***: Definition des Drucklayouts für Ausgabe an Kunden

#### Verkauf:
Beinhaltet alle Eigenschaften, die ein Verkaufsvorgang haben kann

1. Felder/Properties:
   - ***Amount(!)***: Menge der Tickets (es können nur mehrere *gleiche* Tickets in einem Verkaufsvorgang gekauft werden)
   - ***Ticket***: der Ticket-Typ, den der Kunde ausgewählt hat (Preisberechnung erfolgt auf Grundlage des Basispreises)
   - ***Moneyin(!)***:  Geld, dass der Kunde schon in den Automaten geworfen hat, um zu bezahlen
   - ***InsertCoins***: Münzen, die der Kunde eingeworfen hat (falls Verkauf abgebrochen wird)
   - ***Priceshow(!)***: Anzeige des Preises der ausgewählten Tickets in Euro
   - ***ToPay***: Anzeige des Differenzwertes zwischen Preis und Geldeinwurf, der vom Kunden noch zu bezahlen ist
   - ***FullyPaid***: boolscher Wert der Angibt ob gewünschte Produkte vollkommen bezahlt sind
2. Konstruktoren:
   - ***Verkauf(Ticket)***: Der Verkauf wird anhand des Preises eines ausgewählten Tickets initalisiert; Der Geldeinwurf steht zu Beginn jedes Verkaufs auf Null
3. Methoden:
   - ***AusgebenWechselgeld()***: Errechnung der Anzahl der einzelnen Geldwerte, um Wechselgeld an Kunden zu geben
   - ***Bezahlen()***: Kunde wirft Geld ein und verändert Werte für Geldeinwurf und ToPay
   - ***AbbrechenVerkauf()***: Kunde entscheidet sich mitten im Verkauf zum Abbruch

(!) : TwoWayBinding-Modus mit Überwachung von Änderungen
### Enumerationen:
- ***Areas2Price***: Preismatrix für die einzelnen Areale (Bei Preisänderung seitens der BVG müssen hier die Preise aktualisiert werden) - Preise in Cent!
- ***Geldwerte***: Alle Geldwerte, die der BVG-Automat akzeptiert - Geldwerte in Cent!




