using System;

namespace planner{

    public class Building{

        private string _designer {get; set;}
        private DateTime _dateConstructed {get; set;}
        private string _address {get; set;}
        private string _owner {get; set;}

        public int Stories {get; set;}
        public double Width {get; set;}
        public double Depth {get; set;}

        public double Volume {

            get {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address, string designer){
            _address = address;
            _designer = designer;
        }

        public void Construct(){
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner){
            _owner = owner;
        }

        public void PrintBuilding(Building building){
            Console.WriteLine($"\n {building._address}\n------------------\n Designed by {building._designer} \n Constructed by {building._dateConstructed}\n Owned by {building._owner} \n {building.Volume} cubic meters of space");
        }




    }
}