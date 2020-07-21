using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcUI.Models
{
    public class PostIndexModel
    {
        public List<Post> Posts { get; set; }
        public int PageNumber { get; internal set; }
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
    }
}
