using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHusbandry
{
    abstract class Animal
    {
        public DateTime BirthDate { get; init; }
        public static readonly int MaxLife = 20;
        public float Weight { get; set; }
        public bool Gender { get; set; }
        public string Name { get; set; }
        public List<Env> Environments { get; set; }

        public Animal(
            DateTime birthDate,
            float weight,
            bool gender,
            string name,
            List<Env> environments)
        {
            Environments = environments;
            BirthDate = birthDate;
            Weight = weight;
            Gender = gender;
            Name = name;
        }

        public float CalculateStressFactor()
        {
            float totalStressFactor = 0;

            foreach (var factor in Environments)
            {
                // Calculate stress factor for each DataProcessor
                float stressFactor = Math.Abs(factor.TDS.Current - factor.TDS.Standard) / 10.0f
                    + Math.Abs(factor.Temp.Current - factor.Temp.Standard) / 10.0f
                    + Math.Abs(factor.Density.Current - factor.Density.Standard) / 10.0f
                    + Math.Abs(factor.db.Current - factor.db.Standard) / 10.0f
                    + Math.Abs(factor.AQI.Current - factor.AQI.Standard) / 10.0f
                    + Math.Abs(factor.OX.Current - factor.OX.Standard) / 10.0f;

                totalStressFactor += stressFactor;
            }

            // Normalize the total stress factor to be between 1 and 10
            float normalizedStressFactor = Math.Clamp(totalStressFactor, 1.0f, 10.0f);

            return normalizedStressFactor;
        }

    }
}
