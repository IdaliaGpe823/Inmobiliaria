namespace ProyectoInmobiliaria.Data
{
    using MySql.Data.MySqlClient;
    using ProyectoInmobiliaria.Models;
    using System.Data.Entity;
    using System.Data.SqlClient;

    using System.Data.Entity;

    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=MySqlConnection")
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rental>()
                .HasRequired(r => r.Department)
                .WithMany(d => d.Rentals)
                .HasForeignKey(r => r.DepartmentId);
        }
    }


}
