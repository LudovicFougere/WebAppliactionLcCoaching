using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplicationLcCoaching.Models
{
    public partial class Lc_coatchingContext : DbContext
    {
        public Lc_coatchingContext()
        {
        }

        public Lc_coatchingContext(DbContextOptions<Lc_coatchingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FormulaireInit> FormulaireInit { get; set; }
        public virtual DbSet<FormulaireSeance> FormulaireSeance { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=WIN-0SGFEHT92S6\\SQLEXPRESS;Initial Catalog=Lc_coatching;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormulaireInit>(entity =>
            {
                entity.ToTable("Formulaire_Init");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AgeMetabolique).HasColumnName("Age_metabolique");

                entity.Property(e => e.GraisseVisterale).HasColumnName("Graisse_visterale");

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.MasseMusculaire).HasColumnName("Masse_musculaire");

                entity.Property(e => e.MasseOsseuse).HasColumnName("Masse_osseuse");

                entity.Property(e => e.PourcentGraisseCorporelle).HasColumnName("Pourcent_graisse_corporelle");

                entity.Property(e => e.PourcentHydratation).HasColumnName("Pourcent_hydratation");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FormulaireInit)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Init");
            });

            modelBuilder.Entity<FormulaireSeance>(entity =>
            {
                entity.ToTable("Formulaire_Seance");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BilanSanguin)
                    .HasColumnName("Bilan_sanguin")
                    .HasMaxLength(50);

                entity.Property(e => e.IdUser).HasColumnName("Id_user");

                entity.Property(e => e.NiveauTechniqueMusculation).HasColumnName("Niveau_technique_musculation");

                entity.Property(e => e.Photos).HasColumnType("image");

                entity.Property(e => e.TestConditionPhysique).HasColumnName("Test_condition_physique");

                entity.Property(e => e.TourTaille)
                    .HasColumnName("Tour_taille")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.FormulaireSeance)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Seance");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sexe)
                    .IsRequired()
                    .HasMaxLength(10);
            });
        }
    }
}
