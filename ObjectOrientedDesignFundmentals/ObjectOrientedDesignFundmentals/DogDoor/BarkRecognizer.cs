using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignFundmentals.DogDoor
{
    public class BarkRecognizer
    {
        public Door door {get;set;}

        public void Recognize(string bark)
        {
            Console.WriteLine($"Heard the bark {bark}");
            door.OpenDoor();

        }

    }
}
