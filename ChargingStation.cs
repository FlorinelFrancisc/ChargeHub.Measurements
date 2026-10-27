
using System;
using System.Collections.Generic;

namespace ChargeHub.Measurements;

public class ChargingStation
{
    public string Name { get; set; } = "";

    public List<Measurement> Measurements { get; set; } = new List<Measurement>();

    public void AddMeasurement(Measurement m)
    {
        Measurements.Add(m);
    }
}
