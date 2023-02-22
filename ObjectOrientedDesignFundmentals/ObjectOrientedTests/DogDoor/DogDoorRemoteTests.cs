using Moq;
using ObjectOrientedDesignFundmentals.DogDoor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedTests.DogDoor
{
    public class DogDoorRemoteTests
    {
        [Fact]
        public void OpenDoor_ShouldOpenTheDoor()
        {
            //Arrange 
            Door door = new Door();
            door.Open = false;
            Remote remote = new Remote(door);
            
            //Act
            remote.Operate(door);
        }
    }
}
