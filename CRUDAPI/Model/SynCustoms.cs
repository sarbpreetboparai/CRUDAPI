namespace CRUDAPI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SynCustoms : DbContext
    {
        public SynCustoms()
            : base("name=SynCustoms")
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Street)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Province)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.Postal)
                .IsFixedLength();
        }
    }
}
