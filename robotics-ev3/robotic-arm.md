# Robotické rameno – Pick and Place (EV3)

Postavte a naprogramujte robotické rameno s EV3, které dokáže uchopit a přenášet předměty. Projekt je ideální pro pochopení souřadnicových systémů a přesného polohování.

## Podrobný postup

### 1. Stavba stabilní základny
Základem je tuhá a dostatečně těžká podstava. Stabilita je kritická pro přesnost pohybů ramene. Kostku EV3 připevněte přímo k základně.

### 2. Rotační kloub (Otáčení)
Sestavte rotační modul – velký motor v **portu A** otáčí celým ramenem vlevo a vpravo.

> [!TIP]
> Přidejte dotykový senzor pro automatickou detekci výchozí pozice (0° reference) při každém startu.

### 3. Vertikální kloub (Zdvih)
Sestavte mechanismus zdvihu – velký motor v **portu B** zvedá a spouští rameno. Pro odlehčení motoru použijte protizávaží.

> [!WARNING]
> Bez protizávaží musí motor držet celou váhu ramene, což vede k rychlému přehřívání. Přidejte závaží na opačnou stranu od kloubu.

### 4. Sestavení kleští (Grip)
Střední motor v **portu C** otevírá a zavírá čelisti kleští. Pro detekci uchopení předmětu lze použít dotykový senzor.

### 5. Kalibrační logika
Naprogramujte úvodní rutinu: přesuňte rameno do výchozí pozice a vynulujte čítače otáček motorů (kodéry).

```javascript
// Resetování kodérů (Encoder reset):
// Motor A: Vynulovat rotaci → Port A
// Motor B: Vynulovat rotaci → Port B
// Motor C: Vynulovat rotaci → Port C
```

### 6. Pohyb na základě souřadnic
Definujte cílové pozice jako kombinaci úhlů natočení motorů (A: rotace, B: výška, C: stisk). Tyto hodnoty uložte jako konstanty.

> [!TIP]
> Ručně nastavte rameno do cílových pozic a zapište si úhly z displeje EV3. Tyto hodnoty pak použijte ve svém programu.

### 7. Sekvence Přenes a Polož
Naprogramujte celou sekvenci:
1. Přesun na místo "Pick".
2. Sevření kleští.
3. Přesun na místo "Place".
4. Otevření kleští.
5. Návrat do výchozí pozice.

### 8. Rychlost a preciznost
Vylaďte rychlost motorů. Pomalejší pohyby jsou přesnější – nastavte rychlost na 20–40 % pro co nejpřesnější umístění.

> [!IMPORTANT]
> Přidejte krátké pauzy (Čekat 0,2 s) mezi jednotlivými pohyby. Motory potřebují čas se stabilizovat, než začnou provádět další akci.

## Řešení problémů (FAQ)

#### Rameno se pohybuje nepřesně – pozice se pokaždé mění.
> **Řešení:** Používejte polohování podle kodérů (Move to Position), nikoliv podle času. Kodéry jsou přesné; čas závisí na stavu baterie a tření.

#### Motor se přehřívá a přestává pracovat.
> **Řešení:** Přidejte protizávaží nebo pružiny, které motoru pomohou se zdvihem. Snižte rychlost a přidejte pauzy mezi pohyby.

#### Kleště nedrží předměty a ty vypadávají.
> **Řešení:** Na čelisti kleští přidejte gumičky pro zvýšení tření. Zvyšte sílu sevření (vyšší výkon u motoru C).

[Zpět na přehled](../../README.md)
