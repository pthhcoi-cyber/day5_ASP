
using day5_ASP.Models;

namespace day5_ASP.data
{
    public class SeedData
    {
        // Danh sách Category
        public static List<Category> categories = new List<Category>
        {
            new Category { Id = 1, Name = "Áo thun", Description = "Các loại áo thun nam nữ" },
            new Category { Id = 2, Name = "Áo sơ mi", Description = "Áo sơ mi công sở và thời trang" },
            new Category { Id = 3, Name = "Áo khoác", Description = "Áo khoác mùa đông và áo gió" },
            new Category { Id = 4, Name = "Quần jeans", Description = "Quần jeans nam nữ" },
            new Category { Id = 5, Name = "Quần kaki", Description = "Quần kaki công sở và thường ngày" },
            new Category { Id = 6, Name = "Váy", Description = "Các loại váy thời trang nữ" },
            new Category { Id = 7, Name = "Giày thể thao", Description = "Giày sneaker nam nữ" },
            new Category { Id = 8, Name = "Giày da", Description = "Giày da công sở" },
            new Category { Id = 9, Name = "Dép", Description = "Dép đi trong nhà và ngoài trời" },
            new Category { Id = 10, Name = "Túi xách", Description = "Túi xách thời trang" },
            new Category { Id = 11, Name = "Balo", Description = "Balo đi học và du lịch" },
            new Category { Id = 12, Name = "Phụ kiện", Description = "Mũ, thắt lưng và phụ kiện thời trang" }
        };

        // Danh sách Product
        public static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Áo thun Basic Cotton",
                Description = "Áo thun cotton thoáng mát",
                Price = 150000,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Name = "Áo thun Oversize",
                Description = "Áo thun form rộng phong cách trẻ",
                Price = 220000,
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Name = "Áo sơ mi Oxford",
                Description = "Áo sơ mi nam dài tay",
                Price = 350000,
                CategoryId = 2
            },
            new Product
            {
                Id = 4,
                Name = "Áo khoác Bomber",
                Description = "Áo khoác bomber thời trang",
                Price = 550000,
                CategoryId = 3
            },
            new Product
            {
                Id = 5,
                Name = "Quần Jeans Slim Fit",
                Description = "Quần jeans nam dáng ôm",
                Price = 420000,
                CategoryId = 4
            },
            new Product
            {
                Id = 6,
                Name = "Quần Kaki Regular",
                Description = "Quần kaki nam dáng suông",
                Price = 380000,
                CategoryId = 5
            },
            new Product
            {
                Id = 7,
                Name = "Váy Hoa Vintage",
                Description = "Váy nữ họa tiết hoa",
                Price = 450000,
                CategoryId = 6
            },
            new Product
            {
                Id = 8,
                Name = "Giày Sneaker Urban",
                Description = "Giày thể thao phong cách năng động",
                Price = 690000,
                CategoryId = 7
            },
            new Product
            {
                Id = 9,
                Name = "Giày Da Oxford",
                Description = "Giày da nam công sở",
                Price = 850000,
                CategoryId = 8
            },
            new Product
            {
                Id = 10,
                Name = "Dép Quai Ngang",
                Description = "Dép quai ngang chống trượt",
                Price = 180000,
                CategoryId = 9
            },
            new Product
            {
                Id = 11,
                Name = "Túi Xách Mini",
                Description = "Túi xách nữ nhỏ gọn",
                Price = 490000,
                CategoryId = 10
            },
            new Product
            {
                Id = 12,
                Name = "Balo Canvas",
                Description = "Balo vải canvas đi học",
                Price = 320000,
                CategoryId = 11
            },
            new Product
            {
                Id = 13,
                Name = "Mũ Lưỡi Trai",
                Description = "Mũ thời trang unisex",
                Price = 120000,
                CategoryId = 12
            },
            new Product
            {
                Id = 14,
                Name = "Thắt Lưng Da",
                Description = "Thắt lưng da nam",
                Price = 250000,
                CategoryId = 12
            },
            new Product
            {
                Id = 15,
                Name = "Áo Khoác Denim",
                Description = "Áo khoác jeans phong cách đường phố",
                Price = 620000,
                CategoryId = 3
            }
        };
    }
}
