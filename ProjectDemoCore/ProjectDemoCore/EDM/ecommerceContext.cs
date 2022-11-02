using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjectDemoCore.EDM
{
    public partial class ecommerceContext : DbContext
    {
        public ecommerceContext()
        {
        }

        public ecommerceContext(DbContextOptions<ecommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<Tblcart> Tblcarts { get; set; }
        public virtual DbSet<Tblcity> Tblcities { get; set; }
        public virtual DbSet<Tblorder> Tblorders { get; set; }
        public virtual DbSet<Tblorderdetail> Tblorderdetails { get; set; }
        public virtual DbSet<Tblproduct> Tblproducts { get; set; }
        public virtual DbSet<Tblstate> Tblstates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-52IAUQR;Database=ecommerce;Integrated Security=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__tblAdmin__4A311D2FCE177020");

                entity.ToTable("tblAdmin");

                entity.Property(e => e.AdminId).HasColumnName("Admin_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("f_name");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .HasColumnName("l_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__B9BE370FF20CAA73");

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("f_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .HasColumnName("l_name");

                entity.Property(e => e.Mobile)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("mobile");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.ProfileImg).HasColumnName("profile_img");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__tblUser__city_id__3F466844");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__tblUser__state_i__3E52440B");
            });

            modelBuilder.Entity<Tblcart>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.ToTable("tblcart");

                entity.Property(e => e.CartId).HasColumnName("cart_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Tblcarts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblcart_productid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tblcarts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblcart_userid");
            });

            modelBuilder.Entity<Tblcity>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__tblcity__031491A8C240BDF4");

                entity.ToTable("tblcity");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasColumnName("city_name");

                entity.Property(e => e.StateId).HasColumnName("state_id");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Tblcities)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__tblcity__state_i__3B75D760");
            });

            modelBuilder.Entity<Tblorder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("tblorder");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("datetime")
                    .HasColumnName("orderdate");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tblorders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblorder_user_id");
            });

            modelBuilder.Entity<Tblorderdetail>(entity =>
            {
                entity.HasKey(e => e.OrderdetailsId);

                entity.ToTable("tblorderdetails");

                entity.Property(e => e.OrderdetailsId).HasColumnName("orderdetails_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Tblorderdetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblorderdetails_order_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Tblorderdetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblorderdetails_product_id");
            });

            modelBuilder.Entity<Tblproduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tblproduct");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Image1).HasColumnName("image1");

                entity.Property(e => e.Image2).HasColumnName("image2");

                entity.Property(e => e.Image3).HasColumnName("image3");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .HasColumnName("product_name");

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<Tblstate>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK__tblstate__81A47417455502CB");

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
