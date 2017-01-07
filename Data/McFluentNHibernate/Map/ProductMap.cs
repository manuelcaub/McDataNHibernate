using Data.McFluentNHibernate.Model;
using FluentNHibernate.Mapping;

namespace Data.FluentNHibernate.Map
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Product");
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
        }
    }
}
