using System.ComponentModel.DataAnnotations;

namespace Frontend.Web.Models;

public class Product {
    public int ProductID { get; set; }
    
    [Display(Name = "Product Name")]
    [Required(ErrorMessage = "{0} must be filled in")]
    public string ProductName { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string Category { get; set; }
    
    [Display(Name = "Unit price")]
    public decimal UnitPrice { get; set; }
    
    [Range(0, int.MaxValue)]
    [Display(Name = "Units in stock")]
    public int UnitsInStock { get; set; }
    
    public bool Discontinued { get; set; }
}