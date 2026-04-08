# IT Administrace, Programování a Robotika - Znalostní báze

Komplexní sbírka technických návodů a tutoriálů pro IT administrátory, vývojáře a nadšence do robotiky. Tento repozitář pokrývá Windows Server, Linux, síťové služby, programování v C# a Java a projekty LEGO MINDSTORMS EV3.

---

## Obsah

- [Správa Windows Serveru](#správa-windows-serveru)
- [Windows - Klientské systémy](#windows---klientské-systémy)
- [Linux (Ubuntu Server)](#linux-ubuntu-server)
- [Síťové služby](#síťové-služby)
- [Programování a OOP](#programování-a-oop)
- [Robotika (LEGO EV3)](#robotika-lego-ev3)

---

## Správa Windows Serveru

Kompletní návody pro nastavení a správu Windows Server prostředí.

| Téma | Popis | Odkaz |
| :--- | :--- | :---: |
| **Nastavení VM** | Konfigurace VirtualBoxu a vnitřních sítí | [Návod](./it-administration/windows-server/vm-setup.md) |
| **Instalace OS** | Podrobný postup instalace Windows Server 2019/2022 | [Návod](./it-administration/windows-server/install-os.md) |
| **Doménový řadič** | Povýšení na DC a konfigurace AD DS | [Návod](./it-administration/windows-server/domain-controller.md) |
| **Uživatelé a OU** | Správa uživatelských účtů a organizační struktury | [Návod](./it-administration/windows-server/users-groups-ou.md) |
| **DHCP Server** | Konfigurace automatického přidělování IP adres | [Návod](./it-administration/windows-server/dhcp-server.md) |
| **Sdílení souborů** | Nastavení NTFS a Share oprávnění | [Návod](./it-administration/windows-server/file-sharing.md) |
| **Připojení klienta** | Připojení pracovní stanice Windows do domény | [Návod](./it-administration/windows-server/client-join.md) |
| **Skupinové politiky** | Restrikce uživatelů a automatické mapování disků | [Návod](./it-administration/windows-server/group-policy.md) |
| **Tiskový server** | Instalace a nasazení síťových tiskáren | [Návod](./it-administration/windows-server/print-server.md) |
| **Klonování VM** | Rychlé nasazení virtuálních strojů pomocí klonů | [Návod](./it-administration/windows-server/vm-cloning.md) |

### Doporučené externí zdroje
- [Microsoft Docs: Windows Server](https://docs.microsoft.com/en-us/windows-server/) - Oficiální dokumentace
- [Server Fault](https://serverfault.com/questions/tagged/windows-server) - Q&A pro administrátory
- [Reddit r/sysadmin](https://www.reddit.com/r/sysadmin/) - Komunita systémových administrátorů

---

## Windows - Klientské systémy

Návody pro konfiguraci Windows klientských stanic a P2P sítí.

| Téma | Popis | Odkaz |
| :--- | :--- | :---: |
| **P2P propojení** | Peer-to-peer síť mezi VM, sdílení souborů a tiskáren | [Návod](./it-administration/windows-client/p2p-networking.md) |

### Doporučené externí zdroje
- [Instructables: VirtualBox Guide](https://www.instructables.com/GuideHow-to-Install-Windows-10-on-Oracle-VM-Virtua/) - Instalace Windows ve VirtualBoxu
- [Kubuntu Focus: VirtualBox](https://kfocus.org/wf/vbox.html) - Profesionální návod
- [Stack Overflow: VirtualBox Networking](https://stackoverflow.com/questions/21069908/how-to-create-a-connection-between-two-virtual-machines-in-virtualbox) - Propojení VM

---

## Linux (Ubuntu Server)

Základy administrace Linux serverů a webových služeb.

| Téma | Popis | Odkaz |
| :--- | :--- | :---: |
| **Instalace serveru** | Základní nastavení Ubuntu Serveru | [Návod](./it-administration/linux-ubuntu/install-server.md) |
| **SSH přístup** | Vzdálená správa přes SSH z prostředí Windows | [Návod](./it-administration/linux-ubuntu/ssh-access.md) |
| **WordPress (LAMP)** | Kompletní stack: Apache, MariaDB, PHP a WordPress | [Návod](./it-administration/linux-ubuntu/wordpress-lamp.md) |

### Doporučené externí zdroje
- [Ubuntu Server Guide](https://ubuntu.com/server/docs) - Oficiální dokumentace
- [DigitalOcean Community](https://www.digitalocean.com/community/tutorials) - Tutoriály pro Linux
- [Ask Ubuntu](https://askubuntu.com/) - Q&A pro Ubuntu
- [Reddit r/linuxadmin](https://www.reddit.com/r/linuxadmin/) - Komunita Linux administrátorů

---

## Síťové služby

Konfigurace FTP serverů a poštovních služeb.

| Téma | Popis | Odkaz |
| :--- | :--- | :---: |
| **CaesarFTP** | Nastavení jednoduchého FTP serveru pro Windows | [Návod](./it-administration/network-services/caesar-ftp.md) |
| **Cerberus FTP** | Pokročilý FTP server s podporou SSL/TLS | [Návod](./it-administration/network-services/cerberus-ftp.md) |
| **Total Commander** | Použití TC jako výkonného FTP klienta | [Návod](./it-administration/network-services/total-commander-ftp.md) |
| **Kerio Connect** | Instalace a konfigurace lokálního poštovního serveru | [Návod](./it-administration/network-services/kerio-connect.md) |
| **Thunderbird** | Nastavení e-mailového klienta pro lokální systémy | [Návod](./it-administration/network-services/thunderbird-config.md) |

### Doporučené externí zdroje
- [Stack Overflow: FTP](https://stackoverflow.com/questions/tagged/ftp) - Řešení FTP problémů
- [Reddit r/selfhosted](https://www.reddit.com/r/selfhosted/) - Self-hosting komunita
- [Server Fault: Mail Server](https://serverfault.com/questions/tagged/email-server) - Poštovní servery

---

## Programování a OOP

Praktické ukázky objektově orientovaného programování v C# a Java.

### C# Projekty

| Projekt | Popis | Odkaz |
| :--- | :--- | :---: |
| **Editor obrázků** | Kompletní tutoriál vytvoření Photoshop-like aplikace ve Visual Studio | [Tutoriál](./programming-oop/csharp-photoeditor/tutorial.md) |
| **Knihovní systém** | Desktopová aplikace pro správu knihovny s SQLite databází | [Tutoriál](./programming-oop/csharp-knihovna/tutorial.md) |
| **Safe (Události)** | Události, delegáty a vzory dědičnosti | [Kód](./programming-oop/csharp-events-delegates.md) |

#### Funkce editoru obrázků
- Obrazové filtry (černobílý, šedý, reliéf, omalovánka)
- Prolínání dvou obrázků
- Třídění pixelů podle světlosti
- Výřez a zvětšení
- ASCII Art generátor
- Interaktivní mapa barev
- Puzzle hra

#### Funkce knihovního systému
- Správa knih, autorů, žánrů a zákazníků
- SQLite databáze s CRUD operacemi
- Systém půjčování a vracení knih
- Vyhledávání a filtrování záznamů
- MetroFramework moderní UI

### Java Projekty

| Koncept | Popis | Odkaz |
| :--- | :--- | :---: |
| **Zaměstnanci** | Abstraktní třídy a polymorfní chování | [Kód](./programming-oop/java-abstract-employees.md) |
| **Generika** | Typové parametry a implementace generických tříd | [Kód](./programming-oop/java-generics-colors.md) |
| **Enumy** | Výčtové typy s konstruktory a metodami | [Kód](./programming-oop/java-enums-schedule.md) |
| **Interfacy** | Definice kontraktů a polymorfní rozhraní | [Kód](./programming-oop/java-interfaces-calc.md) |

### Doporučené externí zdroje

#### C# a .NET
- [Microsoft Docs: C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - Oficiální dokumentace
- [Stack Overflow: C#](https://stackoverflow.com/questions/tagged/c%23) - Řešení problémů
- [CodeProject](https://www.codeproject.com/KB/cs/) - Články a tutoriály
- [Reddit r/csharp](https://www.reddit.com/r/csharp/) - C# komunita

#### Java
- [Oracle Java Documentation](https://docs.oracle.com/en/java/) - Oficiální dokumentace
- [Stack Overflow: Java](https://stackoverflow.com/questions/tagged/java) - Řešení problémů
- [Baeldung](https://www.baeldung.com/) - Java tutoriály
- [Reddit r/java](https://www.reddit.com/r/java/) - Java komunita

---

## Robotika (LEGO EV3)

Projekty LEGO MINDSTORMS EV3 s využitím vizuálního programování.

| Projekt | Popis | Odkaz |
| :--- | :--- | :---: |
| **Třídička kostek** | Automatizace třídění kostek podle barev | [Návod](./robotics-ev3/brick-sorter.md) |
| **Sledovač čáry** | Přesné sledování čáry s využitím PID regulace | [Návod](./robotics-ev3/line-follower.md) |
| **Gyro Boy** | Samobalanční robot využívající Gyro senzor | [Návod](./robotics-ev3/gyro-boy.md) |
| **Robotické rameno** | Souřadnicový systém pro manipulaci s objekty | [Návod](./robotics-ev3/robotic-arm.md) |
| **Úvod do Scratch** | Základy vizuálního programování pro robotiku | [Návod](./robotics-ev3/scratch-intro.md) |

### Doporučené externí zdroje
- [LEGO Education](https://education.lego.com/en-us/lessons) - Oficiální lekce
- [EV3 Programming](https://www.ev3dev.org/) - EV3Dev komunita
- [Reddit r/mindstorms](https://www.reddit.com/r/mindstorms/) - MINDSTORMS komunita
- [Stack Exchange: Robotics](https://robotics.stackexchange.com/) - Q&A pro robotiku

---

## Jak začít

1. **Vyberte si téma** z kategorií výše
2. **Postupujte podle kroků** v návodech, které obsahují vizuální pomůcky
3. V případě potíží nahlédněte do sekce **Řešení problémů** na konci každého návodu
4. Využijte **externí odkazy** pro hlubší pochopení tématu

## Struktura repozitáře

```
projekt-prakticke/
├── images/                          # Obrázky a screenshoty
│   ├── p2p/                         # P2P networking obrázky
│   ├── server-win/                  # Windows Server obrázky
│   ├── ubuntu-server/               # Ubuntu Server obrázky
│   └── Klient/                      # Klientské obrázky
├── it-administration/
│   ├── windows-server/              # Windows Server návody
│   ├── windows-client/              # Windows klient návody
│   ├── linux-ubuntu/                # Ubuntu Server návody
│   └── network-services/            # Síťové služby
├── programming-oop/
│   ├── csharp-photoeditor/          # C# editor obrázků
│   ├── csharp-knihovna/             # C# knihovní systém
│   └── *.md                         # Java a C# koncepty
└── robotics-ev3/                    # LEGO EV3 projekty
```

## Licence

Tento projekt je volně dostupný pro vzdělávací účely.
