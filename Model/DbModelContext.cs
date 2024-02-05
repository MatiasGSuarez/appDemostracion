using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace Model
{
    public class DbModelContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //IConfigurationRoot configuration = new ConfigurationBuilder()                              
                //              .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                //              .AddJsonFile("appsettings.json")
                //              .Build();
                //var str = configuration.GetConnectionString("DefaultConnection");
                
                //var str = "Server=DESKTOP-LL1QIFB; Database=DemoDatabase; User=sa; Password=123456; MultipleActiveResultSets=true; TrustServerCertificate=True";
                var str = "Server=DESKTOP-C4CFVU4\\MSSQLSERVER2; Database=DemoDatabase; User=sa; Password=123456; MultipleActiveResultSets=true; TrustServerCertificate=True";
                if (string.IsNullOrEmpty(str))
                    throw new Exception("No hay string de conexión...");

                optionsBuilder
                    .UseSqlServer(str)
                    .EnableSensitiveDataLogging()
                    .ConfigureWarnings(c => c.Log((RelationalEventId.CommandExecuting, LogLevel.Debug)));

                optionsBuilder.UseLazyLoadingProxies();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasKey(x => new { x.Id });

            //Elimina ciclos de eliminacion en cascada
            var cascadeFKs = modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetForeignKeys()).Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            modelBuilder.Seed();
        }

        public DbSet<Person> Person { get; set; }

    }
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                SeedPerson(modelBuilder);
            }
        }
        private static void SeedPerson(ModelBuilder modelBuilder)
        {
            var persons = new List<Person>();

            for (int i = 1; i <= 40; i++)
            {
                persons.Add(new Person
                {
                    Id = i,
                    Name = $"Customer {i}",
                    Creation = DateTime.Now,
                    Age = i+15,
                    Address = "All Boys",
                    DocumentNumber = "41016905",
                    PhoneNumber = "3644680649",
                    Surname =  $"Customer {i}"

                });
            }

            // Agregar los objetos Customer al modelBuilder utilizando HasData
            foreach (var person in persons)
            {
                modelBuilder.Entity<Person>().HasData(person);
            }
        }
    }
}
