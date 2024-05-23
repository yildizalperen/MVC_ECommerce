using ECommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Abstracts
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Supplier GetSupplierById(int id);
        Task<string> AddSupplierAsync(Supplier supplier);
        Task<string> DeleteSupplierAsync(Supplier supplier);
        Task<string> UpdateSupplierAsync(Supplier supplier);
        IEnumerable<Supplier> GetActiveSuppliers();
        IEnumerable<Supplier> GetPassiveSuppliers();
        Task<string> DestroySupplierAsync(Supplier supplier);
    }
}
