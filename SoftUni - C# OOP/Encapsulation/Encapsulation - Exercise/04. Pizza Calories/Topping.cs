using System;
namespace PizzaCalories
{
    class Topping
    {
        private const int MIN_WEIGHT = 1;
        private const int MAX_WEIGHT = 50;
        private const int BASE_CALORIES = 2;

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                string foodProducts = value.ToLower();
                if (foodProducts != "meat" && foodProducts != "veggies" && foodProducts != "cheese" && foodProducts != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.type = value;
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
                    throw new ArgumentException
                        ($"{this.type} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
                }
                this.weight = value;
            }
        }
        public string Calories()
        {
            double value = 0;

            switch (this.type.ToLower())
            {
                case "meat":
                value = 1.2; 
                break;

                case "veggies": 
                value = 0.8; 
                break;

                case "cheese": 
                value = 1.1; 
                break;

                case "sauce": 
                value = 0.9; 
                break;
            }
            double calories = (BASE_CALORIES * this.weight) * value;
            return calories.ToString("F2");
        }

       
    }
}
