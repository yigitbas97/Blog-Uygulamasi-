using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcUI.Models
{
    public class AdminPostsViewModel
    {
        public List<Post> Posts { get; set; }
        public int PageNumber { get; set; }
        public int CurrentPage { get; set; }
    }
}
