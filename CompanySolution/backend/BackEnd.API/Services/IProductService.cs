using BackEnd.API.Models;

namespace BackEnd.API.Services;

public interface IProductService {
    // return all products asynchronously
    Task<IEnumerable<Product>> GetAllAsync();
    // return one product by its identifier, or null if it does not exist
    Task<Product?> GetByIdAsync(int id);
    // add a new product and return the created object
    Task<Product> AddAsync(Product product);
    // delete a product and return whether the operation succeeded
    Task<bool> DeleteAsync(int id);
    // update an existing product and return the updated value
    Task<Product?> UpdateAsync(int id, Product product);
    // search products by a term, such as the product name
    Task<IEnumerable<Product>> SearchAsync(string term);
}
