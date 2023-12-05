using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHusbandry
{
    internal class Env
    {
        public HealthParameter<int> TDS;
        public HealthParameter<float> Temp;
        public HealthParameter<float> Density;
        public HealthParameter<int> db;
        public HealthParameter<int> AQI;
        public HealthParameter<int> OX;
        public DateTime Date;

        public Env(
        int tdsValue,
        float tempValue,
        float densityValue,
        int dbValue,
        int aqiValue,
        int oxValue)
        {
            TDS = new HealthParameter<int> { Name = "TDS", Current = tdsValue, Standard = 100 };
            Temp = new HealthParameter<float> { Name = "Temperature", Current = tempValue, Standard = 37.0f };
            Density = new HealthParameter<float> { Name = "Density", Current = densityValue, Standard = 1.0f };
            db = new HealthParameter<int> { Name = "Decibels", Current = dbValue, Standard = 50 };
            AQI = new HealthParameter<int> { Name = "Air Quality Index", Current = aqiValue, Standard = 100 };
            OX = new HealthParameter<int> { Name = "Oxygen Level", Current = oxValue, Standard = 100 };
            Date = DateTime.Now;
        }
    }
}
