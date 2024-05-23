using ECommerce.Models.Enums;

namespace ECommerce.Models.Abstracts.Interfaces
{
    public interface IEntity<T>
    {
        //Id: verinin veritabanında PK olarak tanımlanmasını temsil edecek.
        //MasterId: verinin UI'da ya da tedarikçilerde görüntülenmesi için kullanılacak.

        public int ID { get; set; }
        public T MasterId { get; set; }

        //Ortak özellikler

        //Created
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }


        //Updated
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }

        public bool IsActive { get; set; }
        public DataStatus Status { get; set; }
    }
}
