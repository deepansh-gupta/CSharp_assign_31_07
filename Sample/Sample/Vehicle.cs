using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    //public enum VehType
    //{
    //        Car,
    //        Truck,
    //        Bus
    //}
    //public enum FuelType
    //{
    //        Diesel,
    //        Petrol,
    //        CNG
    //}
    //public class Vehicle
    //{
    //    public string name;
    //    public string color; 
    //    public int noofwheels;
    //    public string make;

    //    public void Start() 
    //    {
    //        Console.WriteLine("{0} has started or {1} has started", VehType.Car, VehType.Truck);
    //    }
    //    public void Stop()
    //    {
    //        Console.WriteLine("{0} has stoped or {1} has stoped", VehType.Car, VehType.Truck);
    //    }

    //    public Vehicle(string name , string color, int noofwheels)
    //    {
    //        VehType vehicleType = VehType.Car;
    //        Console.WriteLine(vehicleType);
    //    }

    //    public Vehicle(string name , string color , Enum VehType, int noofwheels )
    //    {
    //        this.name = name;
    //        this.color = color;
    //        this.noofwheels = noofwheels;
    //        FuelType.Petrol;

    //    }

    //    public Vehicle(string name, string color): this()
    //    {
    //        Console.WriteLine(name, color , noofwheels, fuelType);
    //    }

        public enum VehType
        {
            car,
            bus,
            truck
        };
        public enum FuelType
        {
            diesel,
            petrol,
            cng
        };



        public class Vehicle
        {

            string name;
            string color;
            int noOfWheels;
            VehType vehType;
            FuelType fuel;

        public string Color;
      


            public void Start(VehType vehicletype)
            {
                Console.WriteLine(vehicletype + " has started");
            }
            public void Stop(VehType vehicletype)
            {
                Console.WriteLine(vehicletype + "has stopped");
            }
            public Vehicle(string name, string color, VehType veh, int noOfWheels, FuelType fuel)
            {
                this.Name = name;
                this.Color = color;
                this.NoOfWheel = noOfWheels;
                this.VehTypes = veh;
                this.FuelTypes = fuel;



            }
            public Vehicle(string name, string color, VehType veh, int noOfWheels)
            {
                this.Name = name;
                this.Color = color;
                this.NoOfWheel = noOfWheels;
                this.VehTypes = veh;
                this.FuelTypes = FuelType.petrol;
            }
            public Vehicle(string name, string color)
            {
                this.Name = name;
                this.Color = color;
                this.VehTypes = VehType.car;
                this.NoOfWheel = 4;
                this.FuelTypes = FuelType.petrol;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

        //public string Color
        //{
        //    get { return color; }
        //    set { color = value; }
        //}
        public int NoOfWheel
            {
                get { return this.noOfWheels; }
                set { this.noOfWheels = value; }
            }

            

            public VehType VehTypes
            {
                get { return this.vehType; }
                set { this.vehType = value; }
            }
            public FuelType FuelTypes
            {
                get { return this.fuel; }
                set { this.fuel = value; }
            }



            public static void Main()
            {


            }
        }
    }








