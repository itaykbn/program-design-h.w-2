using Queue;
using System;
namespace program_design_h.w_2
{
    class Trip
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public double CostPerHiker {get;set;}
        public MyQueue<Family> Families;

        public Trip(string name, string iD, DateTime date, double costPerHiker, MyQueue<Family> families)
        {
            Name = name;
            ID = iD;
            Date = date;
            CostPerHiker = costPerHiker;
            if(families == null)
            {
                families = new MyQueue<Family>();
            }
            else
            {
                Families = families;
            }

        }

        public string Registerate(Family family)
        {
            Families.Insert(family);
            return "registerd to : " + ID;
        }

    }
}