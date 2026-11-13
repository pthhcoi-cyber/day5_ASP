using System.ComponentModel.DataAnnotations;

namespace day5_ASP.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên category")]
        public string? Name { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
