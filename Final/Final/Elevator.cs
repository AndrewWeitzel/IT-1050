namespace Final
{
    using System.Collections;

    class Elevator
    {

        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            MaxWeight = maxWeight;
            Occupants = new Passenger[maxOccupants];
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double currentWeight = 0;
            foreach (var occupant in Occupants)
            {
                currentWeight += occupant.GetWeight();
            }
            return currentWeight;
        }

        public bool IsOverMaxCapacity()
        {
            bool isOverMaxCapacity = true;
            if (MaxWeight>=GetCurrentWeight())
            {
                isOverMaxCapacity = false;
            }
            if(MaxWeight<GetCurrentWeight())
            {
                isOverMaxCapacity = true;
            }
            return isOverMaxCapacity;
        }
    }
}
