using System.Data.Entity;
using TODO.WebApi.Models.Entities;

namespace TODO.WebApi.Models.DataAccess
{
    public class MyContext : DbContext
    {
        public DbSet<User> UserSet { get; set; }

        public MyContext(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .HasKey(user => user.Id);
            modelBuilder.Entity<User>().Property(user => user.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(user => user.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(user => user.MiddleName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(user => user.MobilePhone).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<User>().Property(user => user.Email).IsRequired().HasMaxLength(50);

            Configuration.LazyLoadingEnabled = false;

            Database.SetInitializer(new MyInitializer());

            base.OnModelCreating(modelBuilder);
        }
    }
}