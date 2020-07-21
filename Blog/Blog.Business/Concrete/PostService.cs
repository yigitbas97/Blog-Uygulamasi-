using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Concrete
{
    public class PostService : IPostService
    {
        private IPostDal _postDal;
        public PostService(IPostDal postDal)
        {
            _postDal = postDal;
        }
        public void Add(Post post)
        {
            _postDal.Add(post);
        }

        public void Delete(int postId)
        {
            _postDal.Delete(new Post { Id = postId});
        }

        public List<Post> GetAll()
        {
            return _postDal.GetList();
        }

        public List<Post> GetByCategoryId(int categoryId)
        {
            return _postDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public Post GetById(int postId)
        {
            return _postDal.Get(p => p.Id == postId);
        }

        public void Update(Post post)
        {
            _postDal.Update(post);
        }
    }
}
