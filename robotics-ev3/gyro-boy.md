# GYRO BOY – Balancující robot (EV3)

Postavte dvoukolového robota GYRO BOY, který udržuje rovnováhu pomocí gyroskopického senzoru. Jde o pokročilý projekt, který demonstruje mechaniku invertovaného kyvadla.

## Podrobný postup

### 1. Stavební instrukce
Instrukce pro GYRO BOY jsou součástí softwaru LEGO MINDSTORMS Education EV3 v sekci "Robot Educator". Projekt vyžaduje základní sadu a ideálně i rozšiřující díly.

> [!TIP]
> Instrukce lze také najít online pod názvem "EV3 Gyro Boy building instructions".

### 2. Přesnost sestavení
U balancujících robotů je přesnost klíčová. Těžiště musí být dostatečně vysoko a konstrukce musí být symetrická.

> [!WARNING]
> Jakákoliv odchylka od instrukcí (jiné umístění kostky, uvolněné kabely) mění bod rovnováhy a způsobí pád robota.

### 3. Orientace gyroskopického senzoru
Připojte senzor k **portu 2**. Šipka na senzoru musí směřovat ve směru pohybu robota vpřed.

### 4. Synchronizace motorů
Velké motory zapojte do **portů B a C**. Zajistěte, aby byly zapojeny symetricky pro rovnoměrný výkon.

### 5. Kalibrační protokol
Po spuštění programu musí robot stát 2 sekundy zcela nehybně na rovné ploše pro provedení kalibrace.

> [!IMPORTANT]
> S robotem během prvních 2 sekund po spuštění programu **nehýbejte**. Pohyb během kalibrace způsobí tzv. "drift" (chybu v měření úhlu), který znemožní udržení rovnováhy.

### 6. Ladění parametrů (Offset)
Pokud robot padá dopředu, zvyšte hodnotu "Gyro Offset" v programu. Pokud padá dozadu, snižte ji. Používejte malé kroky (např. ±0.1).

## Řešení problémů (FAQ)

#### Robot hned po spuštění spadne a ani se nepokusí balancovat.
> **Řešení:** Prověřte orientaci gyroskopu (šipka vpřed). Zkontrolujte porty motorů (Levý B, Pravý C). Ujistěte se, že byl robot během kalibrace v klidu.

#### Robot balancuje, ale pomalu ujíždí (driftuje).
> **Řešení:** Jemně dolaďte "Gyro Offset" v softwaru. Tento drift je způsoben drobnými fyzickými odchylkami v konstrukci nebo nepřesnou kalibrací při startu.

[Zpět na přehled](../README.md)


[<kbd> ⮞ Zpět na úvodní stránku </kbd>](../README.md)
