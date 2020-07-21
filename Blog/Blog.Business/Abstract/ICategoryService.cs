using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
