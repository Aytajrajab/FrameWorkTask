using Microsoft.AspNetCore.Mvc;
using FrameWorkTask.Models;
using System.Collections.Generic;
using FrameWorkTask.DAL;
using System.Linq;
using FrameWorkTask.ViewModels;

namespace FrameWorkTask.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; set; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Product.ToList();
            var users = _context.User.ToList();
            var roles = _context.Role.ToList();
            var categories = _context.Category.ToList();

            HomeViewModel allModel = new HomeViewModel
            {
                products = products,
                users = users,
                roles = roles,
                categories = categories,
            };
            return View(allModel);
        }
    }
}
