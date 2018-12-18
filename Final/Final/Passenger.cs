namespace Final
{
    class Passenger
    {
        private string Name { get; set; }
        private double Weight { get; set; }

        public Passenger (string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetWeight()
        {
            return Weight;
        }
    }
}
