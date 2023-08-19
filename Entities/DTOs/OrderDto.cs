using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class OrderDto : IDto
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerCity { get; set; }

        public int ProductId { get; set; }
        public string? ProductName { get; set; }  
        public decimal? UnitPrice { get; set; }
        
        public short? Quantity { get; set; }
        public float? Discount { get; set; }

        public DateTime? OrderDate { get; set; }
       

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }

        public int SupplierId { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? SupplierCity { get; set; }
        public string? Phone { get; set; }


    }
}
