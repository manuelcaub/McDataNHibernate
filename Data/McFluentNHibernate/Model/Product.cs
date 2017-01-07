namespace Data.McFluentNHibernate.Model
{
    public class Product
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
    }
}
