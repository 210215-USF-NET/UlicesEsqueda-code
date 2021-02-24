using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ToHDL.Entities
{
    public partial class BatchDBContext : DbContext
    {
        public BatchDBContext()
        {
        }

        public BatchDBContext(DbContextOptions<BatchDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ElementType> ElementTypes { get; set; }
        public virtual DbSet<Hero> Heroes { get; set; }
        public virtual DbSet<Superpower> Superpowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:newherodatabase.database.windows.net,1433;Initial Catalog=BatchDB;Persist Security Info=False;User ID=uesqueda;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ElementType>(entity =>
            {
                entity.ToTable("elementTypes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ElementType1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("elementType");
            });

            modelBuilder.Entity<Hero>(entity =>
            {
                entity.ToTable("heroes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ElementType).HasColumnName("elementType");

                entity.Property(e => e.HeroName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("heroName");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.HasOne(d => d.ElementTypeNavigation)
                    .WithMany(p => p.Heroes)
                    .HasForeignKey(d => d.ElementType)
                    .HasConstraintName("FK__heroes__elementT__04E4BC85");
            });

            modelBuilder.Entity<Superpower>(entity =>
            {
                entity.ToTable("superpowers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Damage).HasColumnName("damage");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Hero).HasColumnName("hero");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.HeroNavigation)
                    .WithMany(p => p.Superpowers)
                    .HasForeignKey(d => d.Hero)
                    .HasConstraintName("FK__superpower__hero__07C12930");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
