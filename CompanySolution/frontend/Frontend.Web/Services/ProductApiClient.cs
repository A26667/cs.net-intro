using System.Net;
using Frontend.Web.Models;

namespace Frontend.Web.Services;

public class ProductApiClient {
    private readonly HttpClient client;
    
    public ProductApiClient(HttpClient hc) {
        client = hc;
    }

    public async Task<List<Product>> GetAllAsync() {
        return await client.GetFromJsonAsync<List<Product>>("api/products")
            ?? new List<Product>();
    }
    
    public async Task<Product?> GetByIdAsync(int id) {
        // "using" clears this from memory when the method finishes
        using var response = await client.GetAsync($"api/products/{id}");

        if (response.StatusCode == HttpStatusCode.NotFound)
            return null;
        
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<Product>();
    }
}
