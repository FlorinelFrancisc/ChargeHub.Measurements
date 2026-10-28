
using ChargeHub.Measurements; // Ger tillgång till våra klasser

// Skapar ett nytt objekt av klassen ChargingStation
ChargingStation station = new ChargingStation();

// Ger laddstationen namnet AC-01
station.Name = "AC-01";

// Skriver ut laddstationens namn
Console.WriteLine("Laddstation: " + station.Name);

// Lägger till första mätningen, kl. 08:00 med 11 kW
station.AddMeasurement(new Measurement
{
    Time = new DateTime(2026, 10, 27, 8, 0, 0),
    Kw = 11.0
});

// Lägger till andra mätningen, kl. 08:15 med 11 kW
station.AddMeasurement(new Measurement
{
    Time = new DateTime(2026, 10, 27, 8, 15, 0),
    Kw = 11.0
});

// Lägger till tredje mätningen, kl. 08:30 med 10 kW
station.AddMeasurement(new Measurement
{
    Time = new DateTime(2026, 10, 27, 8, 30, 0),
    Kw = 10.0
});

// Lägger till fjärde mätningen, kl. 08:45 med 6 kW
station.AddMeasurement(new Measurement
{
    Time = new DateTime(2026, 10, 27, 8, 45, 0),
    Kw = 6.0
});

// Beräknar och skriver ut energin från de fyra mätningarna
Console.WriteLine(station.Name + " har levererat " + station.TotalEnergyKwh() + " kWh.");

// Skapar en ny mätning med 8 kW kl. 09:00
Measurement m = new Measurement
{
    Time = new DateTime(2026, 10, 27, 9, 0, 0),
    Kw = 8.0
};

// Lägger till samma objekt i laddstationens lista
station.AddMeasurement(m);

// Skriver ut total energi innan objektets värde ändras
Console.WriteLine("Före ändring: " + station.TotalEnergyKwh() + " kWh");

// Ändrar effekten i objektet från 8 kW till 0 kW
// Listan påverkas eftersom den refererar till samma objekt
m.Kw = 0;

// Beräknar totalen igen för att se förändringen
Console.WriteLine("Efter ändring: " + station.TotalEnergyKwh() + " kWh");
