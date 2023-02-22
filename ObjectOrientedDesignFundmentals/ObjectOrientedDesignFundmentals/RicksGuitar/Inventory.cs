using ObjectOrientedDesignFundmentals.Enums;
using ObjectOrientedDesignFundmentals.Inventory.RicksGuitar;

namespace ObjectOrientedDesignFundmentals.RicksGuitar
{
    public class Inventory
    {
        private List<Guitar> Guitars { get; set; }
        public Inventory(List<Guitar> guitars)
        {
            Guitars = guitars;
        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec guitarSpecs)
        {
            var guitar = new Guitar(serialNumber, price, guitarSpecs);
            Guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serailNumber)
        {
            foreach (var guitar in Guitars)
            {
                if (guitar.SerialNumber.Equals(serailNumber))
                    return guitar;
            }
            return null;
        }
        public List<Guitar> SearchGuitar(Guitar guitarToBeSearched)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            foreach (var guitar in Guitars)
            {
                if (guitar.GuitarSpec.Matches(guitarToBeSearched.GuitarSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
    }
}
