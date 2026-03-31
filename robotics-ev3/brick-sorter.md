# BRICK SORT3R – Třídička kostek LEGO (EV3)

Sestavte a naprogramujte robota BRICK SORT3R ze sady LEGO MINDSTORMS EV3, který automaticky třídí kostky podle barvy pomocí barevného senzoru.

## Podrobný postup

### 1. Příprava a dokumentace
Stáhněte si stavební instrukce z webu Robotsquare.com nebo použijte oficiální dokumentaci LEGO. Připravte si základní sadu LEGO MINDSTORMS EV3.

> [!TIP]
> Robotsquare.com je předním zdrojem projektů pro LEGO MINDSTORMS od Laurense Valkenburgha, autora mnoha úspěšných modelů.

### 2. Sestavení hlavního rámu
Začněte stavbou základního rámu. Kostku EV3 (mozek robota) připevněte doprostřed, aby byla zajištěna stabilita a snadný přístup ke kabelům.

### 3. Zapojení motorů
- **Velký motor (Port B):** Pohání dopravníkový pás.
- **Střední motor (Port A):** Ovládá třídicí rameno, které shazuje kostky do přihrádek.

> [!WARNING]
> Ujistěte se, že jsou kabely pevně zasunuty. Uvolněné spoje jsou nejčastější příčinou selhání motorů během provozu.

### 4. Kalibrace barevného senzoru
Připojte barevný senzor k **portu 3**. Umístěte jej přibližně 1–2 cm nad dopravníkový pás tak, aby směřoval přímo dolů.

> [!IMPORTANT]
> Vzdálenost je kritická. Příliš malá nebo velká vzdálenost vede k nespolehlivé detekci barev. Experimentujte, dokud senzor nebude hlásit správné ID barev.

### 5. Programová logika a ID barev
Při programování pracujte s ID hodnotami barevného senzoru EV3. Každé barvě odpovídá konkrétní číslo.

```javascript
// EV3 Color IDs (Barevné kódy):
// 0=Žádná, 1=Černá, 2=Modrá, 3=Zelená, 4=Žlutá, 5=Červená, 6=Bílá
```

### 6. Hlavní operační smyčka
Naprogramujte hlavní nekonečnou smyčku:
1. Spustit pás.
2. Čekat na detekci barvy (ID > 0).
3. Zastavit pás.
4. Pohnout ramenem do pozice odpovídající zjištěné barvě.
5. Vrátit rameno a restartovat pás.

### 7. Nastavení pozic ramene
Vylaďte úhly rotace středního motoru pro každou sběrnou nádobu. Doporučujeme nastavit výkon motoru na 30–50 % pro vyšší přesnost a menší riziko zaseknutí.

## Řešení problémů (FAQ)

#### Senzor hlásí nesprávné barvy.
> **Řešení:** Zkontrolujte okolní osvětlení. Přímé sluneční světlo nebo silné stíny mohou senzor mást. Kolem senzoru můžete vytvořit malý stínicí kryt z LEGO dílků.

#### Kostky se na pásu zasekávají.
> **Řešení:** Zkontrolujte zarovnání ozubených kol. Pás by neměl být ani příliš napnutý, ani příliš volný. Zkuste snížit rychlost motoru dopravníku.

[Zpět na přehled](../../README.md)
