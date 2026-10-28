
using System; // Ger tillgång till DateTime och andra grundläggande C#-typer

namespace ChargeHub.Measurements; // Anger vilket namespace klassen tillhör

// Klassen Measurement representerar en effektmätning vid laddstationen
public class Measurement
{
    // Sparar datum och tid då mätningen gjordes
    public DateTime Time { get; set; }

    // Sparar den uppmätta effekten i kilowatt (kW)
    public double Kw { get; set; }
}
