using System;
using KS.Entities;
using KS.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KS.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Media> Images { get; set; }
        public DbSet<TaxClass> TaxClasses { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Stock> Stocks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Product

            #region Products

            // modelBuilder.Entity<Product>()
            //     .HasData(
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         },
            //         new Product
            //         {
            //             Id = 1, Name = "Хлопковая футболка", Slug = "Хлопковая футболка",
            //             ShortDescription =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Description =
            //                 "Футболка универсального серого оттенка — классическая вещь в повседневном гардеробе. Для создания модели использовали мягкое хлопковое джерси. Материал слегка тянется и комфортно облегает тело. Единственный декор — миниатюрная знаковая вышивка в виде игрока в поло. Ральф Лорен включил изделие в классическую коллекцию.",
            //             Specification = null,
            //             SpecialPriceStart = null,
            //             SpecialPriceEnd = null,
            //             Price = 3825,
            //             OldPrice = 4290,
            //             IsFeatured = true,
            //             IsAllowToOrder = true,
            //             Brand = new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
            //             TaxClass = new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
            //             UnitType = UnitType.Thing,
            //             GenderType = GenderType.Female,
            //             CreationDate = DateTime.Now
            //         }
            //     );

            #endregion

            //Brand
            modelBuilder.Entity<Brand>()
                .HasData(
                    new Brand {Id = 1, Name = "Nike", Description = "Nike", CreationDate = DateTime.Now},
                    new Brand {Id = 2, Name = "Adidas", Description = "Adidas", CreationDate = DateTime.Now},
                    new Brand {Id = 3, Name = "Polo", Description = "Polo", CreationDate = DateTime.Now},
                    new Brand {Id = 4, Name = "Balmain", Description = "Balmain", CreationDate = DateTime.Now},
                    new Brand
                    {
                        Id = 5, Name = "Bottega Veneta", Description = "Bottega Veneta", CreationDate = DateTime.Now
                    },
                    new Brand
                    {
                        Id = 6, Name = "Brunello Cucinelli", Description = "Brunello Cucinelli",
                        CreationDate = DateTime.Now
                    },
                    new Brand {Id = 7, Name = "Jil Sander", Description = "Jil Sander", CreationDate = DateTime.Now},
                    new Brand {Id = 8, Name = "Gucci", Description = "Gucci", CreationDate = DateTime.Now},
                    new Brand
                    {
                        Id = 9, Name = "Ralph Lauren", Description = "Ralph Lauren", CreationDate = DateTime.Now
                    },
                    new Brand
                    {
                        Id = 10, Name = "Alexander McQueen", Description = "Alexander McQueen",
                        CreationDate = DateTime.Now
                    },
                    new Brand {Id = 11, Name = "Prada", Description = "Prada", CreationDate = DateTime.Now},
                    new Brand {Id = 12, Name = "Off-White", Description = "Off-White", CreationDate = DateTime.Now},
                    new Brand {Id = 13, Name = "Versace", Description = "Versace", CreationDate = DateTime.Now}
                );

            //Category
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category {Id = 1, Name = "Блуза", Slug = "Блуза", CreationDate = DateTime.Now},
                    new Category {Id = 2, Name = "Рубашка", Slug = "Рубашка", CreationDate = DateTime.Now},
                    new Category {Id = 3, Name = "Брюки", Slug = "Брюки", CreationDate = DateTime.Now},
                    new Category {Id = 4, Name = "Бриджи", Slug = "Бриджи", CreationDate = DateTime.Now},
                    new Category {Id = 5, Name = "Лосины", Slug = "Лосины", CreationDate = DateTime.Now},
                    new Category {Id = 6, Name = "Джинсы", Slug = "Джинсы", CreationDate = DateTime.Now},
                    new Category {Id = 7, Name = "Шорты", Slug = "Шорты", CreationDate = DateTime.Now},
                    new Category {Id = 8, Name = "Юбка", Slug = "Юбка", CreationDate = DateTime.Now},
                    new Category {Id = 9, Name = "Комбинезон", Slug = "Комбинезон", CreationDate = DateTime.Now},
                    new Category {Id = 10, Name = "Джемпер", Slug = "Джемпер", CreationDate = DateTime.Now},
                    new Category {Id = 11, Name = "Свитер", Slug = "Свитер", CreationDate = DateTime.Now},
                    new Category {Id = 12, Name = "Гольф", Slug = "Гольф", CreationDate = DateTime.Now},
                    new Category {Id = 13, Name = "Пуловер", Slug = "Пуловер", CreationDate = DateTime.Now},
                    new Category {Id = 14, Name = "Кофта", Slug = "Кофта", CreationDate = DateTime.Now},
                    new Category {Id = 15, Name = "Кардиган", Slug = "Кардиган", CreationDate = DateTime.Now},
                    new Category {Id = 16, Name = "Жакет", Slug = "Жакет", CreationDate = DateTime.Now},
                    new Category {Id = 17, Name = "Пиджак", Slug = "Пиджак", CreationDate = DateTime.Now},
                    new Category {Id = 18, Name = "Футболка", Slug = "Футболка", CreationDate = DateTime.Now},
                    new Category {Id = 19, Name = "Майка", Slug = "Майка", CreationDate = DateTime.Now},
                    new Category {Id = 20, Name = "Поло", Slug = "Поло", CreationDate = DateTime.Now},
                    new Category
                    {
                        Id = 21, Name = "Футболка с длинным рукавом", Slug = "Футболка с длинным рукавом",
                        CreationDate = DateTime.Now
                    },
                    new Category {Id = 22, Name = "Тенниска", Slug = "Тенниска", CreationDate = DateTime.Now},
                    new Category {Id = 23, Name = "Реглан", Slug = "Реглан", CreationDate = DateTime.Now},
                    new Category {Id = 24, Name = "Платье", Slug = "Платье", CreationDate = DateTime.Now},
                    new Category {Id = 25, Name = "Ветровка", Slug = "Ветровка", CreationDate = DateTime.Now}
                );

            //TaxClass
            modelBuilder.Entity<TaxClass>()
                .HasData(
                    new TaxClass {Id = 1, Name = "0%", Interest = 0, CreationDate = DateTime.Now},
                    new TaxClass {Id = 2, Name = "10%", Interest = 10, CreationDate = DateTime.Now},
                    new TaxClass {Id = 3, Name = "18%", Interest = 18, CreationDate = DateTime.Now}
                );

            //Warehouse
            modelBuilder.Entity<Warehouse>()
                .HasData(
                    new Warehouse
                    {
                        Id = 1, Name = "Основной", Vendor = "452000", Address = "г. Белебей, ул. Красноармейская 125",
                        CreationDate = DateTime.Now
                    },
                    new Warehouse
                    {
                        Id = 2, Name = "Основной (запасной)", Vendor = "450000", Address = "г. Уфа, ул. Советская 25",
                        CreationDate = DateTime.Now
                    }
                );

            //ApplicationUser
            ApplicationUser user = new ApplicationUser()
            {
                Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                UserName = "Admin",
                Email = "admin@gmail.com",
                LockoutEnabled = false,
                PhoneNumber = "1234567890"
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "admin@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "Admin1234"),
                    SecurityStamp = string.Empty
                }
            );

            //IdentityRole
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1",
                    NormalizedName = "Admin"
                },
                new IdentityRole()
                {
                    Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "User", ConcurrencyStamp = "2",
                    NormalizedName = "User"
                }
            );

            //RoleUser
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                    {RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "b74ddd14-6340-4840-95c2-db12554843e5"}
            );
        }
    }
}