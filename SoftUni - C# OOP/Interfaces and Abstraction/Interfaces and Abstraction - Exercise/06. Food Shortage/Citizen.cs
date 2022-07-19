namespace FoodShortage
{
    public class Citizen : IId, IBirthdate, IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthday;
        private int food = 0;
        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
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
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public int Food => food;

        public void BuyFood()
        {
            this.food += 10;
        }
    }
}
