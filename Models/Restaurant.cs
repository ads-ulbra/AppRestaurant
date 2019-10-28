namespace AppRestaurant.Models
{
    public class Restaurant
    {
        public Restaurant()
        {

        }

        public Restaurant(int id, string name, string address, int number, string city, string state)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.number = number;
            this.city = city;
            this.state = state;
        }

        public int id { get; set; }

        public string name { get; set; }

        public string address { get; set; }

        public int number { get; set; }

        public string city { get; set; }

        public string state { get; set; }
    }
}