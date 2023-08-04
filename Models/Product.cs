namespace ASPWEBAPI.Models;

public class Product
{
    public long Id { get; set; }
    public string? Name { get; set; } 
    public string? Desription {get; set;}
    public decimal? Price {get; set;} 
    public bool? isAvailiable {get; set;} = true;
}
   