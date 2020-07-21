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
    public class CommentController : Controller
    {
        private ICommentService _commentService;
        private IPostService _postService;
        public CommentController(ICommentService commentService, IPostService postService)
        {
            _commentService = commentService;
            _postService = postService;
        }

        public IActionResult Add(string postComment, int postId)
        {
            Comment comment = new Comment();
            comment.PostId = postId;
            comment.PostComment = postComment;

            if (comment.PostId != 0 && comment.PostComment != null)
            {
                _commentService.Add(comment);
                TempData["message"] = "Your comment added succesfully";
                return RedirectToAction("Detail","Post", new { postId = comment.PostId });
            }

            TempData["message"] = "Your comment did not add to database !";
            return RedirectToAction("Detail", "Post", new { postId = comment.PostId });
        }

        [Authorize]
        public IActionResult Delete(int commentId)
        {
            var deletedComment = _commentService.GetById(commentId);

            if (deletedComment != null)
            {
                _commentService.Delete(commentId);
                TempData["message"] = "Selected comment deleted succesfully !";

                return RedirectToAction("AdminPosts", "Admin");
            }

            TempData["message"] = "Selected comment did not delete !";
            return RedirectToAction("AdminPosts","Admin");
        }

        // Admin Controller Show Comments Button
        [Authorize]
        public IActionResult GetCommentsByPostId(int postId)
        {
            var comments = _commentService.GetByPostId(postId);
            var post = _postService.GetById(postId);

            var model = new GetCommentsByPostIdViewModel()
            {
                Comments = comments,
                Post = post
            };

            return View(model);
        }
    }
}