using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController
    {
        private readonly ProductContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ProductContext context, ILogger<ProductController> logger)
        {
            _context = context;
            _logger = logger;
        }


        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Products.Find(x=> true).ToListAsync();
        }

    }
}
