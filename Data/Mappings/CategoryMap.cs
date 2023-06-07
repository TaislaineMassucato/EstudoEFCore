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
        }
    }
}