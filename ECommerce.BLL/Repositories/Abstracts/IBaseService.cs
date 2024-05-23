using ECommerce.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Abstracts
{
    public interface IBaseService<T> where T : BaseEntity
    {
        //List
        IEnumerable<T> GetAll(); //IEnumrable: içerisinde barındırılan listeyi ve istenildiği zaman o liste içerisinde de ayrı bir listeyi barındıran özelleştirilmiş bir interface. İçerisinde barındırmış olduğu liste elemanını döngüye ihtiyaç duymadan geriye döndürülmesini sağlar.

        //List: içerisinde tekil değerler barındırır. Döngüye ihtiyaç duyar.

        //GetById
        T GetById(int id);

        //Active
        IEnumerable<T> GetActives();

        //Passive
        IEnumerable<T> GetPassives();

        //Destroy
        Task<string> DestroyData(T entity);

        //Create
        Task<string> Add(T entity);

        //Update
        Task<string> Update(T entity);

        //Delete
        Task<string> Delete(T entity);
    }
}
