using System;
class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency();

        // Add 12 Cars
        agency.AddVehicle(new Car("Fortuner", "Toyota", 2021, 1000m, 5, "Petrol", "Manual", false));
        agency.AddVehicle(new Car("Swift", "Maruti Suzuki", 2020, 1200m, 5, "Petrol", "Manual", false));
        agency.AddVehicle(new Car("City", "Honda", 2019, 1500m, 5, "Petrol", "Manual", false));
        agency.AddVehicle(new Car("Creta", "Hyundai", 2021, 2000m, 5, "Petrol", "Automatic", false));
        agency.AddVehicle(new Car("Nexon", "Tata", 2021, 1700m, 5, "Diesel", "Manual", false));
        agency.AddVehicle(new Car("Seltos", "Kia", 2020, 1800m, 5, "Petrol", "Manual", false));
        agency.AddVehicle(new Car("Innova Crysta", "Toyota", 2019, 2500m, 7, "Diesel", "Automatic", false));
        agency.AddVehicle(new Car("XUV500", "Mahindra", 2021, 2200m, 7, "Diesel", "Manual", false));
        agency.AddVehicle(new Car("Ciaz", "Maruti Suzuki", 2020, 1300m, 5, "Petrol", "Manual", false));
        agency.AddVehicle(new Car("Venue", "Hyundai", 2021, 1600m, 5, "Petrol", "Automatic", false));
        agency.AddVehicle(new Car("EcoSport", "Ford", 2020, 1500m, 5, "Petrol", "Manual", false));
        agency.AddVehicle(new Car("Hector", "MG", 2021, 2100m, 5, "Petrol", "Automatic", false));

        // Add 11 Motorcycles
        agency.AddVehicle(new Motorcycle("Splendor", "Hero", 2019, 500m, 100, "Petrol", false));
        agency.AddVehicle(new Motorcycle("Pulsar", "Bajaj", 2020, 700m, 150, "Petrol", false));
        agency.AddVehicle(new Motorcycle("Apache", "TVS", 2021, 800m, 160, "Petrol", false));
        agency.AddVehicle(new Motorcycle("FZ", "Yamaha", 2019, 750m, 150, "Petrol", false));
        agency.AddVehicle(new Motorcycle("Activa", "Honda", 2020, 600m, 110, "Petrol", false));
        agency.AddVehicle(new Motorcycle("Jupiter", "TVS", 2021, 650m, 110, "Petrol", false));
        agency.AddVehicle(new Motorcycle("Bullet", "Royal Enfield", 2019, 1000m, 350, "Petrol", false));
        agency.AddVehicle(new Motorcycle("Gixxer", "Suzuki", 2020, 900m, 150, "Petrol", false));
        agency.AddVehicle(new Motorcycle("Duke", "KTM", 2021, 1200m, 200, "Petrol", false));
        agency.AddVehicle(new Motorcycle("CBR", "Honda", 2019, 1300m, 250, "Petrol", true));
        agency.AddVehicle(new Motorcycle("Ninja", "Kawasaki", 2020, 1500m, 300, "Petrol", true));

        // Add 12 Trucks
        agency.AddVehicle(new Truck("Bolero", "Mahindra", 2019, 3000m, 1.5, "Pickup", true));
        agency.AddVehicle(new Truck("Scorpio Getaway", "Mahindra", 2020, 3500m, 2.0, "Pickup", true));
        agency.AddVehicle(new Truck("Xenon", "Tata", 2021, 4000m, 2.5, "Pickup", true));
        agency.AddVehicle(new Truck("Yodha", "Tata", 2018, 2500m, 1.8, "Pickup", true));
        agency.AddVehicle(new Truck("Isuzu D-Max", "Isuzu", 2019, 4500m, 2.2, "Pickup", true));
        agency.AddVehicle(new Truck("Super Carry", "Maruti Suzuki", 2020, 3200m, 1.2, "Mini Truck", true));
        agency.AddVehicle(new Truck("Porter", "Ashok Leyland", 2021, 3300m, 1.5, "Mini Truck", true));
        agency.AddVehicle(new Truck("Eicher Pro", "Eicher", 2018, 5000m, 3.0, "Light Truck", true));
        agency.AddVehicle(new Truck("Tata Ace", "Tata", 2020, 2800m, 1.0, "Mini Truck", true));
        agency.AddVehicle(new Truck("Mahindra Maxximo", "Mahindra", 2019, 2900m, 1.0, "Mini Truck", true));
        agency.AddVehicle(new Truck("Piaggio Ape", "Piaggio", 2021, 2700m, 0.8, "Mini Truck", true));
        agency.AddVehicle(new Truck("Mahindra Jeeto", "Mahindra", 2022, 3100m, 1.2, "Mini Truck", true));

        Console.WriteLine("Fleet details:");
        agency.DisplayFleet();

        Console.WriteLine("\nRenting a car for 3 days...");
        agency.RentVehicle("Fortuner", 3);

        Console.WriteLine("\nFleet details after renting a car:");
        agency.DisplayFleet();

        Console.WriteLine($"\nTotal revenue: {agency.TotalRevenue:C}");
    }
}