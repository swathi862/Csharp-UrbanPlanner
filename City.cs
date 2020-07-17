using System;
using System.Collections.Generic;

namespace planner{

    public class City{

        public string name {get; set;}
        public string mayor {get; set;}
        public int year {get; set;}

        public City(string cityName, string cityMayor, int yearEstablished){
            name = cityName;
            mayor = cityMayor;
            year = yearEstablished;
        }
        private List<Building> utopia = new List<Building>();

        public void AddBuilding(Building newBuilding){
            utopia.Add(newBuilding);
        }

    }
}