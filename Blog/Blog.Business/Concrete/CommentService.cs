using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Concrete
{
    public class CommentService : ICommentService
    {
        private ICommentDal _commentDal;
        public CommentService(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Delete(int commentId)
        {
            _commentDal.Delete(new Comment { Id = commentId });
        }

        public Comment GetById(int commentId)
        {
            return _commentDal.Get(p => p.Id == commentId);
        }

        public List<Comment> GetByPostId(int postId)
        {
            return _commentDal.GetList(p => p.PostId == postId);
        }
    }
}
