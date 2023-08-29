using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkiStore.Core.Entities;
using SkiStore.Data;

namespace SkiStore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController: ControllerBase
{
    private readonly StoreContext _context;

    public ProductsController(StoreContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await _context.Products.ToListAsync();
        return products;
    }
    
    [HttpGet("{id}")]
    public async Task<Product?> GetProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        return product;
    }
    
}