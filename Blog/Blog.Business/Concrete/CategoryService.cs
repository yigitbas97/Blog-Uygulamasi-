using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(int categoryId)
        {
            _categoryDal.Delete(new Category { Id = categoryId });
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(p => p.Id == categoryId);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
