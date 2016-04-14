namespace CTRails.Entities
{
    public abstract class Entity
    {
        public int ID { get; protected set; }

        public bool IsDirty { get; set; }
        public bool IsNew { get; set; }
        public bool IsDeleted { get; set; }

        //Constructor
        protected Entity( int id)
        {
            Id = id;
        }
    }
}
