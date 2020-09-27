# Fahrkartenautomat

## Anforderungen:
- [ ] Abgabe per Repository
- [ ] Saubere Trennung zwischen GUI & Logik
- [ ] Umsetzung einer ansprechenden GUI
- [ ] Bezahlung mit M�nzen
- [ ] Bezahlung mit Scheinen
- [ ] Erhalt von Wechselgeld
- [ ] Auswahl der Berlin Einzeltickets
- [ ] Kauf mehrerer Fahrscheine


- Wenn genug Geld eingeworfen wird Ticketkauf beendet
- Wechselgeld in Euro-W�hrungseinheiten umrechnen
- Wechselgeld Ausgabe
- Ticket Ausgabe
- Mehrere Tickets kaufen k�nnen

## �bersicht Aufbau:

### Ticket Klasse:
Beinhaltet alle Eigenschaften, die ein Ticket haben kann

1. Felder/Properties:
   - ***Areal***:
   - ***Preis***:  Enum Areas2Price
2. Methoden:
   - ***Print()***: Definition des Drucklayouts f�r Ausgabe an Kunden

### Verkauf Klasse:
Beinhaltet alle Eigenschaften, die ein Verkaufsvorgang haben kann

1. Felder/Properties:
   - ***Amount***: Menge der Tickets (es k�nnen nur mehrere *gleiche* Tickets in einem Verkaufsvorgang gekauft werden)
   - ***Ticket***: der Ticket-Typ, den der Kunde ausgew�hlt hat (Preisberechnung erfolgt auf Grundlage des Basispreises)
   - ***Moneyin***:  Geld, dass der Kunde schon in den Automaten geworfen hat, um zu bezahlen
   - ***InsertCoins: M�nzen, die der Kunde eingeworfen hat (falls Verkauf abgebrochen wird)
   - ***Priceshow***: Anzeige des Preises der ausgew�hlten Tickets in Euro
   - ***ToPay***: Anzeige des Differenzwertes zwischen Preis und Geldeinwurf, der vom Kunden noch zu bezahlen ist
2. Methoden:
   - ***AusgebenWechselgeld()***: Errechnung der Anzahl der einzelnen Geldwerte, um Wechselgeld an Kunden zu geben
   - ***Bezahlen()***: Kunde wirft Geld ein und ver�ndert Werte f�r Geldeinwurf und ToPay
   - ***AbbrechenVerkauf()***: Kunde entscheidet sich mitten im Verkauf zum Abbruch

### Enumerationen:
- ***Areas2Price***: Preismatrix f�r die einzelnen Areale (Bei Preis�nderung seitens der BVG m�ssen hier die Preise aktualisiert werden) - Preise in Cent!
- ***Geldwerte***: Alle Geldwerte, die der BVG-Automat akzeptiert - Geldwerte in Cent!




