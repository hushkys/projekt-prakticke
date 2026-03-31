# Správa IT infrastruktury, systémů a robotiky - Znalostní báze

Komplexní sbírka technických návodů a postupů určená pro administrátory IT, systémové inženýry a nadšence do robotiky. Tento repozitář pokrývá prostředí Windows Server, Linux (Ubuntu), síťové služby a projekty LEGO MINDSTORMS EV3.

---

## Správa IT a infrastruktury

### Windows Server Management
| Téma | Popis | Odkaz |
| :--- | :--- | :--- |
| **Nastavení VM** | Konfigurace VirtualBoxu a vnitřních sítí. | [Návod](./it-administration/windows-server/vm-setup.md) |
| **Instalace OS** | Podrobný postup instalace Windows Server 2019/2022. | [Návod](./it-administration/windows-server/install-os.md) |
| **Domenový řadič** | Povýšení na DC a konfigurace AD DS. | [Návod](./it-administration/windows-server/domain-controller.md) |
| **Uživatelé a OU** | Správa uživatelských účtů a organizační struktury. | [Návod](./it-administration/windows-server/users-groups-ou.md) |
| **DHCP Server** | Konfigurace automatického přidělování IP adres. | [Návod](./it-administration/windows-server/dhcp-server.md) |
| **Sdílení souborů** | Nastavení NTFS a Share oprávnění. | [Návod](./it-administration/windows-server/file-sharing.md) |
| **Připojení klienta** | Připojení pracovní stanice Windows do domény. | [Návod](./it-administration/windows-server/client-join.md) |
| **Skupinové politiky (GPO)** | Restrikce uživatelů a automatické mapování disků. | [Návod](./it-administration/windows-server/group-policy.md) |
| **Tiskový server** | Instalace a nasazení síťových tiskáren. | [Návod](./it-administration/windows-server/print-server.md) |
| **Klonování VM** | Rychlé nasazení virtuálních strojů pomocí klonů. | [Návod](./it-administration/windows-server/vm-cloning.md) |

### Linux (Ubuntu Server)
| Téma | Popis | Odkaz |
| :--- | :--- | :--- |
| **Instalace serveru** | Základní nastavení Ubuntu Serveru pro webové služby. | [Návod](./it-administration/linux-ubuntu/install-server.md) |
| **SSH přístup** | Vzdálená správa přes SSH z prostředí Windows. | [Návod](./it-administration/linux-ubuntu/ssh-access.md) |
| **WordPress (LAMP)** | Kompletní stack: Apache, MariaDB, PHP a WordPress. | [Návod](./it-administration/linux-ubuntu/wordpress-lamp.md) |

### Síťové služby
| Téma | Popis | Odkaz |
| :--- | :--- | :--- |
| **CaesarFTP** | Nastavení jednoduchého FTP serveru pro Windows. | [Návod](./it-administration/network-services/caesar-ftp.md) |
| **Cerberus FTP** | Pokročilý FTP server s podporou SSL/TLS. | [Návod](./it-administration/network-services/cerberus-ftp.md) |
| **Total Commander** | Použití TC jako výkonného FTP klienta. | [Návod](./it-administration/network-services/total-commander-ftp.md) |
| **Kerio Connect** | Instalace a konfigurace lokálního poštovního serveru. | [Návod](./it-administration/network-services/kerio-connect.md) |
| **Thunderbird** | Nastavení e-mailového klienta pro lokální systémy. | [Návod](./it-administration/network-services/thunderbird-config.md) |

---

## Robotika (LEGO MINDSTORMS EV3)
| Projekt | Popis | Odkaz |
| :--- | :--- | :--- |
| **Třídička kostek** | Automatizace třídění kostek podle barev. | [Návod](./robotics-ev3/brick-sorter.md) |
| **Sledovač čáry** | Přesné sledování čáry s využitím PID regulace. | [Návod](./robotics-ev3/line-follower.md) |
| **Gyro Boy** | Samobalanční robot využívající Gyro senzor. | [Návod](./robotics-ev3/gyro-boy.md) |
| **Robotické rameno** | Souřadnicový systém pro manipulaci s objekty. | [Návod](./robotics-ev3/robotic-arm.md) |
| **Úvod do Scratch** | Základy vizuálního programování pro robotiku. | [Návod](./robotics-ev3/scratch-intro.md) |

---

## Programování a OOP koncepty
| Koncept | Jazyk | Popis | Odkaz |
| :--- | :--- | :--- | :--- |
| **Safe (Události)** | C# | Události, delegáty a vzory dědičnosti. | [Kód](./programming-oop/csharp-events-delegates.md) |
| **Zaměstnanci** | Java | Abstraktní třídy a polymorfní chování. | [Kód](./programming-oop/java-abstract-employees.md) |
| **Generika** | Java | Typové parametry a implementace generických tříd. | [Kód](./programming-oop/java-generics-colors.md) |
| **Enumy** | Java | Výčtové typy s konstruktory a metodami. | [Kód](./programming-oop/java-enums-schedule.md) |
| **Interfacy** | Java | Definice kontraktů a polymorfní rozhraní. | [Kód](./programming-oop/java-interfaces-calc.md) |

---

## Jak začít
1. **Vyberte si téma** z tabulek výše.
2. **Postupujte podle kroků** v návodech, které obsahují vizuální pomůcky.
3. V případě potíží nahlédněte do sekce **Řešení problémů** na konci každého návodu.
