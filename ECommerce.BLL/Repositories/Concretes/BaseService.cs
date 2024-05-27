using Bogus.DataSets;
using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.DAL.Context;
using ECommerce.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Concretes
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;
        private DbSet<T> _entities;

        public BaseService(ECommerceContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        /// <summary>
        /// Veritabanına yeni veri eklenmesini sağlar
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> Add(T entity)
        {
            try
            {
                entity.Status = ECommerce.Models.Enums.DataStatus.INSERTED;
                await _entities.AddAsync(entity);
                await _context.SaveChangesAsync();
                return "İşlem Başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }


        /// <summary>
        /// Veritabanından veriyi direkt kaldırmaz, durumunu deleted olarak değiştirir.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> Delete(T entity)
        {
            try
            {
                entity.Status = ECommerce.Models.Enums.DataStatus.DELETED;
                await Update(entity);
                await _context.SaveChangesAsync();
                return "Silme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Veritabanın veriyi tamamen kaldırır.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> DestroyData(T entity)
        {
            _entities.Remove(entity);
            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return "Veri Kalıcı Olarak silindi";
            }
            else
            {
                return "bir hata meydana geldi";
            }
        }

        /// <summary>
        /// Aktif olarak tanımlanan verileri liste halinde teslim eder.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetActives()
        {
            return _entities.Where(x => x.IsActive == true).ToList();
        }

        /// <summary>
        /// Veritabanındaki bütün verileri teslim eder.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        /// <summary>
        /// parametre üzerinden alınan id'yi bularak veritabanından o id ile ilişkili veriyi getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetById(int id)
        {
            try
            {
                return _entities.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Pasif olarak tanımlanan verileri liste halinde teslim eder.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetPassives()
        {
            return _entities.Where(x => x.IsActive == false).ToList();
        }

        /// <summary>
        /// Veritabanındaki veriyi günceller.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> Update(T entity)
        {
            string result = "";
            int result2;

            switch (entity.Status)
            {

                case ECommerce.Models.Enums.DataStatus.UPDATED:

                    entity.Status = ECommerce.Models.Enums.DataStatus.UPDATED;
                    _entities.Entry(entity).State = EntityState.Modified;
                    result2 = await _context.SaveChangesAsync();
                    if (result2 > 0)
                    {
                        result = "Veri Güncellendi";
                    }
                    else
                    {
                        result = "Bir Hata Oluştu!";
                    }
                    break;
                case ECommerce.Models.Enums.DataStatus.DELETED:

                    entity.Status = ECommerce.Models.Enums.DataStatus.DELETED;
                    _entities.Entry(entity).State = EntityState.Modified;
                    _context.SaveChanges();
                    result2 = await _context.SaveChangesAsync();
                    if (result2 > 0)
                    {
                        result = "Veri Silindi";
                    }
                    else
                    {
                        result = "Bir Hata Oluştu!";
                    }
                    break;
                case ECommerce.Models.Enums.DataStatus.INSERTED:
                    entity.Status = ECommerce.Models.Enums.DataStatus.UPDATED;
                    _entities.Entry(entity).State = EntityState.Modified;
                    _context.SaveChanges();
                    result2 = await _context.SaveChangesAsync();
                    if (result2 > 0)
                    {
                        result = "Veri Güncellendi";
                    }
                    else
                    {
                        result = "Bir Hata Oluştu!";
                    }
                    break;

            }

            return result;
        }
    }
}
