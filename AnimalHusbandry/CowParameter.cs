using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnimalHusbandry
{
    internal class CowParameter<T>
    {
        public static HealthParameter<int> TimeToStand{ get; set; }
        public static HealthParameter<int> TimeToDeal{ get; set; }
        public static HealthParameter<int> TimeToRelax{ get; set; }
        public static HealthParameter<int> NumberOfMeal{ get; set; }
        public static HealthParameter<int> NumberOfMilkProduction{ get; set; }
        public static DateTime date {  get; set; }

        public CowParameter(int timeToStand, int timeToDeal, int timeToRelax, int numberOfMeal,int numberOfMilkProduction)
        {
            // Initialize the fields with specific values
            TimeToStand = new HealthParameter<int> { Name = "TimeToStand", Current = timeToStand, Standard = 5 };
            TimeToDeal = new HealthParameter<int> { Name = "TimeToDeal", Current = timeToDeal, Standard = 3 };
            TimeToRelax = new HealthParameter<int> { Name = "TimeToRelax", Current = timeToRelax, Standard = 10 };
            NumberOfMeal = new HealthParameter<int> { Name = "NumberOfMeal", Current = numberOfMeal, Standard = 5 };
            NumberOfMilkProduction = new HealthParameter<int> { Name = "NumberOfMilkProduction", Current = numberOfMilkProduction, Standard = 1 };
            date = DateTime.Now;
        }
    }
}
