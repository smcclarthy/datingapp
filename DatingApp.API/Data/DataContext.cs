using DatingApp.API.Configurations;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base (options) {}

        public DbSet<Value>Values{get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.HasDefaultSchema("DatingApp");
            modelBuilder.ApplyConfiguration(new ValueConfigurations());
            base.OnModelCreating(modelBuilder);
        }
    }
}