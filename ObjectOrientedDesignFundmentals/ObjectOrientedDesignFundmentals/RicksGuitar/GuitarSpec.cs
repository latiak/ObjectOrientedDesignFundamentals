using ObjectOrientedDesignFundmentals.Enums;

namespace ObjectOrientedDesignFundmentals.Inventory.RicksGuitar
{
    public class GuitarSpec
    {
        public Builders Builder { get; set; }
        public string Model { get; set; }
        public Types Type { get; set; }
        public Woods BackWood { get; set; }
        public Woods TopWood { get; set; }
        public int NumberOfString { get; set; }
        public GuitarSpec(Builders builder, string model, Types type, Woods backWood, Woods topWood, int numberOfString)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumberOfString = numberOfString;
        }
        public bool Matches(GuitarSpec guitarSpec)
        {
            if (Model != guitarSpec.Model)
                return false;
            if (TopWood != guitarSpec.TopWood)
                return false;
            if (BackWood != guitarSpec.BackWood)
                return false;
            if (Builder != guitarSpec.Builder)
                return false;
            if (Type != guitarSpec.Type)
                return false;

            return true;
        }
    }

}
