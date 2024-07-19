using System;
using System.Collections.Generic;

public class RentalAgency
{
    private List<Vehicle> Fleet { get; set; }
    public decimal TotalRevenue { get; private set; }

    public RentalAgency()
    {
        Fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }

    public void RentVehicle(Vehicle vehicle, int days)
    {
        if (Fleet.Contains(vehicle))
        {
            TotalRevenue += vehicle.RentalPrice * days;
            Fleet.Remove(vehicle);
            Console.WriteLine($"Vehicle rented: {vehicle.Model} for {days} days. Total revenue: {TotalRevenue:C}");
        }
        else
        {
            Console.WriteLine("Vehicle not available.");
        }
    }

    public void DisplayFleet()
    {
        foreach (var vehicle in Fleet)
        {
            vehicle.DisplayDetails();
        }
    }
}
