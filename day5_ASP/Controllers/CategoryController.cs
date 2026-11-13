using day5_ASP.data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

    public class CategoryController : Controller
    {
        //Ilogger<categoryController> _logger;
        private readonly ILogger<CategoryController> _logger;
        // GET: Category
        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index(string searchString, int page = 1)
        {
         int pageSize = 5; // Số lượng danh mục trên mỗi trang
         var categories = SeedData.categories.AsEnumerable();
        if(!string.IsNullOrWhiteSpace(searchString))
        {
            categories = categories.Where(c =>
                 (c.Name ?? "").Contains(
                     searchString, StringComparison.OrdinalIgnoreCase)
                 ||
                 (c.Description ?? "").Contains(
                     searchString, StringComparison.OrdinalIgnoreCase)
             );
        }
        int totalCategories = categories.Count();
        int totalPages = (int)Math.Ceiling((double)totalCategories / pageSize);
        if (page < 1)
            page = 1;

        if (totalPages > 0 && page > totalPages)
            page = totalPages;
        var result = categories
            .OrderBy(c => c.Id)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;
        ViewBag.TotalItems = totalCategories;
        ViewBag.SearchString = searchString;

        return View(result);
    }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            //lay ra category co id treyen vao tu seeddata
            var category = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();

            }
            return View(category);
        }

        // POST: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] day5_ASP.Models.Category category)
        {
            if (ModelState.IsValid)
            {
                //lay max id trong danh sacsh seeddata.categories
                int maxId = SeedData.categories.Max(c => c.Id);
                //set id cho category
                category.Id = maxId + 1;
                //them category vao danh sacsh seeddata.category
                SeedData.categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }


        // GET: Category/Edit/5
        public ActionResult Edit([FromRoute] int id)
        {
            var category = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] day5_ASP.Models.Category category)
        {
            var exisitingcategory = SeedData.categories.FirstOrDefault(c => c.Id == category.Id);
            if (exisitingcategory == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                exisitingcategory.Name = category.Name;
                exisitingcategory.Description = category.Description;
                return RedirectToAction(nameof(Index));
            }

            return View(category);

        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var categori = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (categori == null)
            {
                return NotFound();
            }
            return View(categori);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete([FromForm] day5_ASP.Models.Category category)
        {
            var existingcategory = SeedData.categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingcategory == null)
            {
                return NotFound();
            }
            SeedData.categories.Remove(existingcategory);
            return RedirectToAction(nameof(Index));
        }
    }

