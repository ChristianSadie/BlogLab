using BlogLab.Models.BlogComment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public interface IBlogCommentRepository
    {
        public Task<BlogComment> Upsert(BlogCommentCreate blogCommentCreate, int applicationUserId);

        public Task<List<BlogComment>> GetAllAsync(int blogId);
        public Task<BlogComment> GetAsync(int blogCommentId);
        public Task<List<BlogComment>> DeleteAsync(int blogCommentId);

    }
}
