using ECommerce.Contracts.Cars;
using ECommerce.Contracts.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Web.Pages.Manage.Cars
{
    public class Create : PageModel
    {
        private readonly ILogger<Create> _logger;
        private readonly ICarService _carService;
        [BindProperty]
        public ViewModel Data { get; set; }
        public Create(ILogger<Create> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;

            Data = Data ?? new ViewModel();
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid != true)
                return Page();

            _carService.Create(Data.Car);

            return RedirectPermanent("~/manage/cars/index");
        }

        public class ViewModel
        {
            public CarDto? Car { get; set; }
        }
    }
}
