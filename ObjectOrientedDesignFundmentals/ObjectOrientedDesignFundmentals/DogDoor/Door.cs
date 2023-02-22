using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignFundmentals.DogDoor
{
    public class Door
    {
        public bool Open { get; set; }
        public void OpenDoor()
        {
            Open = true;
            Console.WriteLine("Door is now open!");

            //automatically closing the door after 2second 
            Thread.Sleep(2000);
            CloseDoor();
        }
        public void CloseDoor()
        {
            Open = false;
            Console.WriteLine("Door is now closed!");
        }
        public bool IsOpen()
        {
            return Open;
        }
    }
}
