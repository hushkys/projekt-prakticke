# Total Commander jako FTP klient

Tento návod vás provede procesem navázání spojení s FTP serverem pomocí správce souborů Total Commander, konfigurací profilu a základními operacemi se soubory.

## Podrobný postup konfigurace

### 1. Vytvoření nového FTP připojení
Spusťte Total Commander a v horním panelu zvolte menu **"Síť"** → **"Protokol FTP - Připojit"** (nebo použijte klávesovou zkratku `Ctrl+F`). Otevře se dialogové okno pro správu FTP připojení. Klikněte na tlačítko **"Nové připojení"**.

![Nové připojení](../../images/snimek-obrazovky-2025-10-13-100434.png)

### 2. Konfigurace parametrů profilu
V dialogovém okně vyplňte následující údaje pro úspěšné spojení:
- **Název relace:** Libovolný název pro identifikaci (např. `MujServer`).
- **Hostitel (port):** IP adresa serveru (např. `192.168.1.50`) nebo `localhost`, pokud je server na stejném stroji. Port ponechte výchozí `21`.
- **Jméno uživatele a Heslo:** Údaje vytvořené v nastavení FTP serveru.

![Konfigurace relace](../../images/snimek-obrazovky-2025-10-13-100457.png)

> [!NOTE]
> Pokud váš server vyžaduje šifrování, nezapomeňte zaškrtnout volbu **SSL/TLS**. Pro běžné laboratorní testování postačuje nešifrované spojení.

### 3. Navázání spojení se serverem
Po uložení profilu vyberte nově vytvořené připojení v seznamu a klikněte na **"Připojit"**. Po úspěšném přihlášení se v jednom z panelů zobrazí obsah FTP serveru.

![Stav připojení](../../images/snimek-obrazovky-2025-10-13-100509.png)

> [!WARNING]
> Pokud se spojení nepodaří, zkontrolujte, zda na serveru neblokuje komunikaci firewall a zda jsou přihlašovací údaje zadány správně (pozor na velká/malá písmena).

### 4. Práce se soubory (Nahrávání a stahování)
Přenos souborů probíhá jednoduše přetažením z jednoho panelu do druhého.
- **Klávesa F5:** Kopírování souboru z lokálního počítače na server (Upload) nebo naopak (Download).
- **Klávesa F6:** Přesun souboru (vyjmutí a vložení).
- **Klávesa F8:** Smazání vybraného souboru na serveru.

![Přenos souborů](../../images/snimek-obrazovky-2025-10-13-100532.png)

### 5. Sledování průběhu přenosu
Během kopírování větších souborů Total Commander zobrazuje dialogové okno s ukazatelem průběhu v procentech, aktuální přenosovou rychlostí a odhadovaným časem dokončení.

![Průběh přenosu](../../images/snimek-obrazovky-2025-10-13-110353.png)

> [!TIP]
> Pro zrychlení práce s FTP připojením doporučujeme používat klávesovou zkratku `Ctrl+F` pro otevření seznamu spojení a `Ctrl+Shift+F` pro rychlé odpojení od serveru.

[Zpět na přehled](../../README.md)


[<kbd> ⮞ Zpět na úvodní stránku </kbd>](../../README.md)
