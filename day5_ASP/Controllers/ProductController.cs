using day5_ASP.data;
using day5_ASP.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace day5_ASP.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index(int categoryId)
        {
            var products = SeedData.products
                .Where(p => p.CategoryId == categoryId)
                .ToList();
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = SeedData.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Product product)
        {
            if (ModelState.IsValid)
            {
                // Lay max id trong danh sach SeedData.products
                int maxId = SeedData.products.Any()
                    ? SeedData.products.Max(p => p.Id)
                    : 0;

                // Set id cho product
                product.Id = maxId + 1;

                // Them product vao danh sach
                SeedData.products.Add(product);

                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = SeedData.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] day5_ASP.Models.Product product)
        {
            var existingProduct = SeedData.products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            // Cập nhật thông tin sản phẩm
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.CategoryId = product.CategoryId;
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = SeedData.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var existingProduct = SeedData.products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            SeedData.products.Remove(existingProduct);
            return RedirectToAction(nameof(Index));
        }
    }
}
