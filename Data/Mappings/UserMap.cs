using Microsoft.EntityFrameworkCore;
using EFCore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstudoEFCore.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Tabela
            builder.ToTable("User");

            //Chave Primaria
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();

            //colunas
            builder.Property(x => x.Name)
                     .HasColumnName("Name")
                     .HasColumnType("NVARCHAR")
                    .HasMaxLength(80)
                   
                    .IsRequired();

            builder.Property(x => x.Email)
                    .HasColumnName("Email")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(80)
                    .IsRequired();

            builder.Property(x => x.PasswordHash)
                    .HasColumnName("PasswordHash")
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(255)
                   .IsRequired();

            builder.Property(x => x.Bio)
                    .HasColumnName("Bio")
                    .HasColumnType("TEXT")
                    .IsRequired();
            
            builder.Property(x => x.Image)
                    .HasColumnName("Image")
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(2000)
                    .IsRequired();
            
            
            builder.Property(x => x.Slug)
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(80)
                    .HasColumnName("Slug")
                    .IsRequired();
                    
            //Index (Indices)
            builder.HasIndex(x => x.Slug, "IX_User_Slug")
                    .IsUnique();

        }
    }

}