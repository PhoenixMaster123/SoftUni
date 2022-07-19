namespace FoodShortage
{
    public class Rebel : IBuyer
    {

        private string name;
        private int age;
        private string group;
        private int food = 0;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }


        public int Food => food;
        public void BuyFood()
        {
            this.food += 5;
        }
    }
}
