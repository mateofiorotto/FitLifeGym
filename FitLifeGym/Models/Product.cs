using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitLifeGym.Models;



public class Product
{
    public int Id { get; set; }

    [Required, Column(TypeName = "varchar(100)")]
    public string Name { get; set; }

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    [Range(0.01, 99999.99, ErrorMessage = "Price must be between 0.01 and 99,999.99")]
    public decimal Price { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Stock cannot be negative")]
    public int Stock { get; set; }

    [Required, Column(TypeName = "varchar(100)")]
    public string Type { get; set; }

    [Display(Name = "Image URL")]
    [Column(TypeName = "varchar(200)")]
    public string? ImageUrl { get; set; }
}
