using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcUI.Models
{
    public class AdminIndexViewModel
    {
        public List<Post> Posts { get; set; }
        public List<Category> Categories { get; set; }
        public int NumberOfPosts { get; set; }
        public int NumberOfCategories { get; set; }
    }
}
