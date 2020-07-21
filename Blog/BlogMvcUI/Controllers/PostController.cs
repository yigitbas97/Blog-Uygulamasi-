using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Business.Abstract;
using Blog.Entities;
using BlogMvcUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogMvcUI.Controllers
{
    public class PostController : Controller
    {
        private IPostService _postService;
        private ICategoryService _categoryService;
        private ICommentService _commentService;
        public PostController(IPostService postService, ICategoryService categoryService, ICommentService commentService)
        {
            _postService = postService;
            _categoryService = categoryService;
            _commentService = commentService;
        }

        public IActionResult Index(int page = 1, int categoryId = 0)
        {
            int pageSize = 3;
            var posts = _postService.GetByCategoryId(categoryId).OrderByDescending(p => p.UploadDate).ToList();
            var pageNumber = Convert.ToInt32(Math.Ceiling(posts.Count / (double)pageSize));
            var currentCategory = Convert.ToInt32(HttpContext.Request.Query["categoryId"]);
            var currentPage = Convert.ToInt32(HttpContext.Request.Query["page"]);

            if (currentPage == 0)
            {
                currentPage = 1;
            }

            var model = new PostIndexModel()
            {
                Posts = posts.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageNumber = pageNumber,
                CurrentCategory = currentCategory,
                CurrentPage = currentPage
            };

            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            var categories = _categoryService.GetAll();
            DateTime date_now = DateTime.Now;

            var model = new PostAddViewModel()
            {
                Categories = categories,
                UploadDate = date_now
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Post post)
        {
            if (ModelState.IsValid)
            {
                _postService.Add(post);
                TempData["message"] = "Post added to database";

                return RedirectToAction("AdminPosts", "Admin");
            }

            TempData["message"] = "Post did not add to database";
            return RedirectToAction("AdminPosts", "Admin");
        }

        [Authorize]
        [HttpGet]
        public IActionResult Update(int postId)
        {
            var categories = _categoryService.GetAll();
            var post = _postService.GetById(postId);

            var model = new PostUpdateViewModel()
            {
                Id = post.Id,
                Title = post.Title,
                PostContent = post.PostContent,
                UploadDate = post.UploadDate,
                CategoryId = post.CategoryId,
                Categories = categories
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Post post)
        {
            if (ModelState.IsValid)
            {
                _postService.Update(post);
                TempData["message"] = "Post updated succesfully";

                return RedirectToAction("AdminPosts", "Admin");
            }

            TempData["message"] = "Post did not update !";
            return RedirectToAction("AdminPosts", "Admin");
        }

        [Authorize]
        public IActionResult Delete(int postId)
        {
            var deletedPost = _postService.GetById(postId);

            if (deletedPost != null)
            {
                _postService.Delete(postId);
                TempData["message"] = "Post deleted succesfully";

                var deletedComments = _commentService.GetByPostId(postId);

                foreach (var comment in deletedComments)
                {
                    _commentService.Delete(comment.Id);
                }

                return RedirectToAction("AdminPosts", "Admin");
            }

            TempData["message"] = "Post did not deleted";
            return RedirectToAction("AdminPosts", "Admin");
        }

        public IActionResult Detail(int postId)
        {
            var post = _postService.GetById(postId);
            var comments = _commentService.GetByPostId(postId);

            if (post != null)
            {
                var model = new PostDetailViewModel()
                {
                    Post = post,
                    Comments = comments,
                };

                return View(model);
            }

            return RedirectToAction("Index", "Post");
        }

        public IActionResult Search(string searchedWord)
        {
            if (searchedWord != null)
            {
                var allPosts = _postService.GetAll();
                List<Post> postsAreContain = new List<Post>();

                foreach (var post in allPosts)
                {
                    post.Title = post.Title.ToLower();
                    post.PostContent = post.PostContent.ToLower();
                    searchedWord = searchedWord.ToLower();

                    if (post.Title.Contains(searchedWord) || post.PostContent.Contains(searchedWord))
                    {
                        postsAreContain.Add(post);
                    }
                }

                var model = new PostSearchViewModel() { Posts = postsAreContain };

                return View(model);
            }

            return RedirectToAction("Index", "Post");
        }
    }
}