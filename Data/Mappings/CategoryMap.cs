using Microsoft.EntityFrameworkCore;
using EFCore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudoEFCore.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //Tabela
            builder.ToTable("Category");

            //Chave Primaria
            builder.HasKey(X => X.Id);

            //Identity
            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn(); 

            //Propriedades
            builder .Property(x => x.Name)
                    .IsRequired() //Not Null
                    .HasColumnName("Name") //Nome Coluna
                    .HasColumnType("NVARCHAR") //Tipo coluna
                    .HasMaxLength(80); //Max caracter

            builder .Property(x => x.Slug)
                    .IsRequired() //Not Null
                    .HasColumnName("Name") //Nome Coluna
                    .HasColumnType("VARCHAR") //Tipo coluna
                    .HasMaxLength(80); //Max caracter

            //Index (Indices)
            builder.HasIndex(x => x.Slug, "IX_Category_Slug")
                    .IsUnique();
            
        }
    }
}