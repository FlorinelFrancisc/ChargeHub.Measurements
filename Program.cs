using ChargeHub.Measurements;

ChargingStation station = new ChargingStation();

station.Name = "AC-01";

Console.WriteLine("Laddstation: " + station.Name);

station.AddMeasurement(new Measurement
{
    Time = new DateTime(2026, 10, 27, 8, 0, 0),
    Kw = 11.0
});

station.AddMeasurement(new Measurement
{
    Time = new DateTime(2026, 10, 27, 8, 15, 0),
    Kw = 11.0
});

station.AddMeasurement(new Measurement
{
    Time = new DateTime(2026, 10, 27, 8, 30, 0),
    Kw = 10.0
});

station.AddMeasurement(new Measurement
{
    Time = new DateTime(2026, 10, 27, 8, 45, 0),
    Kw = 6.0
});

Console.WriteLine(station.Name + " har levererat " + station.TotalEnergyKwh() + " kWh.");
