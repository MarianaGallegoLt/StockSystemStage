using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StockSystem.DataAccess.Context;
using StockSystem.Entities.DTOs;
using StockSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Core.Core.FirstVersion
{
    public class ProductCore
    {
        private readonly SqlServerContext context;
        private readonly ILogger<Product> logger;
        //private readonly ErrorHandler<Vacancy> errorHandler;
        private readonly IMapper mapper;

        public ProductCore(SqlServerContext context, ILogger<Product> logger, IMapper mapper)
        {
            this.context = context;
            this.logger = logger;
            //errorHandler = new ErrorHandler<Vacancy>(logger);          
            this.mapper = mapper;
        }


        //GET PRODUCT
        public async Task<List<Product>> GetProduct()
        {
            return await context.Product.ToListAsync();
        }

        public async Task<Product> GetProduct(int productId)
        {
            return await context.Product.FindAsync(productId);
        }


        //CREATE PRODUCT
        public async Task<Product> CreateProduct(ProductCreateDTO entity)
        {
            Product newProduct = new();

            newProduct.productName = entity.productName;
            newProduct.productPrice = entity.productPrice;
            newProduct.productDescription = entity.productDescription;
            newProduct.productUnitOfMeasurement = entity.productUnitOfMeasurement;
            newProduct.productBarCode = entity.productBarCode;
            newProduct.productStockBalance = entity.productStockBalance;
            newProduct.productStatus = entity.productStatus;

            var newProductCreated = context.Product.Add(newProduct);

            await context.SaveChangesAsync();

            return newProductCreated.Entity;
        }


        //UPDATE PRODUCT
        public async Task<bool> UpdateProduct(Product productTobeUpdated)
        {
            Product product = context.Product.Find(productTobeUpdated.productId);
            product.productPrice = productTobeUpdated.productPrice;
            product.productStockBalance= productTobeUpdated.productStockBalance;
            product.productStatus = productTobeUpdated.productStatus;

            context.Product.Update(product);

            int recordsAffeted = await context.SaveChangesAsync();

            return (recordsAffeted == 1);
        }
    }
}
