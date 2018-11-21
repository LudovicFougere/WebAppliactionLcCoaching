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
            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateLimite)
                    .HasColumnName("Date_limite")
                    .HasColumnType("datetime");

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
