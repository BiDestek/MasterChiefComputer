using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;


namespace Entities.Concrete
{
    public class ProductImage : IEntity
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public string? ImagePath { get; set; }
        public string? ImageName { get; set; }
        public DateTime? Date { get; set; }
    }
}
