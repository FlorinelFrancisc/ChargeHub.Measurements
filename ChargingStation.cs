
using System; // Ger tillgång till grundläggande C#-typer
using System.Collections.Generic; // Gör att vi kan använda List

namespace ChargeHub.Measurements; // Samma namespace som Measurement

// Klassen representerar en laddstation med flera effektmätningar
public class ChargingStation
{
    // Sparar laddstationens namn
    public string Name { get; set; } = "";

    // Skapar en lista där vi sparar alla mätningar
    public List<Measurement> Measurements { get; set; } = new List<Measurement>();

    // Metoden tar emot en mätning som ett Measurement-objekt
    public void AddMeasurement(Measurement m)
    {
        // Lägger till mätningen i stationens lista
        Measurements.Add(m);
    }

    // Beräknar den totala levererade energin i kWh
    public double TotalEnergyKwh()
    {
        // Startar beräkningen från noll
        double total = 0;

        // Går igenom alla mätningar i listan
        foreach (Measurement m in Measurements)
        {
            // Varje mätning gäller 15 minuter, alltså 0,25 timmar
            // Energi (kWh) = effekt (kW) gånger tid (h)
            total = total + m.Kw * 0.25;
        }

        // Skickar tillbaka den totala energin
        return total;
    }
}
