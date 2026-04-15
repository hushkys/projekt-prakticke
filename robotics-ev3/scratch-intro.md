# Scratch – Úvod do programování robotů

> 💡 **Tip pro Robotiku EV3:** Než začnete testovat složitější programy na podlaze (např. s gyroskopem), zkontrolujte baterii v kostce EV3. Slabá baterie naprosto běžně způsobuje zdánlivě náhodné odpojování senzorů a nebo celkově slabý tah motorů.


Základy programování v prostředí Scratch pro ovládání virtuálního robota. Ideální první krok před prací s fyzickým hardwarem.

## Podrobný postup

### 1. Nastavení prostředí
Otevřete Scratch na adrese scratch.mit.edu nebo si nainstalujte verzi Scratch Desktop. Vytvořte nový projekt pomocí tlačítka "Tvořit".

> [!TIP]
> Scratch běží v prohlížeči bez nutnosti instalace. Scratch Desktop je vhodný pro offline použití bez internetu.

### 2. Seznámení s rozhraním
Prozkoumejte rozhraní: bloky kódu (kategorie) jsou vlevo, pracovní plocha uprostřed a scéna s postavami (Sprites) vpravo.

### 3. Váš první program
Vytvořte svůj první skript: přetáhněte blok "Po kliknutí na zelenou vlajku" → "Dopředu o 10 kroků" → "Čekej 1 sekundu" → "Otoč se o 90 stupňů".

> [!IMPORTANT]
> Bloky do sebe zapadají jako skládačka – spojit lze pouze tvary, které k sobě pasují. Scratch vás tak vede k logicky správnému zápisu programu.

### 4. Smyčky a obrazce
Přidejte cyklus: obalte bloky pohybu blokem "Opakuj 4krát" – postava na scéně tak opíše čtverec.

```javascript
// Pseudokód pro vykreslení čtverce:
// Opakuj 4krát:
//   Jdi 100 kroků
//   Otoč se o 90 stupňů
```

### 5. Podmíněné příkazy
Přidání logiky: "Když narazíš na okraj, odraz se". Tím zajistíte, že se postava při dosažení hranice scény otočí a neskryje se mimo obraz.

### 6. Připojení hardwaru (LEGO)
Propojte Scratch s LEGO WeDo 2.0 nebo LEGO BOOST: Přidejte rozšíření (ikona puzzle vlevo dole). Připojte hardware přes Bluetooth.

> [!TIP]
> Pro připojení LEGO hardwaru přes Bluetooth musí být v počítači nainstalována a spuštěna aplikace Scratch Link.

### 7. Ovládání motorů
Ovládejte fyzický motor pomocí bloků Scratch: "Nastav výkon motoru na 75 %" → "Zapni motor na 2 sekundy" → "Zastav motor".

## Řešení problémů (FAQ)

#### Scratch se nechce připojit k LEGO hardwaru přes Bluetooth.
> **Řešení:** Zkontrolujte, zda běží Scratch Link. Ujistěte se, že je Bluetooth v počítači aktivní. LEGO kostka musí být v režimu párování (blikající modré světlo).

#### Skript se spustí, ale na scéně se nic neděje.
> **Řešení:** Ujistěte se, že máte vybranou správnou postavu (Sprite). Bloky kódu musí být připojeny k bloku se zelenou vlajkou (nebo jinému spouštěči), aby se vykonaly.

[Zpět na přehled](../README.md)


[<kbd> ⮞ Zpět na úvodní stránku </kbd>](../README.md)
