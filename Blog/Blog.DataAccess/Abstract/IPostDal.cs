using Blog.Core.Data_Access;
using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.DataAccess.Abstract
{
    public interface IPostDal : IEntityRepositoryBase<Post>
    {
    }
}
