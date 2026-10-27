
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

    public double TotalEnergyKwh()
    {
        double total = 0;

        foreach (Measurement m in Measurements)
        {
            total = total + m.Kw * 0.25;
        }

        return total;
    }

}

