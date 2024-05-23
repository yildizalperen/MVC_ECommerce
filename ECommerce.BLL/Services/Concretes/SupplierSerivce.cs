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
    public class SupplierSerivce : ISupplierService
    {
        private readonly IBaseService<Supplier> _supplierRepository;

        public SupplierSerivce(IBaseService<Supplier> supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public async Task<string> AddSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.Add(supplier);
        }

        public async Task<string> DeleteSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.Delete(supplier);
        }

        public async Task<string> DestroySupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.DestroyData(supplier);
        }

        public IEnumerable<Supplier> GetActiveSuppliers()
        {
            return _supplierRepository.GetActives();
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAll();
        }

        public IEnumerable<Supplier> GetPassiveSuppliers()
        {
            return _supplierRepository.GetPassives();
        }

        public Supplier GetSupplierById(int id)
        {
            return _supplierRepository.GetById(id);
        }

        public async Task<string> UpdateSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.Update(supplier);
        }
    }
}
