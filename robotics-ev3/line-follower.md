# Sledování čáry (EV3 Line Follower)

Sestavte robota, který sleduje černou čáru na bílém podkladu pomocí světelného/barevného senzoru. Klasický projekt pro pochopení principů PID regulace.

## Podrobný postup

### 1. Stavba podvozku
Postavte základní podvozek se dvěma velkými motory (**porty B a C**) a jedním volně otočným kolečkem (vlečným kolem) pro stabilitu.

> [!TIP]
> Symetrický podvozek je klíčem k úspěchu – motory by měly být stejně vzdáleny od středu robota.

### 2. Umístění senzoru
Připojte barevný senzor k **portu 1**. Umístěte ho před robota směrem dolů, přibližně 1 cm nad povrch, přesně do středu mezi kola.

> [!WARNING]
> Senzor musí být přesně vycentrován – pokud bude vyosený, robot bude mít tendenci zatáčet pouze na jednu stranu.

### 3. Příprava dráhy
Vytvořte černou čáru (šířka 2–3 cm) na bílém pozadí. Pro začátek se vyhněte extrémně ostrým zatáčkám.

> [!IMPORTANT]
> Ideální šířka čáry je 2–2,5 cm. Příliš úzká čára způsobí, že ji robot při vyšší rychlosti snadno ztratí.

### 4. Kalibrace senzoru
Změřte intenzitu odraženého světla (Reflected Light Intensity) na bílém a na černém povrchu. Vypočítejte prahovou hodnotu (Threshold).

```javascript
// Typické hodnoty:
// Bílá: 60–70
// Černá: 5–15
// Práh (Threshold) = průměr: (70 + 10) / 2 = 40
```

### 5. Základní řízení (ON/OFF)
Naprogramujte jednoduchou logiku: pokud je světlo > práh (bílá) → zatoč doleva, pokud je světlo < práh (černá) → zatoč doprava.

> [!NOTE]
> Toto řízení funguje, ale pohyb robota bude trhaný a pomalý. Pro plynulý pohyb použijte PID regulaci.

### 6. Pokročilé řízení (PID regulace)
Spočítejte chybu (odchylku od prahu) a vynásobte ji koeficienty Kp (proporcionální), Ki (integrační) a Kd (derivační) pro úpravu výkonu motorů.

```javascript
// Pseudokód pro PID regulaci:
// chyba = senzor_hodnota - prah
// P = Kp * chyba
// I = I + chyba
// D = chyba - predchozi_chyba
// korekce = P + Ki*I + Kd*D
// motor_levy = zakladni_rychlost + korekce
// motor_pravy = zakladni_rychlost - korekce
```

### 7. Testování a ladění
Testujte na dráze. Postupně zvyšujte základní rychlost a laďte koeficienty PID pro co nejplynulejší průjezd zatáčkami.

## Řešení problémů (FAQ)

#### Robot se agresivně kymácí a ztrácí čáru.
> **Řešení:** Snižte koeficient Kp (proporcionální složka). Vysoká hodnota Kp způsobuje překmitávání. Začněte s hodnotou kolem 0,3.

#### Robot čáru vůbec nesleduje a jede rovně.
> **Řešení:** Zkontrolujte kalibraci – prahová hodnota musí ležet mezi naměřenými hodnotami bílé a černé barvy. Ujistěte se, že je senzor v režimu "Reflected Light" (Odražené světlo).

[Zpět na přehled](../README.md)


[<kbd> ⮞ Zpět na úvodní stránku </kbd>](../README.md)
