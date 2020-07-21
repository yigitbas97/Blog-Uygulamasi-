using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities
{
    public class Comment: IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string PostComment { get; set; }
    }
}
