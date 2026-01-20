
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MelodyHub_2._0.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Името е задължително")]
        [Display(Name = "Инструмент")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 100000)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Цена (лв.)")]
        public decimal Price { get; set; }

        [Display(Name = "Категория")]
        public string Category { get; set; } = "Музикален инструмент";

        [Display(Name = "URL на снимка")]
        public string ImageUrl { get; set; } = "https://images.unsplash.com/photo-1511379938547-c1f69419868d?w=500";

        [Display(Name = "Описание")]
        public string Description { get; set; } = "Висок клас музикално оборудване.";
    }
}