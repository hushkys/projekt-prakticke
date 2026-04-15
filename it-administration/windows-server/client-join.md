# Připojení klientské stanice do domény Active Directory

Tento dokument podrobně popisuje proces integrace klientského počítače se systémem Windows do doménového prostředí. Zahrnuje konfiguraci DNS, samotné připojení k doméně a první přihlášení doménovým účtem.

## Podrobný postup

### 1. Konfigurace DNS na klientské stanici
Pro úspěšné vyhledání doménového řadiče musí mít klient správně nastavenou adresu DNS serveru. Tato adresa musí odpovídat IP adrese vašeho doménového řadiče (např. 192.168.1.1).

![Nastavení DNS](../../images/klient/instalace-klient1.png)

> [!IMPORTANT]
> DNS server na klientovi NESMÍ být nastaven na automatiku (DHCP) nebo na veřejné servery jako 8.8.8.8. Bez nasměrování na doménový řadič nebude možné doménu v síti lokalizovat.

Ověřte konektivitu k serveru pomocí příkazu ping:
```powershell
ping [IP_ADRESA_SERVERU]
```

### 2. Změna příslušnosti k doméně
Otevřete **Vlastnosti systému** (System Properties) – lze použít klávesovou zkratku `Win + Pause/Break` nebo vyhledat "Tento počítač", kliknout pravým tlačítkem a zvolit Vlastnosti.

![Změna nastavení](../../images/klient/instalace-klient2.png)

1. Klikněte na **Change settings** (Změnit nastavení).
2. Na kartě **Computer Name** klikněte na **Change...** (Změnit).
3. V sekci "Member of" přepněte z Workgroup na **Domain**.
4. Zadejte plný název vaší domény (např. `skola.local`).

![Zadání domény](../../images/klient/instalace-klient3.png)

### 3. Autorizace připojení
Po potvrzení názvu domény se zobrazí výzva k zadání přihlašovacích údajů. Zadejte jméno a heslo uživatele, který má právo připojovat počítače do domény (typicky doménový administrátor).

![Přihlášení administrátora](../../images/klient/instalace-klient4.png)

> [!NOTE]
> Pokud se zobrazí uvítací zpráva "Welcome to the [domain] domain", bylo připojení úspěšné.

### 4. Restartování systému
Po úspěšném připojení je nezbytný restart počítače, aby se změny projevily a aby se klientská stanice mohla plně integrovat do doménové struktury.

![Restart stanice](../../images/klient/instalace-klient5.png)

### 5. První přihlášení doménovým účtem
Na přihlašovací obrazovce zvolte možnost **Other user** (Jiný uživatel). Do pole uživatelského jména zadejte název domény a jméno uživatele ve formátu `DOMÉNA\uživatel` (např. `SKOLA\jan.novak`).

![Přihlášení uživatele](../../images/klient/instalace-klient6.png)

### 6. Verifikace v Active Directory
Na serveru v konzoli **Active Directory Users and Computers** (ADUC) ověřte, že se nový počítač objevil v kontejneru **Computers**.

![Ověření v AD](../../images/klient/instalace-klient8.png)

Na klientské stanici můžete ověřit aktuální doménu příkazem:
```powershell
whoami
echo %USERDOMAIN%
```

## Řešení potíží (Troubleshooting)

### Problém: Doménový řadič nebyl nalezen (Active Directory Domain Controller could not be contacted)
> [!IMPORTANT]
> Nejčastější příčinou je špatné nastavení DNS. Spusťte příkaz `ipconfig /all` a ujistěte se, že položka "DNS Servers" obsahuje pouze IP adresu vašeho serveru. Také zkontrolujte, zda jsou obě VM v rámci VirtualBoxu ve stejné vnitřní síti (Internal Network).

### Problém: Chyba při zadávání přihlašovacích údajů
> [!WARNING]
> Ujistěte se, že používáte správný formát jména (např. `Administrator`). Pokud se pokoušíte o připojení a účet je zablokován nebo má vypršené heslo, proces selže.

---
[Zpět na přehled](../../README.md)


[<kbd> ⮞ Zpět na úvodní stránku </kbd>](../../README.md)
