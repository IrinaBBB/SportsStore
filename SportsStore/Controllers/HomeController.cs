using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository _repo;
        public HomeController(IStoreRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index() => View(_repo.Products);
    }
}