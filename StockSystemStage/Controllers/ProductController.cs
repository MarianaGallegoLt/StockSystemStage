using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StockSystem.Core.Core.FirstVersion;
using StockSystem.DataAccess.Context;
using StockSystem.Entities.DTOs;
using StockSystem.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockSystemStage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController: ControllerBase
    {
        private readonly ProductCore productCore;

        public ProductController(SqlServerContext context, ILogger<Product> logger, IMapper mapper)
        {
            productCore = new ProductCore(context, logger, mapper);
        }


        //GET PRODUCT
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await productCore.GetProduct();
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await productCore.GetProduct(id);
        }


        //POST/CREATE PRODUCT
        [HttpPost]
        public async Task<Product> Post([FromBody] ProductCreateDTO product)
        {
            return await productCore.CreateProduct(product);
        }


        //PUT/UPDATE PRODUCT
        [HttpPut]
        public async Task<bool> Put([FromBody] Product product)
        {
            return await productCore.UpdateProduct(product);
        }
    }
}
