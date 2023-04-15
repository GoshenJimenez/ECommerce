using ECommerce.Contracts.Cars;
using ECommerce.Contracts.Common;
using ECommerce.Contracts.Users;
using ECommerce.Data.Models;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerce.Web.Pages.Manage.Cars
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly ICarService _carService;
        [BindProperty]
        public ViewModel Data { get; set; }
        public Index(ILogger<Index> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;

            Data = Data ?? new ViewModel();
        }

        public void OnGet(int? pageIndex = 1, int? pageSize = 10, string? sortBy = "", SortOrder sortOrder = SortOrder.Ascending, string? keyword = "")
        {
            Data.Cars = _carService.Search(pageIndex, pageSize, sortBy, sortOrder, keyword);
        }

        public class ViewModel
        {
            public Paged<CarDto>? Cars { get; set; }
        }
    }
}
