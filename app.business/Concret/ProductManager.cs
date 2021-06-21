using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork work;
        public ProductManager(IUnitOfWork _unitOfWork)
        {
            work = _unitOfWork;
        }

        public Task<OprationResult> CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public OprationResult DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ReturnedClass<Product>> GetAll()
        {
            try
            {
                return await work.Products.GetAll();
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Product>(OprationResult.canceled);                
            }
        }

        public Task<ReturnedClass<Product>> GetByEntityAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnedClass<Product>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public OprationResult UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}