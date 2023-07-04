using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TodoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var todos = _db.todos.ToList();
            return View(todos);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Todo todo)
        {
            _db.todos.Add(todo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
