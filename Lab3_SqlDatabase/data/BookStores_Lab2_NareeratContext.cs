using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Lab3_SqlDatabase
{
    public class BookStores_Lab2_NareeratContext : DbContext
    {
        private string connectionString;

        public BookStores_Lab2_NareeratContext()
        {
        }

        public BookStores_Lab2_NareeratContext(DbContextOptions<BookStores_Lab2_NareeratContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BooksAuthor> BooksAuthors { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderdetail> Orderdetails { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<TitlarPerFörfattaren> TitlarPerFörfattarens { get; set; }
        public virtual DbSet<TopThreeCustomer> TopThreeCustomers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder();
                builder.AddJsonFile("appsettings.json");
                var configuration = builder.Build();
                connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Author");

                entity.Property(e => e.AuthorId);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.IsbnId)
                    .HasName("PK__Books__7C97DEAA8979A9C7");

                entity.Property(e => e.IsbnId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN_Id")
                    .IsFixedLength();

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Books__CategoryI__286302EC");
            });

            modelBuilder.Entity<BooksAuthor>(entity =>
            {
                entity.HasKey(e => new {e.BaId, e.IsbnId, e.AuthorId})
                    .HasName("PK__Books_Au__EF4550CE5E94A813");

                entity.ToTable("Books_Authors");

                entity.Property(e => e.BaId).HasColumnName("BA_Id");

                entity.Property(e => e.IsbnId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN_Id")
                    .IsFixedLength();

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BooksAuthors)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Books_Aut__Autho__52593CB8");

                entity.HasOne(d => d.Isbn)
                    .WithMany(p => p.BooksAuthors)
                    .HasForeignKey(d => d.IsbnId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Books_Aut__ISBN___534D60F1");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.ShippedDate).HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Orders__Customer__36B12243");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK__Orders__ShopId__37A5467C");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__StaffId__38996AB5");
            });

            modelBuilder.Entity<Orderdetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Discount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.IsbnId)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN_Id")
                    .IsFixedLength();

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Orderdetails)
                    .HasForeignKey(d => d.IsbnId)
                    .HasConstraintName("FK__Orderdeta__ISBN___4F7CD00D");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Orderdetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Orderdeta__Order__4E88ABD4");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.ShopId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Staffs__A9D10534C1793132")
                    .IsUnique();

                entity.Property(e => e.StaffId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Staffs__ManagerI__33D4B598");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK__Staffs__ShopId__32E0915F");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => new {e.ShopId, e.IsbnId})
                    .HasName("PK__Stocks__D00C2A2317330D0F");

                entity.Property(e => e.IsbnId)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("ISBN_Id")
                    .IsFixedLength();

                entity.HasOne(d => d.Isbn)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.IsbnId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Stocks__ISBN_Id__47DBAE45");
            });

            modelBuilder.Entity<TitlarPerFörfattaren>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TitlarPerFörfattaren");

                entity.Property(e => e.InventoryValue)
                    .HasMaxLength(4000)
                    .HasColumnName("Inventory value");

                entity.Property(e => e.Name)
                    .HasMaxLength(102)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TopThreeCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TopThreeCustomers");

                entity.Property(e => e.AmountOrders).HasColumnName("Amount Orders");

                entity.Property(e => e.Name)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("Total Amount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
           
        }
    }
}