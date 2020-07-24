using System;
using System.Collections.Generic;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> propertyManagement = new List<Building>();

            City Rainville = new City("Rainville", "Gilly Weed", 1492);
            
            Building FiveOneTwoEigth = new Building("512 8th Avenue", "Jordan Castelloe"){
                Width = 50.0,
                Depth = 100.5,
                Stories = 13
            };
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Steve Brownlee");
            Rainville.AddBuilding(FiveOneTwoEigth);

            Building FiveOFive = new Building("505 8th Avenue", "Tommy Spurlock"){
                Width = 100.0,
                Depth = 50.5,
                Stories = 3
            };
            FiveOFive.Construct();
            FiveOFive.Purchase("Steve Brownlee");
            Rainville.AddBuilding(FiveOFive);


            Building FiveOTwo = new Building("502 8th Avenue", "Tommy Spurlock"){
                Width = 200.05,
                Depth = 500.5,
                Stories = 10
            };
            FiveOTwo.Construct();
            FiveOTwo.Purchase("Tommy Spurlock");
            Rainville.AddBuilding(FiveOTwo);



            Building ThreeOFour = new Building("304 8th Avenue", "Steve Brownlee"){
                Width = 500.85,
                Depth = 1000.532,
                Stories = 100
            };
            ThreeOFour.Construct();
            ThreeOFour.Purchase("Steve Brownlee");
            Rainville.AddBuilding(ThreeOFour);


            Building FiveHundy = new Building("500 8th Avenue", "Jordan Castelloe"){
                Width = 50.0,
                Depth = 100.5,
                Stories = 13
            };
            FiveHundy.Construct();
            FiveHundy.Purchase("Jordan Castelloe");
            Rainville.AddBuilding(FiveHundy);


            // propertyManagement.ForEach(property => property.PrintBuilding(property));

            Rainville.ListBuildings();


        }
    }
}
