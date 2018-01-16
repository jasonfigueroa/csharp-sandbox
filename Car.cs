namespace hwapp
{
    internal class Car
    {
        private string model;
        private string make;
        private string color;
        private string year;
        
        public string Make
        {
            get { return make;}
            set { make = value;}
        }
        public string Model
        {
            get { return model;}
            set { model = value;}
        }
        public string Color
        {
            get { return color;}
            set { color = value;}
        }
        public string Year
        {
            get { return year;}
            set { year = value;}
        }        
        
        public Car(string make, string model, string color, string year)
        {
            this.make = make;
            this.model = model;
            this.color = color;
            this.year = year;
        }
    }
}