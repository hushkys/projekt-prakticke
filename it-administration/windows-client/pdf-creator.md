# Instalace a sdílení PDF Creatoru

Tento návod popisuje, jak nainstalovat PDF Creator (nástroj tvořící virtuální tiskárnu) v síťovém prostředí, abyste z jednoho klientského počítače mohli "tisknout" PDF soubory přes sdílenou tiskárnu připojenou k druhému počítači.

## 1. Instalace PDF Creatoru na KLIENT1 (Serverová část)

Počítač KLIENT1 bude sloužit jako tiskový server – na něm vytvoříme virtuální PDF tiskárnu.

1. Spusťte instalační program PDF Creatoru.
2. V prvních krocích průvodce zaškrtněte položku **Expert settings** (Expertní nastavení).
3. V dalším kroku zvolte typ instalace **Server installation**.
4. Dokončete standardně celou instalaci.
5. Tímto se ve Windows vytvořila nová virtuální tiskárna, která dokáže tisknout PDF dokumenty.

## 2. Sdílení tiskárny z KLIENT1

Nyní musíme virtuální tiskárnu nasdílet do vnitřní sítě, aby ji viděl KLIENT2.

1. Přejděte do **Ovládacích panelů** a otevřete **Zařízení a tiskárny**.
2. Klikněte pravým tlačítkem myši na nově vzniklou tiskárnu (bude se jmenovat `PDFCreator`) a zvolte **Vlastnosti tiskárny** (pozor, nikoliv pouze "Vlastnosti", ale "Vlastnosti tiskárny").
3. Přepněte se na kartu **Sdílení** a zaškrtněte políčko **Sdílet tuto tiskárnu**.
4. Název sdílené položky můžete ponechat `PDFCreator`. Potvrďte tlačítkem **OK**.

## 3. Instalace a připojení na KLIENT2

Aby mohl druhý klientský stroj tisknout na nasdílenou PDF tiskárnu, musíme k ní přidat přístup a instalovat základní ovladač.

1. Na KLIENT2 spusťte stejný instalační program z ISO souboru nebo z disku.
2. Nyní zvolte pouze **Standard installation** (Standardní instalace).
3. Jakmile je instalace dokončena, otevřete **Průzkumníka souborů (Tento počítač)**.
4. Do adresního řádku nahoře napište IP adresu prvního klienta ve formátu `\\192.168.0.1` a stiskněte Enter.
5. Ve složce, která se otevře, byste měli vidět nasdílenou tiskárnu `PDFCreator`.
6. Klikněte na ni pravým tlačítkem a zvolte **Připojit** (Connect). Windows automaticky stáhnou a nainstalují ovladače z prvního klienta.

Od této chvíle může uživatel na PC KLIENT2 tisknout jakékoliv dokumenty a jako tiskárnu v nabídce vybrat síťový PDF Creator z prvního počítače.

---
[<kbd> ⮞ Zpět na úvodní stránku </kbd>](../../README.md)