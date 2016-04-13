namespace CTRails.Entities
{
    public class Track : Entity
    {
        //Fields
        public int Number { get; private set; }


        //Constructor
        public Track(int id, int number)
            : base (id)
        {
            Number = number;
        }
    }
}
