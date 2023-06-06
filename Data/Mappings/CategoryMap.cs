using Microsoft.EntityFrameworkCore;
using EFCore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudoEFCore.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
        }
    }
}