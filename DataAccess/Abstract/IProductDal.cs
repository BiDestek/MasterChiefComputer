﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface IProductDal : IEntityRepository<Product>, IAsyncEntityRepository<Product>
{
    Product GetById(int entity);
    Task<Product> GetByIdAsync(int entity);
    List<ProductDto> GetProductDetails();
    Task<List<ProductDto>> GetProductDetailsAsync();
    List<Product> GetAllByProductNameWhereConstain(string entity);
    Task<List<Product>> GetAllByProductNameWhereConstainAsync(string entity);
    List<ProductDto> GetAllByProductNameOrCategoryNameWhereConstain(string constain);
    Task<List<ProductDto>> GetAllByProductNameOrCategoryNameWhereConstainAsync(string constain);
}