# CS-FileEncryptor

![UI Screenshot](path-to-screenshot.png) <!-- Replace with actual path to the screenshot -->

## Über das Programm
Der **CS-FileEncryptor** ist ein WPF-basiertes Tool zum sicheren Verschlüsseln und Entschlüsseln von Dateien. Mit einer benutzerfreundlichen Oberfläche und einer robusten Implementierung bietet das Programm:

- **AES-Verschlüsselung** zur sicheren Speicherung von Dateien.
- Einfaches Dateiauswahl-Feature durch die grafische Benutzeroberfläche (kein manueller Pfad erforderlich).
- Schutz vor falscher Passwort-Eingabe: Nach 5 erfolglosen Entschlüsselungsversuchen wird die verschlüsselte Datei unwiderruflich gelöscht.
- Fehler- und Erfolgsbenachrichtigungen, damit der Nutzer genau weiß, was passiert ist.

> **Hinweis:** Das Programm erfordert ein 16-stelliges Passwort, das zur Entschlüsselung unbedingt aufbewahrt werden sollte.

---

## Features
- **Verschlüsselung**: Dateien können sicher mit AES verschlüsselt werden.
- **Entschlüsselung**: Nur mit dem korrekten Passwort kann die Datei wiederhergestellt werden.
- **Intuitive Benutzeroberfläche**: Buttons mit Animationen für eine bessere Nutzererfahrung.
- **Fehlertoleranz**: Zeigt präzise Fehler und vermeidet Abstürze.

---

## Installation
1. Gehe zu den [Releases](#).
2. Lade die neueste `.exe`-Datei herunter.
3. Starte das Programm direkt, keine Installation erforderlich.

---

## Funktionsweise (Code-Übersicht)

### Verschlüsselung
Die Methode `EncryptFile` verwendet den AES-Algorithmus, um eine Datei sicher zu verschlüsseln:
- **Schlüssel**: Die ersten 16 Zeichen des eingegebenen Passworts.
- **IV**: Initial Vector wird standardmäßig auf 16 Nullen gesetzt.
- Das Original wird nach erfolgreicher Verschlüsselung gelöscht.

### Entschlüsselung
Die Methode `DecryptFile` entschlüsselt die Datei mit dem gleichen Passwort:
- **Versuchsbeschränkung**: Nach 5 fehlgeschlagenen Versuchen wird die Datei gelöscht.
- **Fehlermeldungen**: Informiert den Nutzer bei einem falschen Passwort.

### Wichtige Komponenten
- **Dateiauswahl**: `PromptFilePath` öffnet einen Dialog zur einfachen Auswahl der Datei.
- **Passworteingabe**: `PromptPassword` fordert den Benutzer zur Eingabe des Passworts auf.
- **Benachrichtigungen**: `ShowSuccessMessage` und `ShowErrorWindow` zeigen dem Nutzer den Status der Aktion an.

---

## Anforderungen
Keine besonderen Anforderungen nötig. Einfach herunterladen und starten.

---

## Lizenz
License free. Dieses Programm kann frei verwendet werden.
