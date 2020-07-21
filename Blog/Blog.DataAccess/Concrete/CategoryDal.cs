using Blog.Core.Data_Access;
using Blog.DataAccess.Abstract;
using Blog.DataAccess.Context;
using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Concrete
{
    public class CategoryDal : EntityRepositoryBase<Category,BlogContext>, ICategoryDal
    {
    }
}
