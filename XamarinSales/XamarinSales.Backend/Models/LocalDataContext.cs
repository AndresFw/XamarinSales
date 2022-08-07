namespace XamarinSales.Backend.Models
{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<XamarinSales.Common.Models.Product> Products { get; set; }
    }
}