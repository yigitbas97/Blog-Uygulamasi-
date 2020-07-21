using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entities
{
    public class Category: IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
