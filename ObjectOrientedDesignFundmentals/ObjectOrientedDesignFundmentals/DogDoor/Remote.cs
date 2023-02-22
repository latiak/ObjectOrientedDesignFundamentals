namespace ObjectOrientedDesignFundmentals.DogDoor
{
    public class Remote
    {
        public Door Door{ get; set; }

        public Remote(Door door)
        {
            Door = door;
        }
        public void Operate(Door door)
        {
            if (door.IsOpen())
                door.CloseDoor();
            else
                door.OpenDoor();

        }
    }
}
