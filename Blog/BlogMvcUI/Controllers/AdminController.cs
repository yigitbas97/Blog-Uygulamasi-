using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Business.Abstract;
using BlogMvcUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogMvcUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IPostService _postService;
        private ICategoryService _categoryService;
        private ICommentService _commentService;
        public AdminController(IPostService postService, ICategoryService categoryService, ICommentService commentService)
        {
            _postService = postService;
            _categoryService = categoryService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var posts = _postService.GetAll();
            var categories = _categoryService.GetAll();

            var numberofposts = posts.Count();
            var numberofcategories = categories.Count();

            var model = new AdminIndexViewModel()
            {
                Posts = posts,
                Categories = categories,
                NumberOfPosts = numberofposts,
                NumberOfCategories = numberofcategories
            };

            return View(model);
        }

        public IActionResult AdminPosts(int page = 1)
        {
            int pageSize = 5;
            var posts = _postService.GetAll();
            var pageNumber = Convert.ToInt32(Math.Ceiling(posts.Count / (double)pageSize));
            var currentPage = Convert.ToInt32(HttpContext.Request.Query["page"]);

            if (currentPage == 0)
            {
                currentPage = 1;
            }

            var model = new AdminPostsViewModel()
            {
                Posts = posts.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageNumber = pageNumber,
                CurrentPage = currentPage
            };

            return View(model);
        }

        public IActionResult AdminCategories()
        {
            var categories = _categoryService.GetAll();

            var model = new AdminCategoriesViewModel()
            {
                Categories = categories
            };

            return View(model);
        }
    }
}