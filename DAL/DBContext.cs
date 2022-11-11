using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Model;

namespace DAL
{
    public class DBContext : LogDBContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            Database.SetCommandTimeout(new TimeSpan(0, 5, 0));
        }

        public DBContext(DbContextOptions<DBContext> options, IHttpContextAccessor context) : base(options, context)
        {
            Database.SetCommandTimeout(new TimeSpan(0, 5, 0));
        }

        public DbSet<Address> Address { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<Model.File> File { get; set; }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasKey(person => new 
                {
                    person.Address,
                    person.Contact,
                    person.Photo
                });

            modelBuilder.Entity<User>()
                .HasOne(user => user.Person);
        }
    }
}