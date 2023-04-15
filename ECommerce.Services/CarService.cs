using AutoMapper;
using ECommerce.Contracts;
using ECommerce.Contracts.Cars;
using ECommerce.Contracts.Common;
using ECommerce.Data.Models;
using ECommerce.Data.Models.Others;
using ECommerce.Services.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ECommerce.Services
{
    public class CarService : BaseService, ICarService
    {
        private readonly IRepository<Car> _carRepository;
        public CarService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper, IHttpContextAccessor httpContextAccessor,
              IRepository<Car> carRepository
            )
            : base(configuration, logger, mapper, httpContextAccessor)
        {
            _carRepository = carRepository;
        }

        public Paged<CarDto> Search(int? pageIndex = 1, int? pageSize = 10, string? sortBy = "", SortOrder sortOrder = SortOrder.Ascending, string? keyword = "")
        {

            var skip = (int)((pageIndex! - 1) * pageSize!);

            var query = _carRepository
                                .All()
                                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(a =>
                            a.Make != null && a.Make.ToLower().Contains(keyword.ToLower())
                        || a.Manufacturer != null && a.Manufacturer.ToLower().Contains(keyword.ToLower())
                );
            }

            var totalRows = query.Count();

            if (!string.IsNullOrEmpty(sortBy))
            {
                if (sortBy.ToLower() == "make" && sortOrder == SortOrder.Ascending)
                {
                    query = query.OrderBy(a => a.Make);
                }
                else if (sortBy.ToLower() == "make" && sortOrder == SortOrder.Descending)
                {
                    query = query.OrderByDescending(a => a.Make);
                }
                else if (sortBy.ToLower() == "manufacturer" && sortOrder == SortOrder.Ascending)
                {
                    query = query.OrderBy(a => a.Manufacturer);
                }
                else if (sortBy.ToLower() == "manufacturer" && sortOrder == SortOrder.Descending)
                {
                    query = query.OrderByDescending(a => a.Manufacturer);
                }
            }

            var cars = query
                            .Skip(skip)
                            .Take((int)pageSize!)
                            .Select(a => new CarDto()
                            {
                                Id = a.Id,
                                Make = a.Make,
                                Manufacturer = a.Manufacturer,
                                Year = a.Year
                            })
                            .ToList();

            return new Paged<CarDto>()
            {
                Items = cars,
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalRows = totalRows,
                SortBy = sortBy,
                SortOrder = sortOrder,
                Keyword = keyword,
            };
        }
    }
}
