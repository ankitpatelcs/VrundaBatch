using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EDMCrud.EDM
{
    public partial class CompanyContext : DbContext
    {
        public CompanyContext()
        {
        }

        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblcity> Tblcities { get; set; }
        public virtual DbSet<Tblemployee> Tblemployees { get; set; }
        public virtual DbSet<Tblstate> Tblstates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-52IAUQR;Database=Company;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Tblcity>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("tblcity");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasColumnName("city_name");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Tblcities)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_tblcity_state_id");
            });

            modelBuilder.Entity<Tblemployee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK_employee");

                entity.ToTable("tblemployee");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .HasColumnName("address");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("f_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(150)
                    .HasColumnName("hobbies");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Profileimg)
                    .HasMaxLength(150)
                    .HasColumnName("profileimg");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Tblemployees)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_employee_tblcity");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Tblemployees)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_employee_state_id");
            });

            modelBuilder.Entity<Tblstate>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("tblstate");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .HasColumnName("state_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
