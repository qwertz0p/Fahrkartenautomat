# Fahrkartenautomat

## Anforderungen:
- [ ] Abgabe per Repository
- [ ] Saubere Trennung zwischen GUI & Logik
- [ ] Umsetzung einer ansprechenden GUI
- [ ] Bezahlung mit Münzen
- [ ] Bezahlung mit Scheinen
- [ ] Erhalt von Wechselgeld
- [ ] Auswahl der Berlin Einzeltickets
- [ ] Kauf mehrerer Fahrscheine


- Wenn genug Geld eingeworfen wird Ticketkauf beendet
- Wechselgeld in Euro-Währungseinheiten umrechnen
- Wechselgeld Ausgabe
- Ticket Ausgabe
- Mehrere Tickets kaufen können

## Übersicht Aufbau:

### Ticket Klasse:
Beinhaltet alle Eigenschaften, die ein Ticket haben kann

1. Felder/Properties:
   - ***Areal***:
   - ***Preis***:  Enum Areas2Price
2. Methoden:
   - ***Print()***: Definition des Drucklayouts für Ausgabe an Kunden

### Verkauf Klasse:
Beinhaltet alle Eigenschaften, die ein Verkaufsvorgang haben kann

1. Felder/Properties:
   - ***Amount***: Menge der Tickets (es können nur mehrere *gleiche* Tickets in einem Verkaufsvorgang gekauft werden)
   - ***Ticket***: der Ticket-Typ, den der Kunde ausgewählt hat (Preisberechnung erfolgt auf Grundlage des Basispreises)
   - ***Moneyin***:  Geld, dass der Kunde schon in den Automaten geworfen hat, um zu bezahlen
   - ***InsertCoins: Münzen, die der Kunde eingeworfen hat (falls Verkauf abgebrochen wird)
   - ***Priceshow***: Anzeige des Preises der ausgewählten Tickets in Euro
   - ***ToPay***: Anzeige des Differenzwertes zwischen Preis und Geldeinwurf, der vom Kunden noch zu bezahlen ist
2. Methoden:
   - ***AusgebenWechselgeld()***: Errechnung der Anzahl der einzelnen Geldwerte, um Wechselgeld an Kunden zu geben
   - ***Bezahlen()***: Kunde wirft Geld ein und verändert Werte für Geldeinwurf und ToPay
   - ***AbbrechenVerkauf()***: Kunde entscheidet sich mitten im Verkauf zum Abbruch

### Enumerationen:
- ***Areas2Price***: Preismatrix für die einzelnen Areale (Bei Preisänderung seitens der BVG müssen hier die Preise aktualisiert werden) - Preise in Cent!
- ***Geldwerte***: Alle Geldwerte, die der BVG-Automat akzeptiert - Geldwerte in Cent!




