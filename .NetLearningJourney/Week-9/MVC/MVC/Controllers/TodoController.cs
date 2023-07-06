using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class TodoController : Controller
    {
        // connection with the database
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
            if (todo.description == null)
            {
                ModelState.AddModelError("description", "Description cannot be null");
            }
            if ((todo.description != null) && (todo.description.Length == 50))// check for the length of the description
            {
                ModelState.AddModelError("description", "Length Exceeded");
            }
            if (ModelState.IsValid)
            {
                _db.todos.Add(todo);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(todo);
            }
        }

        public IActionResult Edit(int id)
        {
            var todo = _db.todos.Find(id);
            return View(todo); 
        }

        // update todo in the list 
        [HttpPost]
        public IActionResult Edit(Todo todo)
        {
            _db.todos.Update(todo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // delete Todo from the list
        public IActionResult Delete(int id)
        {
            _db.todos.Remove(_db.todos.Find(id));
            _db.SaveChanges();  
            return RedirectToAction("Index");
        }



    }
}
