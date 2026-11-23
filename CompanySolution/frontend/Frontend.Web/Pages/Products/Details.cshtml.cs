using Frontend.Web.Models; 
using Frontend.Web.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend.Web.Pages.Products;

public class DetailsModel : PageModel {
    private readonly ProductApiClient _products;

    public DetailsModel(ProductApiClient products) {
        _products = products;
    }
    
    public Product? Item { get; private set; }
    public string? ErrorMessage { get; private set; }
    
    public async Task<IActionResult> OnGetAsync(int id) {
        try {
            Item = await _products.GetByIdAsync(id);
            return Item is null ? NotFound() : Page();
        }
        catch (Exception ex) {
            ErrorMessage = "Product details could not be loaded. Please try again later.";
            return Page();
        }
    }
}