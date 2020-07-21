using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Business.Abstract;
using Blog.Entities;
using BlogMvcUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogMvcUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            var model = new CategoryAddViewModel();

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(category);
                TempData["message"] = "New category added succesfully !";

                return RedirectToAction("AdminCategories","Admin");
            }

            return RedirectToAction("AdminCategories","Admin");
        }

        [Authorize]
        public IActionResult Delete(int categoryId)
        {
            var deletedCategory = _categoryService.GetById(categoryId);

            if (deletedCategory != null)
            {
                _categoryService.Delete(categoryId);
                TempData["message"] = "Selected category deleted succesully !";

                return RedirectToAction("AdminCategories", "Admin");
            }

            TempData["message"] = "Selected category did not delete !";
            return RedirectToAction("AdminCategories", "Admin");
        }

        [Authorize]
        [HttpGet]
        public IActionResult Update(int categoryId)
        {
            var updatedCategory = _categoryService.GetById(categoryId);

            var model = new CategoryUpdateViewModel()
            {
                Id = updatedCategory.Id,
                CategoryName = updatedCategory.CategoryName
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(category);
                TempData["message"] = "Selected category updated succesfully !";

                return RedirectToAction("AdminCategories", "Admin");
            }

            TempData["message"] = "Selected category did not update !";
            return RedirectToAction("AdminCategories", "Admin");
        }
    }
}