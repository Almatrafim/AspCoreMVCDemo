using AspCoreMVCDemo.Core;
using AspCoreMVCDemo.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreMVCDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepostoery<Category> repostoery;

        public CategoryController(IRepostoery<Category> repostoery) 
        {
            this.repostoery = repostoery;
        }
       
        // GET: CategoryController
        public ActionResult Index()
        {
            return View(repostoery.GetAll());
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View(repostoery.Finde(id));
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category collection)
        {
            try
            {
                
                    repostoery.Add(collection);
                    return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repostoery.Finde(id));
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category collection)
        {
            try
            {
                repostoery.Edit(id, collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repostoery.Finde(id));
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category collection)
        {
            try
            {
                Category category = new Category();
                category = repostoery.Finde(id);
                repostoery.Remove(category);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult Search(string search)
        {
            return View("Index",repostoery.Search(search));
        }
    }
}
