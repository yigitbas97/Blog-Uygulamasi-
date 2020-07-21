using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}
