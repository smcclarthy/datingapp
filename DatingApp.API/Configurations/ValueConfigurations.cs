using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatingApp.API.Configurations
{
    public class ValueConfigurations:IEntityTypeConfiguration<Value>
    {
        public void Configure(EntityTypeBuilder<Value>builder){
            //Table Name
            builder.ToTable("Values");
            //Table Column Id
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id)
             .ValueGeneratedOnAdd()
                .HasColumnName("id");
              

            //Table Column Name
            builder.Property(x=>x.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnType("varchar(60)")
                .HasColumnName("value_name");


                
        }
    }
}