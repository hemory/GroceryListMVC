using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryList.Controllers
{
    public class ItemController : Controller
    {

        private readonly ApplicationDbContext _context;


      
        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //Turn the dbcontext of items into a list
            var model = _context.Items.ToList();

            return View("index", model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var itemToDelete = _context.Items.FirstOrDefault(i => i.Id == id);

            _context.Items.Remove(itemToDelete);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }




    }
}
