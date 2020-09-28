# Fahrkartenautomat

## Anforderungen:
- [x] Abgabe per Repository
- [x] Saubere Trennung zwischen GUI & Logik
- [x] Umsetzung einer ansprechenden GUI
- [x] Bezahlung mit Münzen
- [x] Bezahlung mit Scheinen
- [x] Erhalt von Wechselgeld
- [x] Auswahl der Berlin Einzeltickets
- [x] Kauf mehrerer Fahrscheine


## Benutzerhandbuch:
1. Startseite:
   - Wählen Sie das gewünschte Ticket aus, indem sie im zugehörigen Bereich auf "Einzelticket" klicken.
   Startseite.jpg
2. Verkauf:
   - im oberen Bereich wird die von Ihnen zuvor gewählte Konfiguration angezeigt.
   - Durch einen Klick auf "+Ticket" wird ein Ticket (gleicher Konfiguration) zur Verkaufsmenge hinzugefügt.
   - Durch Klick auf "Abbrechen" können Sie den Kaufvorgang abbrechen und zur Auswahl zurückkehren.
   - Um zu bezahlen, wählen sie per Klick die Geldmittel aus dem unteren Feld aus.
   - Nach vollständiger Bezahlung oder Abbruch erscheit das Rückgeld, sowie das Ticket im Ausgabeschacht.
   - Durch Klick auf "Fertig" (bei Abbruch) oder "Ticket" (soll Ticketentnahme nach Kauf simulieren) schließen Sie den Kaufvorgang ab und kehren zum Ausgangsmenü zurück.

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
   - ***Insertcoins***: Münzen, die der Kunde eingeworfen hat (falls Verkauf abgebrochen wird)
   - ***Outputcoins***: Ermittelte Münzenanzahl jedes Geldwerts im Ausgabeschacht (Wechselgeld)
   - ***Priceshow(!)***: Anzeige des Preises der ausgewählten Tickets in Euro
   - ***ToPay***: Anzeige des Differenzwertes zwischen Preis und Geldeinwurf, der vom Kunden noch zu bezahlen ist; Zur Weiterverabeitung wird der Zahlenwert in _topayint gespeichert
   - ***FullyPaid***: boolscher Wert der Angibt ob gewünschte Produkte vollkommen bezahlt sind
2. Konstruktoren:
   - ***Verkauf(Ticket)***: Der Verkauf wird anhand des Preises eines ausgewählten Tickets initalisiert; Der Geldeinwurf steht zu Beginn jedes Verkaufs auf Null
3. Methoden:
   - ***AusgebenWechselgeld()***: Errechnung der Anzahl der einzelnen Geldwerte, um Wechselgeld an Kunden zu geben
   - ***Bezahlen()***: Kunde wirft Geld ein und verändert Werte für Geldeinwurf und ToPay
   - ***AbbrechenVorgang()***: Kunde entscheidet sich mitten im Verkauf zum Abbruch; eingegebene Münzen werden wieder ausgegeben
   - ***EinwerfenMünze()***: Die Münze wird bis zum Ende des Kaufs in einer separierten Stelle vorgehalten; programmatisch wird die Münzenanzahl je Geldwert bis zum Ende des Kaufs vermerkt

(!) : TwoWayBinding-Modus mit Überwachung von Änderungen
### Enumerationen:
- ***Areas2Price***: Preismatrix für die einzelnen Areale (Bei Preisänderung seitens der BVG müssen hier die Preise aktualisiert werden) - Preise in Cent!
- ***Geldwerte***: Alle Geldwerte, die der BVG-Automat akzeptiert - Geldwerte in Cent!




