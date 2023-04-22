using ECommerce.Contracts.Common;
using ECommerce.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.Cars
{
    public interface ICarService : IService
    {
        Paged<CarDto> Search(int? pageIndex = 1, 
                             int? pageSize = 10, 
                             string? sortBy = "", 
                             SortOrder sortOrder = SortOrder.Ascending, 
                             string? keyword = "");

        Guid? Create(CarDto? dto);
        Guid? Update(CarDto? dto);
        CarDto? GetById(Guid? carId);
    }
}