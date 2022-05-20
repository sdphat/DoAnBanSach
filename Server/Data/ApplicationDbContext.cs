using DoAnBanSach.Server.Models;
using DoAnBanSach.Shared;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DoAnBanSach.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Khách hàng", NormalizedName = "USER", Id = "cus", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new IdentityRole { Name = "Nhân viên", NormalizedName = "EMPLOYEE", Id = "emp", ConcurrencyStamp = Guid.NewGuid().ToString() }
            );
            modelBuilder.Entity<OrderDetail>().HasKey(od => new { od.OrderId, od.BookId });
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Sách trong nước" },
                new Category { CategoryId = 2, Name = "Sách nước ngoài" }
            );

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { PublisherId = 1, Name = "NXB Văn Học"},
                new Publisher { PublisherId = 2, Name = "NXB Kim Đồng" },
                new Publisher { PublisherId = 3, Name = "NXB Hội Nhà Văn" },
                new Publisher { PublisherId = 4, Name = "NXB Thế Giới" }
            );

            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "Paulo Coelho" },
                new Author { AuthorId = 2, Name = "Benjamin Graham" },
                new Author { AuthorId = 3, Name = "José Mauro de Vasconcelos" },
                new Author { AuthorId = 4, Name = "Khotudien" },
                new Author { AuthorId = 5, Name = "Nhiều tác giả" },
                new Author { AuthorId = 6, Name = "Andrea Hirata" },
                new Author { AuthorId = 7, Name = "Nguyễn Nhật Ánh" },
                new Author { AuthorId = 8, Name = "Khaled Hosseini " },
                new Author { AuthorId = 9, Name = "Johanna Spyri, Elena Selivano " },
                new Author { AuthorId = 10, Name = "Shinkai Makoto " }
    

            );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Amount = 50, AuthorId = 1, PublisherId = 3, CategoryId = 2, ImageURL = "/image_195509_1_36793.jpg", Title = "Nhà Giả Kim (Tái Bản 2020)", Price = 79000, ImportDateTime = DateTime.Now.AddDays(-1) },
                new Book { BookId = 2, Amount = 52, AuthorId = 3, PublisherId = 4, CategoryId = 1, ImageURL = "/image_195509_1_21748.jpg", Title = "Cây Cam Ngọt Của Tôi", Price = 91000, ImportDateTime = DateTime.Now.AddDays(-3) },
                new Book { BookId = 3, Amount = 57, AuthorId = 2, PublisherId = 4, CategoryId = 1, ImageURL = "/image_195509_1_44030.jpg", Title = "Những người khốn khổ", Price = 85000, ImportDateTime = DateTime.Now.AddDays(-7) },
                new Book { BookId = 4, Amount = 12, AuthorId = 4, PublisherId = 2, CategoryId = 1, ImageURL = "/image_195509_1_00004.jpg", Title = "Từ Điển Tiếng Em", Price = 45000, ImportDateTime = DateTime.Now.AddMonths(-2) },
                new Book { BookId = 5, Amount = 64, AuthorId = 2, PublisherId = 4, CategoryId = 2, ImageURL = "/image_195509_1_75552.jpg", Title = "Không Gia Đình", Price = 259000, ImportDateTime = DateTime.Now.AddDays(-373) },
                new Book { BookId = 6, Amount = 80, AuthorId = 5, PublisherId = 2, CategoryId = 1, ImageURL = "/image_195509_1_00006.jpg", Title = "Chuyện Kể Rằng Có Nàng Và Tôi", Price = 65000, ImportDateTime = DateTime.Now.AddHours(-6) },
                new Book { BookId = 7, Amount = 93, AuthorId = 6, PublisherId = 3, CategoryId = 2, ImageURL = "/image_195509_1_36366.jpg", Title = "Chiến binh cầu vồng", Price = 70000, ImportDateTime = DateTime.Now.AddHours(-23) },
                new Book { BookId = 8, Amount = 69, AuthorId = 2, PublisherId = 1, CategoryId = 1, ImageURL = "/image_195509_1_00008.jpg", Title = "Hai Số Phận", Price = 147000, ImportDateTime = DateTime.Now.AddHours(-44) },
                new Book { BookId = 9, Amount = 52, AuthorId = 8, PublisherId = 1, CategoryId = 1, ImageURL = "/image_195509_1_18176.jpg", Title = "Ngàn mặt trời rực rỡ (Tái bản 2019)", Price = 127000, ImportDateTime = DateTime.Now.AddDays(-3) },
                new Book { BookId = 10, Amount = 57, AuthorId = 7, PublisherId = 2, CategoryId = 1, ImageURL = "/image_195509_1_00010.jpg", Title = "Mắt Biếc", Price = 100000, ImportDateTime = DateTime.Now.AddDays(-7) },
                new Book { BookId = 11, Amount = 12, AuthorId = 9, PublisherId = 1, CategoryId = 1, ImageURL = "/image_195509_1_40336.jpg", Title = "Heidi", Price = 37900, ImportDateTime = DateTime.Now.AddMonths(-2) },
                new Book { BookId = 12, Amount = 64, AuthorId = 5, PublisherId = 2, CategoryId = 1, ImageURL = "/image_195509_1_00012.jpg", Title = "Bến Xe", Price = 60000, ImportDateTime = DateTime.Now.AddDays(-373) },
                new Book { BookId = 13, Amount = 80, AuthorId = 10, PublisherId = 4, CategoryId = 1, ImageURL = "/image_195509_1_70753.jpg", Title = "Your name (Tái bản)", Price = 312000, ImportDateTime = DateTime.Now.AddHours(-6) },
                new Book { BookId = 14, Amount = 93, AuthorId = 7, PublisherId = 2, CategoryId = 1, ImageURL = "/image_195509_1_00014.jpg", Title = "Cảm Ơn Người Lớn", Price = 88000, ImportDateTime = DateTime.Now.AddHours(-23) },
                new Book { BookId = 15, Amount = 69, AuthorId = 7, PublisherId = 2, CategoryId = 1, ImageURL = "/image_195509_1_00015.jpg", Title = "Con Chim Xanh Biếc Bay Về", Price = 120000, ImportDateTime = DateTime.Now.AddHours(-44) }

            );

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "admin",
                UserName = "admin",
                Email = "admin@gmail.com",
                PasswordHash = hasher.HashPassword(null, "admin")
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "emp",
                UserId = "admin"
            });

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}