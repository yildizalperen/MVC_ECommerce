using ECommerce.Models.Abstracts.Interfaces;
using ECommerce.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Models.Base
{
    public class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            MasterId = Guid.NewGuid();
            Status = DataStatus.INSERTED;
            IsActive = true;
            CreatedComputerName = Dns.GetHostName();
            CreatedIpAddress = Dns.GetHostByName(CreatedComputerName).AddressList[1].ToString();
        }
        public int ID { get; set; }
        public Guid MasterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIpAddress { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedComputerName { get; set; }
        public string? UpdatedIpAddress { get; set; }
        public bool IsActive { get; set; }
        public DataStatus Status { get; set; }
    }
}
