using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Business.Abstract
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Delete(int commentId);
        List<Comment> GetByPostId(int postId);
        Comment GetById(int commentId);
    }
}
