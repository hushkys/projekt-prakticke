# Instalace a konfigurace CaesarFTP Serveru

Tato příručka detailně popisuje proces nastavení FTP serveru pomocí aplikace CaesarFTP v prostředí Windows. Zaměřuje se na vytvoření bezpečné adresářové struktury, správu uživatelů a definování přístupových práv.

## Podrobný postup konfigurace

### 1. Příprava adresářové struktury
Před spuštěním samotného serveru je nutné připravit složky, ke kterým budou mít uživatelé přístup. Na lokálním disku C: vytvořte hlavní složku `FTP` a v ní dvě podsložky: `Upload` (pro nahrávání souborů) a `Download` (pro stahování souborů).

![Struktura složek](../../images/snimek-obrazovky-2025-09-29-091642.png)

> [!NOTE]
> Tato struktura bude sloužit jako kořenový adresář (root) pro vaše uživatele. Uživatelé uvidí pouze obsah těchto složek, nikoliv zbytek vašeho pevného disku.

### 2. Správa uživatelských účtů
Spusťte aplikaci CaesarFTP a v horním panelu klikněte na ikonu panáčka (User Management). Pro vytvoření nového uživatele klikněte na tlačítko "Add User" v levém dolním rohu. Zadejte uživatelské jméno a silné heslo.

![Správa uživatelů](../../images/snimek-obrazovky-2025-09-29-091728.png)

> [!IMPORTANT]
> Přístupové údaje si pečlivě uschovejte, budete je potřebovat pro konfiguraci FTP klienta (např. Total Commander).

### 3. Definice přístupových práv k souborům
Po vytvoření uživatele přepněte na záložku "File Access Rights". Zde musíte explicitně určit, které složky smí uživatel používat. V dolní části zaškrtněte požadovaná oprávnění: Read, Write, Append, SubDir Access a List. Následně přetáhněte složky `Upload` a `Download` do hlavního pole.

![Přístupová práva](../../images/snimek-obrazovky-2025-09-29-091754.png)

> [!WARNING]
> Bez přidělení práv a přetažení složek se uživatel sice přihlásí, ale uvidí prázdný seznam adresářů.

### 4. Systémové nastavení a automatické spouštění
V záložce "Settings" otevřete "Edit Server Options". Zde doporučujeme zaškrtnout volbu "Launch on system start", aby byl FTP server dostupný ihned po startu operačního systému.

### 5. Konfigurace firewallu
FTP protokol standardně využívá TCP port 21 pro řídicí spojení. Ujistěte se, že Windows Firewall nebo váš antivirus tento port neblokuje.

> [!IMPORTANT]
> Přidejte výjimku pro aplikaci `CaesarFTP.exe` nebo povolte příchozí provoz na portu **21/TCP**.

## Troubleshooting — Řešení potíží

#### Klient se nemůže připojit — hlášení "Connection refused" nebo vypršení limitu.
> [!NOTE]
> Zkontrolujte, zda je CaesarFTP server ve stavu "Running". Ověřte, zda se nepřipojujete na špatnou IP adresu. Pokud testujete lokálně, použijte adresu `127.0.0.1`.

#### Uživatel vidí po přihlášení prázdný adresář.
> [!WARNING]
> Pravděpodobně jste zapomněli přetáhnout složky do pole "File Access Rights" v nastavení uživatele. Opravte nastavení a restartujte server.

[Zpět na přehled](../../README.md)


[<kbd> ⮞ Zpět na úvodní stránku </kbd>](../../README.md)
