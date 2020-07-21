using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcUI.Models
{
    public class PostDetailViewModel
    {
        public Post Post { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
