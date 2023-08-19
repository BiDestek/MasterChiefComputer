using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MasterChiefContext>, IProductDal
    {
        public List<ProductDto> GetAllByProductNameOrCategoryNameWhereConstain(string constain)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join s in context.Suppliers
                             on p.SupplierId equals s.SupplierId
                             where p.ProductName.Contains(constain) | c.CategoryName.Contains(constain)

                             select new ProductDto
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 CategoryDescription = c.Description,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock,
                                 UnitsOnOrder = p.UnitsOnOrder,
                                 SupplierCompanyName = s.CompanyName,
                                 SupplierContactName = s.ContactName,
                                 SupplierTitle = s.ContactTitle,
                                 SupplierCity = s.SupplierCity,
                                 MBChipsetType = p.MBChipsetType,
                                 MBCPUSocketType = p.MBCPUSocketType,
                                 MBCPUSeries = p.MBCPUSeries,
                                 RAMType = p.RAMType,
                                 RAMCapacity = p.RAMCapacity,
                                 GPURAMType = p.GPURAMType,
                                 GPURAMCapacity = p.GPURAMCapacity,
                                 GPURAMInterface = p.GPURAMInterface,
                                 PCCaseType = p.PCCaseType,
                                 InPSU = p.InPSU,
                                 PSUPower = p.PSUPower,
                                 PSUModularityStatus = p.PSUModularityStatus,
                                 ProcessorBrand = p.ProcessorBrand,
                                 ProcessorSeries = p.ProcessorSeries,
                                 ProcessorModel = p.ProcessorModel,
                                 GPUManufacturer = p.GPUManufacturer,
                                 GPUModel = p.GPUModel,
                                 RAMBrand = p.RAMBrand,
                                 HardDiskType = p.HardDiskType,
                                 DiskCapacity = p.DiskCapacity,
                                 OperatingSystem = p.OperatingSystem,
                                 ScreenSize = p.ScreenSize,
                                 RearCameraResolution = p.RearCameraResolution,
                                 FrontCameraResolution = p.FrontCameraResolution,
                                 SIMCardSupport = p.SIMCardSupport,
                                 WifiWlanSupport = p.WifiWlanSupport,
                                 MaxResolution = p.MaxResolution,
                                 ResponseTime = p.ResponseTime,
                                 ConnectionType = p.ConnectionType,
                                 InMouse = p.InMouse,
                                 HeadphoneType = p.HeadphoneType,
                                 InMicrophone = p.InMicrophone,
                                 ChannelsCount = p.ChannelsCount,
                                 ConnectionInterface = p.ConnectionInterface,
                                 VideoResolution = p.VideoResolution,
                                 UPSType = p.UPSType,
                                 VAValue = p.VAValue
                             };

                return result.ToList();
            }
        }

        public Task<List<ProductDto>> GetAllByProductNameOrCategoryNameWhereConstainAsync(string constain)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join s in context.Suppliers
                             on p.SupplierId equals s.SupplierId
                             where p.ProductName.Contains(constain) | c.CategoryName.Contains(constain)

                             select new ProductDto
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 CategoryDescription = c.Description,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock,
                                 UnitsOnOrder = p.UnitsOnOrder,
                                 SupplierCompanyName = s.CompanyName,
                                 SupplierContactName = s.ContactName,
                                 SupplierTitle = s.ContactTitle,
                                 SupplierCity = s.SupplierCity,
                                 MBChipsetType = p.MBChipsetType,
                                 MBCPUSocketType = p.MBCPUSocketType,
                                 MBCPUSeries = p.MBCPUSeries,
                                 RAMType = p.RAMType,
                                 RAMCapacity = p.RAMCapacity,
                                 GPURAMType = p.GPURAMType,
                                 GPURAMCapacity = p.GPURAMCapacity,
                                 GPURAMInterface = p.GPURAMInterface,
                                 PCCaseType = p.PCCaseType,
                                 InPSU = p.InPSU,
                                 PSUPower = p.PSUPower,
                                 PSUModularityStatus = p.PSUModularityStatus,
                                 ProcessorBrand = p.ProcessorBrand,
                                 ProcessorSeries = p.ProcessorSeries,
                                 ProcessorModel = p.ProcessorModel,
                                 GPUManufacturer = p.GPUManufacturer,
                                 GPUModel = p.GPUModel,
                                 RAMBrand = p.RAMBrand,
                                 HardDiskType = p.HardDiskType,
                                 DiskCapacity = p.DiskCapacity,
                                 OperatingSystem = p.OperatingSystem,
                                 ScreenSize = p.ScreenSize,
                                 RearCameraResolution = p.RearCameraResolution,
                                 FrontCameraResolution = p.FrontCameraResolution,
                                 SIMCardSupport = p.SIMCardSupport,
                                 WifiWlanSupport = p.WifiWlanSupport,
                                 MaxResolution = p.MaxResolution,
                                 ResponseTime = p.ResponseTime,
                                 ConnectionType = p.ConnectionType,
                                 InMouse = p.InMouse,
                                 HeadphoneType = p.HeadphoneType,
                                 InMicrophone = p.InMicrophone,
                                 ChannelsCount = p.ChannelsCount,
                                 ConnectionInterface = p.ConnectionInterface,
                                 VideoResolution = p.VideoResolution,
                                 UPSType = p.UPSType,
                                 VAValue = p.VAValue
                             };

                return result.ToListAsync();
            }
        }

        public List<Product> GetAllByProductNameWhereConstain(string entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                return context.Products.Where(p => p.ProductName.Contains(entity)).ToList();
            }
        }

        public Task<List<Product>> GetAllByProductNameWhereConstainAsync(string entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                return context.Products.Where(p => p.ProductName.Contains(entity)).ToListAsync();
            }
        }

        public Product GetById(int entity)
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {                
                var result = from p in context.Products
                             where p.ProductId == entity

                             select new Product
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock,
                                 UnitsOnOrder = p.UnitsOnOrder,
                                 MBChipsetType = p.MBChipsetType,
                                 MBCPUSocketType = p.MBCPUSocketType,
                                 MBCPUSeries = p.MBCPUSeries,
                                 RAMType = p.RAMType,
                                 RAMCapacity = p.RAMCapacity,
                                 GPURAMType = p.GPURAMType,
                                 GPURAMCapacity = p.GPURAMCapacity,
                                 GPURAMInterface = p.GPURAMInterface,
                                 PCCaseType = p.PCCaseType,
                                 InPSU = p.InPSU,
                                 PSUPower = p.PSUPower,
                                 PSUModularityStatus = p.PSUModularityStatus,
                                 ProcessorBrand = p.ProcessorBrand,
                                 ProcessorSeries = p.ProcessorSeries,
                                 ProcessorModel = p.ProcessorModel,
                                 GPUManufacturer = p.GPUManufacturer,
                                 GPUModel = p.GPUModel,
                                 RAMBrand = p.RAMBrand,
                                 HardDiskType = p.HardDiskType,
                                 DiskCapacity = p.DiskCapacity,
                                 OperatingSystem = p.OperatingSystem,
                                 ScreenSize = p.ScreenSize,
                                 RearCameraResolution = p.RearCameraResolution,
                                 FrontCameraResolution = p.FrontCameraResolution,
                                 SIMCardSupport = p.SIMCardSupport,
                                 WifiWlanSupport = p.WifiWlanSupport,
                                 MaxResolution = p.MaxResolution,
                                 ResponseTime = p.ResponseTime,
                                 ConnectionType = p.ConnectionType,
                                 InMouse = p.InMouse,
                                 HeadphoneType = p.HeadphoneType,
                                 InMicrophone = p.InMicrophone,
                                 ChannelsCount = p.ChannelsCount,
                                 ConnectionInterface = p.ConnectionInterface,
                                 VideoResolution = p.VideoResolution,
                                 UPSType = p.UPSType,
                                 VAValue = p.VAValue


                             };
                return result.SingleOrDefault(p => p.ProductId == entity);
            }
        }

        public Task<Product> GetByIdAsync(int entity)
        {
            MasterChiefContext context = new MasterChiefContext();
            {
                var result = from p in context.Products
                             where p.ProductId == entity

                             select new Product
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock,
                                 UnitsOnOrder = p.UnitsOnOrder,
                                 MBChipsetType = p.MBChipsetType,
                                 MBCPUSocketType = p.MBCPUSocketType,
                                 MBCPUSeries = p.MBCPUSeries,
                                 RAMType = p.RAMType,
                                 RAMCapacity = p.RAMCapacity,
                                 GPURAMType = p.GPURAMType,
                                 GPURAMCapacity = p.GPURAMCapacity,
                                 GPURAMInterface = p.GPURAMInterface,
                                 PCCaseType = p.PCCaseType,
                                 InPSU = p.InPSU,
                                 PSUPower = p.PSUPower,
                                 PSUModularityStatus = p.PSUModularityStatus,
                                 ProcessorBrand = p.ProcessorBrand,
                                 ProcessorSeries = p.ProcessorSeries,
                                 ProcessorModel = p.ProcessorModel,
                                 GPUManufacturer = p.GPUManufacturer,
                                 GPUModel = p.GPUModel,
                                 RAMBrand = p.RAMBrand,
                                 HardDiskType = p.HardDiskType,
                                 DiskCapacity = p.DiskCapacity,
                                 OperatingSystem = p.OperatingSystem,
                                 ScreenSize = p.ScreenSize,
                                 RearCameraResolution = p.RearCameraResolution,
                                 FrontCameraResolution = p.FrontCameraResolution,
                                 SIMCardSupport = p.SIMCardSupport,
                                 WifiWlanSupport = p.WifiWlanSupport,
                                 MaxResolution = p.MaxResolution,
                                 ResponseTime = p.ResponseTime,
                                 ConnectionType = p.ConnectionType,
                                 InMouse = p.InMouse,
                                 HeadphoneType = p.HeadphoneType,
                                 InMicrophone = p.InMicrophone,
                                 ChannelsCount = p.ChannelsCount,
                                 ConnectionInterface = p.ConnectionInterface,
                                 VideoResolution = p.VideoResolution,
                                 UPSType = p.UPSType,
                                 VAValue = p.VAValue

                             };
                return result.SingleOrDefaultAsync(p => p.ProductId == entity);

            }
        }

        public List<ProductDto> GetProductDetails()
        {
            using (MasterChiefContext context = new MasterChiefContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId

                             select new ProductDto
                             {
                                 ProductId = p.ProductId,
                                 CategoryName = c.CategoryName,
                                 CategoryDescription = c.Description,
                                 ProductName = p.ProductName,
                                 UnitPrice = p.UnitPrice,
                                 UnitsInStock = p.UnitsInStock,
                                 UnitsOnOrder = p.UnitsOnOrder,
                                 MBChipsetType = p.MBChipsetType,
                                 MBCPUSocketType = p.MBCPUSocketType,
                                 MBCPUSeries = p.MBCPUSeries,
                                 RAMType = p.RAMType,
                                 RAMCapacity = p.RAMCapacity,
                                 GPURAMType = p.GPURAMType,
                                 GPURAMCapacity = p.GPURAMCapacity,
                                 GPURAMInterface = p.GPURAMInterface,
                                 PCCaseType = p.PCCaseType,
                                 InPSU = p.InPSU,
                                 PSUPower = p.PSUPower,
                                 PSUModularityStatus = p.PSUModularityStatus,
                                 ProcessorBrand = p.ProcessorBrand,
                                 ProcessorSeries = p.ProcessorSeries,
                                 ProcessorModel = p.ProcessorModel,
                                 GPUManufacturer = p.GPUManufacturer,
                                 GPUModel = p.GPUModel,
                                 RAMBrand = p.RAMBrand,
                                 HardDiskType = p.HardDiskType,
                                 DiskCapacity = p.DiskCapacity,
                                 OperatingSystem = p.OperatingSystem,
                                 ScreenSize = p.ScreenSize,
                                 RearCameraResolution = p.RearCameraResolution,
                                 FrontCameraResolution = p.FrontCameraResolution,
                                 SIMCardSupport = p.SIMCardSupport,
                                 WifiWlanSupport = p.WifiWlanSupport,
                                 MaxResolution = p.MaxResolution,
                                 ResponseTime = p.ResponseTime,
                                 ConnectionType = p.ConnectionType,
                                 InMouse = p.InMouse,
                                 HeadphoneType = p.HeadphoneType,
                                 InMicrophone = p.InMicrophone,
                                 ChannelsCount = p.ChannelsCount,
                                 ConnectionInterface = p.ConnectionInterface,
                                 VideoResolution = p.VideoResolution,
                                 UPSType = p.UPSType,
                                 VAValue = p.VAValue


                             };

                return result.ToList();
            }
        }
        public Task<List<ProductDto>> GetProductDetailsAsync()
        {
            MasterChiefContext context = new MasterChiefContext();

            var result = from p in context.Products
                         join c in context.Categories
                         on p.CategoryId equals c.CategoryId

                         select new ProductDto
                         {
                             ProductId = p.ProductId,
                             CategoryName = c.CategoryName,
                             CategoryDescription = c.Description,
                             ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice,
                             UnitsInStock = p.UnitsInStock,
                             UnitsOnOrder = p.UnitsOnOrder,
                             MBChipsetType = p.MBChipsetType,
                             MBCPUSocketType = p.MBCPUSocketType,
                             MBCPUSeries = p.MBCPUSeries,
                             RAMType = p.RAMType,
                             RAMCapacity = p.RAMCapacity,
                             GPURAMType = p.GPURAMType,
                             GPURAMCapacity = p.GPURAMCapacity,
                             GPURAMInterface = p.GPURAMInterface,
                             PCCaseType = p.PCCaseType,
                             InPSU = p.InPSU,
                             PSUPower = p.PSUPower,
                             PSUModularityStatus = p.PSUModularityStatus,
                             ProcessorBrand = p.ProcessorBrand,
                             ProcessorSeries = p.ProcessorSeries,
                             ProcessorModel = p.ProcessorModel,
                             GPUManufacturer = p.GPUManufacturer,
                             GPUModel = p.GPUModel,
                             RAMBrand = p.RAMBrand,
                             HardDiskType = p.HardDiskType,
                             DiskCapacity = p.DiskCapacity,
                             OperatingSystem = p.OperatingSystem,
                             ScreenSize = p.ScreenSize,
                             RearCameraResolution = p.RearCameraResolution,
                             FrontCameraResolution = p.FrontCameraResolution,
                             SIMCardSupport = p.SIMCardSupport,
                             WifiWlanSupport = p.WifiWlanSupport,
                             MaxResolution = p.MaxResolution,
                             ResponseTime = p.ResponseTime,
                             ConnectionType = p.ConnectionType,
                             InMouse = p.InMouse,
                             HeadphoneType = p.HeadphoneType,
                             InMicrophone = p.InMicrophone,
                             ChannelsCount = p.ChannelsCount,
                             ConnectionInterface = p.ConnectionInterface,
                             VideoResolution = p.VideoResolution,
                             UPSType = p.UPSType,
                             VAValue = p.VAValue
                         };

            return result.ToListAsync();
        }
    }
}
