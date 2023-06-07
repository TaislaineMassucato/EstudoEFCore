using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudoEFCore.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post> builder)
        {
               // Tabela
        builder.ToTable("Category");

        // Chave Primária
        builder.HasKey(x => x.Id);

        // Identity
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        // Propriedades
        builder.Property(x => x.Title)
            .IsRequired() // Not Null
            .HasColumnName("Title") // Nome Coluna
            .HasColumnType("NVARCHAR") // Tipo coluna
            .HasMaxLength(80); // Max caracteres

        builder.Property(x => x.Summary)
            .IsRequired() // Not Null
            .HasColumnName("Summary") // Nome Coluna
            .HasColumnType("NVARCHAR(MAX)"); // Tipo coluna

        builder.Property(x => x.Body)
            .IsRequired() // Not Null
            .HasColumnName("Body") // Nome Coluna
            .HasColumnType("NVARCHAR(MAX)"); // Tipo coluna

        builder.Property(x => x.Slug)
            .IsRequired() // Not Null
            .HasColumnName("Slug") // Nome Coluna
            .HasColumnType("VARCHAR") // Tipo coluna
            .HasMaxLength(80); // Max caracteres

        builder.Property(x => x.CreateDate)
            .IsRequired() // Not Null
            .HasColumnName("CreateDate"); // Nome Coluna

        builder.Property(x => x.LastUpdateDate)
            .IsRequired() // Not Null
            .HasColumnName("LastUpdateDate") // Nome Coluna
            .HasColumnType("SMALLDATETIME")
            .HasDefaultValueSql("GETDATE()");
            //.HasDefaultValue(DateTime.Now.ToUniversalTime());

        // Relacionamentos
        builder.HasOne(x => x.Author)
                .WithMany(x => x.Posts)
                .HasConstraintName("FK_Post_Author")
                .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Category)
                .WithMany(x => x.Posts)
                .HasConstraintName("FK_Post_Category")
                .OnDelete(DeleteBehavior.Cascade);

        

        // Índices
        builder.HasIndex(x => x.Slug, "IX_Post_Slug")
               .IsUnique();
        }
    }
}