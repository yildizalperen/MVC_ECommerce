using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Services.Abstracts;
using ECommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Concretes
{
    public class ProductService : IProductService
    {
        private readonly IBaseService<Product> _productRepository;

        public ProductService(IBaseService<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<string> AddProductAsync(Product product)
        {
            return await _productRepository.Add(product);
        }

        public async Task<string> DeleteProductAsync(Product product)
        {
            return await _productRepository.Delete(product);
        }

        public async Task<string> DestroyProductAsync(Product product)
        {
            return await _productRepository.DestroyData(product);
        }

        public IEnumerable<Product> GetActiveProducts()
        {
            return _productRepository.GetActives();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetPassiveProducts()
        {
            return _productRepository.GetPassives();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public async Task<string> UpdateProductAsync(Product product)
        {
            return await _productRepository.Update(product);
        }
    }
}
