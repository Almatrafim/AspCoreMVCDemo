using AspCoreMVCDemo.Code;
using AspCoreMVCDemo.Core;
using AspCoreMVCDemo.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreMVCDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepostoery<Product> repostoery;
        private readonly IRepostoery<Category> cRep;
        private readonly IWebHostEnvironment webHost;
        private readonly FilesHelper helper;

        public ProductController(IRepostoery<Product> repostoery, IRepostoery<Category> CRep,IWebHostEnvironment webHost)
        {
            
            this.repostoery = repostoery;
            cRep = CRep;
            this.webHost = webHost;
            helper = new FilesHelper(webHost);
        }
        // GET: ProductController
        public ActionResult Index()
        {
            return View(repostoery.GetAll());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductVM collection)
        {
            try
            {
                object valu = collection.ImageUrl;
                var file = valu as IFormFile;
                var ex = Path.GetExtension(file.FileName);
                long x = file.Length;
                var _ex = ".png";
                if (!_ex.Contains(ex.ToLower()) || x > 5000) 
                {
                    ModelState.AddModelError(string.Empty, "you sould use .png");
                }
                if (ModelState.IsValid)
                {
                    var product = new Product()
                    {
                        Name = collection.Name,
                        Description = collection.Description,
                        Author = collection.Author,
                        Price = collection.Price,
                        CategoryId = cRep.GetAll().Where(x => x.Name == collection.CategoryView).Select(x => x.Id).First(),
                        ImageUrl = helper.UploadFile(collection.ImageUrl, "images")
                    };
                    repostoery.Add(product);
                    return RedirectToAction(nameof(Index));
                }
                else {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
