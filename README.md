# Fahrkartenautomat

## Anforderungen:
- [x] Abgabe per Repository
- [x] Saubere Trennung zwischen GUI & Logik
- [x] Umsetzung einer ansprechenden GUI
- [x] Bezahlung mit M�nzen
- [x] Bezahlung mit Scheinen
- [x] Erhalt von Wechselgeld
- [x] Auswahl der Berlin Einzeltickets
- [x] Kauf mehrerer Fahrscheine


## Benutzerhandbuch:
1. Startseite:
   - W�hlen Sie das gew�nschte Ticket aus, indem sie im zugeh�rigen Bereich auf "Einzelticket" klicken.
2. Verkauf:
   - im oberen Bereich wird die von Ihnen zuvor gew�hlte Konfiguration angezeigt.
   - Durch einen Klick auf "+Ticket" wird ein Ticket (gleicher Konfiguration) zur Verkaufsmenge hinzugef�gt.
   - Durch Klick auf "Abbrechen" k�nnen Sie den Kaufvorgang abbrechen und zur Auswahl zur�ckkehren.
   - Um zu bezahlen, w�hlen sie per Klick die Geldmittel aus dem unteren Feld aus.
   - Nach vollst�ndiger Bezahlung oder Abbruch erscheit das R�ckgeld, sowie das Ticket im Ausgabeschacht.
   - Durch Klick auf "Fertig" (bei Abbruch) oder "Ticket" (soll Ticketentnahme nach Kauf simulieren) schlie�en Sie den Kaufvorgang ab und kehren zum Ausgangsmen� zur�ck.

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
   - ***Insertcoins***: M�nzen, die der Kunde eingeworfen hat (falls Verkauf abgebrochen wird)
   - ***Outputcoins***: Ermittelte M�nzenanzahl jedes Geldwerts im Ausgabeschacht (Wechselgeld)
   - ***Priceshow(!)***: Anzeige des Preises der ausgew�hlten Tickets in Euro
   - ***ToPay***: Anzeige des Differenzwertes zwischen Preis und Geldeinwurf, der vom Kunden noch zu bezahlen ist; Zur Weiterverabeitung wird der Zahlenwert in _topayint gespeichert
   - ***FullyPaid***: boolscher Wert der Angibt ob gew�nschte Produkte vollkommen bezahlt sind
2. Konstruktoren:
   - ***Verkauf(Ticket)***: Der Verkauf wird anhand des Preises eines ausgew�hlten Tickets initalisiert; Der Geldeinwurf steht zu Beginn jedes Verkaufs auf Null
3. Methoden:
   - ***AusgebenWechselgeld()***: Errechnung der Anzahl der einzelnen Geldwerte, um Wechselgeld an Kunden zu geben
   - ***Bezahlen()***: Kunde wirft Geld ein und ver�ndert Werte f�r Geldeinwurf und ToPay
   - ***AbbrechenVorgang()***: Kunde entscheidet sich mitten im Verkauf zum Abbruch; eingegebene M�nzen werden wieder ausgegeben
   - ***EinwerfenM�nze()***: Die M�nze wird bis zum Ende des Kaufs in einer separierten Stelle vorgehalten; programmatisch wird die M�nzenanzahl je Geldwert bis zum Ende des Kaufs vermerkt

(!) : TwoWayBinding-Modus mit �berwachung von �nderungen
### Enumerationen:
- ***Areas2Price***: Preismatrix f�r die einzelnen Areale (Bei Preis�nderung seitens der BVG m�ssen hier die Preise aktualisiert werden) - Preise in Cent!
- ***Geldwerte***: Alle Geldwerte, die der BVG-Automat akzeptiert - Geldwerte in Cent!




