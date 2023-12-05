using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHusbandry
{
    internal class HealthParameter<T>
    {
        public string Name;
        public T Current;
        public T Standard;

        public static float StressFactor()
        {

            return 0;
        }
    }
}
