using Blog.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcUI.Models
{
    public class PostAddViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string PostContent { get; set; }
        [Required]
        public DateTime UploadDate { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
