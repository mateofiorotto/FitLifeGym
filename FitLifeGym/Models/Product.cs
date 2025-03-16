namespace FitLifeGymGym.Models;

//defining class product (model)
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Type { get; set; } //can be a list with fixed options ? Like equipment, supply, etc..
    public string? ImageUrl { get; set; }
}
