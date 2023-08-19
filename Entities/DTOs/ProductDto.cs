using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class ProductDto : IDto
    {
        public int ProductId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public string? ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public string? SupplierCompanyName { get; set; }
        public string? SupplierContactName { get; set; }
        public string? SupplierTitle { get; set; }
        public string? SupplierCity { get; set; }
        public string? MBChipsetType { get; set; }
        public string? MBCPUSocketType { get; set; }
        public string? MBCPUSeries { get; set; }
        public string? RAMType { get; set; }
        public string? RAMCapacity { get; set; }
        public string? GPURAMType { get; set; }
        public string? GPURAMCapacity { get; set; }
        public string? GPURAMInterface { get; set; }
        public string? PCCaseType { get; set; }
        public int? InPSU { get; set; }
        public string? PSUPower { get; set; }
        public string? PSUModularityStatus { get; set; }
        public string? ProcessorBrand { get; set; }
        public string? ProcessorSeries { get; set; }
        public string? ProcessorModel { get; set; }
        public string? GPUManufacturer { get; set; }
        public string? GPUModel { get; set; }
        public string? RAMBrand { get; set; }
        public string? HardDiskType { get; set; }
        public string? DiskCapacity { get; set; }
        public string? OperatingSystem { get; set; }
        public string? ScreenSize { get; set; }
        public string? RearCameraResolution { get; set; }
        public string? FrontCameraResolution { get; set; }
        public int? SIMCardSupport { get; set; }
        public int? WifiWlanSupport { get; set; }
        public string? MaxResolution { get; set; }
        public string? ResponseTime { get; set; }
        public string? ConnectionType { get; set; }
        public int? InMouse { get; set; }
        public string? HeadphoneType { get; set; }
        public int? InMicrophone { get; set; }
        public string? ChannelsCount { get; set; }
        public string? ConnectionInterface { get; set; }
        public string? VideoResolution { get; set; }
        public string? UPSType { get; set; }
        public string? VAValue { get; set; }
    }
}
