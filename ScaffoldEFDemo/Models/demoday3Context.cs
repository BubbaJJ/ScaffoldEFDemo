using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ScaffoldEFDemo.Models
{
    public partial class demoday3Context : DbContext
    {
        public demoday3Context()
        {
        }

        public demoday3Context(DbContextOptions<demoday3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AllFromGothenburg> AllFromGothenburgs { get; set; }
        public virtual DbSet<AllInfo> AllInfos { get; set; }
        public virtual DbSet<BackupAddress> BackupAddresses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Selfjoin> Selfjoins { get; set; }
        public virtual DbSet<UniqueCrash> UniqueCrashes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDatum> UserData { get; set; }
        public virtual DbSet<Username> Usernames { get; set; }
        public virtual DbSet<UsernameHistory> UsernameHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;database=demoday3;user id=sa;password=P@ssw0rd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("addresses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.PostalCode).HasColumnName("postal_code");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(100)
                    .HasColumnName("street_address");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__addresses__city___267ABA7A");
            });

            modelBuilder.Entity<AllFromGothenburg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("all_from_gothenburg");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<AllInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("allInfo");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasColumnName("city_name");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.PostalCode).HasColumnName("postal_code");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(100)
                    .HasColumnName("street_address");
            });

            modelBuilder.Entity<BackupAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("backup_addresses");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.PostalCode).HasColumnName("postal_code");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(50)
                    .HasColumnName("street_address");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .HasColumnName("city_name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("orders");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<Selfjoin>(entity =>
            {
                entity.ToTable("selfjoin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .HasColumnName("full_name");

                entity.Property(e => e.ManagerId).HasColumnName("manager_id");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<UniqueCrash>(entity =>
            {
                entity.ToTable("uniqueCrash");

                entity.HasIndex(e => e.Name, "UQ__uniqueCr__72E12F1B69E9BAD9")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<UserDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("user_data");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<Username>(entity =>
            {
                entity.ToTable("usernames");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.Username1)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UsernameHistory>(entity =>
            {
                entity.ToTable("username_history");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionPerformed)
                    .HasMaxLength(1)
                    .HasColumnName("action_performed")
                    .IsFixedLength(true);

                entity.Property(e => e.DateChanged)
                    .HasColumnType("datetime")
                    .HasColumnName("date_changed")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewUsername)
                    .HasMaxLength(50)
                    .HasColumnName("new_username");

                entity.Property(e => e.OldUsername)
                    .HasMaxLength(50)
                    .HasColumnName("old_username");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
