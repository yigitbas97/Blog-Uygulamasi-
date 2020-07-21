using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities
{
    public class Post: IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PostContent { get; set; }
        public DateTime UploadDate { get; set; }
        public int CategoryId { get; set; }
    }
}
