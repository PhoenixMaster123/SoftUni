using System;

namespace PizzaCalories
{
    class Dough
    {
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 200;
        private const int BASE_CALORIES = 2;

        private string flourType;
        private string bakingTechnique;
        private double weight;
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            set
            {
                string type = value.ToLower();
                if (type != "white" && type != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                string foodProducts = value.ToLower();
                if (foodProducts != "crispy" && foodProducts != "chewy" && foodProducts != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < MIN_WEIGHT || value > MAX_WEIGHT)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
                }
                this.weight = value;
            }
        }
        public string Calories()
        {
            double value = 0;

            switch (this.flourType.ToLower())
            {
                case "white": 
                value = 1.5; 
                break;

                case "wholegrain": 
                value = 1.0; 
                break;
            }
            switch (this.bakingTechnique.ToLower())
            {
                case "crispy": 
                value *= 0.9; 
                break;

                case "chewy": 
                value *= 1.1; 
                break;

                case "homemade": 
                value *= 1.0; 
                break;
            }
            double calories = (BASE_CALORIES * this.weight) * value;
            return calories.ToString("F2");
        }   
    }
}
