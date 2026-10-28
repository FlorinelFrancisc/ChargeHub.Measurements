# ChargeHub.Measurements

## Programmering 2 – Lektion 1

Detta projekt är skapat som en del av kursen Programmering 2 på Teknikhögskolan, utbildningen Utvecklingsingenjör inom Electromobility.

Projektet är skrivet i C# med .NET och visar hur klasser, objekt, listor, metoder och referenstyper fungerar.

## Projektbeskrivning

Programmet simulerar en laddstation som heter AC-01 och registrerar effektmätningar var 15:e minut.

Syftet är att beräkna hur mycket energi laddstationen har levererat under en viss tidsperiod.

## Projektets klasser

### Measurement.cs

Representerar en effektmätning och innehåller:

- `Time` – datum och tid för mätningen (`DateTime`).
- `Kw` – uppmätt effekt i kilowatt (`double`).

### ChargingStation.cs

Representerar laddstationen och innehåller:

- `Name` – laddstationens namn.
- `Measurements` – en lista med effektmätningar.
- `AddMeasurement()` – lägger till en mätning.
- `TotalEnergyKwh()` – beräknar den totala energin.

### Program.cs

Huvudprogrammet som:

1. Skapar laddstationen AC-01.
2. Registrerar fyra effektmätningar.
3. Beräknar den totala energin.
4. Testar hur referenstyper fungerar i C#.

## Effektmätningar

| Tid   | Effekt  |
| ----- | ------- |
| 08:00 | 11,0 kW |
| 08:15 | 11,0 kW |
| 08:30 | 10,0 kW |
| 08:45 | 6,0 kW  |

Varje mätvärde gäller i 15 minuter (0,25 timmar).

**Beräkning:**

Energi (kWh) = Effekt (kW) × Tid (h)

Total energi:

(11 + 11 + 10 + 6) × 0,25 = **9,5 kWh**

## Test av referenstyper

Jag skapade ett nytt `Measurement`-objekt med effekten 8 kW och lade till det i laddstationens lista.

Därefter ändrade jag objektets effekt till 0 kW.

Resultat:

- Före ändringen: 11,5 kWh.
- Efter ändringen: 9,5 kWh.

Testet visar att en klass är en referenstyp i C#. När flera referenser pekar på samma objekt påverkas alla som använder objektet när dess egenskaper ändras.

## Programresultat

```text
Laddstation: AC-01
AC-01 har levererat 9,5 kWh.
Före ändring: 11,5 kWh
Efter ändring: 9,5 kWh
```

## Köra projektet

För att köra programmet behövs .NET SDK.

Öppna projektmappen i VS Code och skriv:

`dotnet run`

För att kontrollera att koden kompilerar:

`dotnet build`

## Git och GitHub

Projektet har utvecklats steg för steg med Git.

Jag har använt separata brancher, commits och Pull Requests för att dokumentera arbetet.

Arbetet innehåller sex mergade Pull Requests för programmeringen och dokumentationen.

## Vad jag har lärt mig

Under uppgiften har jag tränat på:

- Att skapa klasser och objekt i C#.
- Att använda egenskaper med `get` och `set`.
- Att lagra objekt i en `List`.
- Att skapa och anropa metoder.
- Att använda `foreach`.
- Att beräkna energi i kWh.
- Att förstå skillnaden mellan referenstyper och värdetyper.
- Att arbeta med Git och GitHub.

Alla tre C#-filerna innehåller kommentarer på svenska för att förklara koden.

## Författare

Florinel Francisc

Teknikhögskolan – Utvecklingsingenjör inom Electromobility

Kurs: Programmering 2
