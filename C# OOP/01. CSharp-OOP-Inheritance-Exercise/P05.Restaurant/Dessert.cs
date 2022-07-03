namespace Restaurant
{
    public class Dessert : Food
    {
        public Dessert(string name, decimal price, double grams, double Calories)
            : base(name, price, grams)
        {
            this.Calories = Calories;
        }

        public double Calories { get; set; }

    }
}
