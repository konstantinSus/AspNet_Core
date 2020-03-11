using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace myProjectApi.Models
{
    public partial class ToyotaAutoContext : DbContext
    {
        public ToyotaAutoContext()
        {
        }

        public ToyotaAutoContext(DbContextOptions<ToyotaAutoContext> options): base(options){
        }

        public virtual DbSet<Auto> Auto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-618CNCF\\MSSQLSERVER01;Database=ToyotaAuto;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassEuro)
                    .IsRequired()
                    .HasColumnName("class_euro")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkAuto)
                    .IsRequired()
                    .HasColumnName("mark_auto")
                    .HasMaxLength(50);

                entity.Property(e => e.Massa).HasColumnName("massa");

                entity.Property(e => e.NumberAuto).HasColumnName("number_auto");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
