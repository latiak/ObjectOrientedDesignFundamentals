using ObjectOrientedDesignFundmentals.Enums;
using ObjectOrientedDesignFundmentals.Inventory.RicksGuitar;
using ObjectOrientedDesignFundmentals.RicksGuitar;

namespace ObjectOrientedTests.RicksGuitar
{
    public class InventoryTests
    {
        [Fact]
        public void SearchGuitar_WhenThereIsMatchingRequest_ShouldReturnProperResponse()
        {
            //Arrange
            List<Guitar> guitars = new List<Guitar>();
            var guitarSpec = new GuitarSpec(Builders.FENDER, "12.3", Types.A, Woods.TOPWOOD, Woods.BACKWOOD, 2);
            var guitar = new Guitar("123", 12.2, guitarSpec);
            var guitar1 = new Guitar("124", 15.2, guitarSpec);

            guitars.Add(guitar);
            guitars.Add(guitar1);

            var inventory = new Inventory(guitars);

            //Act 
            var response = inventory.SearchGuitar(guitar);

            //Assert
            Assert.Equal(2, response.Count());
        }
    }
}