namespace CTRails.Entities
{
    public abstract class Entity
    {
        public int ID { get; protected set; }



        public Entity(int id)
        {
            ID = id;
        }
    }
}
