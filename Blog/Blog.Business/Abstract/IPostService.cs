using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int postId);
        List<Post> GetAll();
        Post GetById(int postId);
        List<Post> GetByCategoryId(int categoryId);
    }
}
