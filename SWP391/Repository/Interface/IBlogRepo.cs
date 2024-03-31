using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBlogRepo
    {
        List<Blog> ListBlog();
        Blog GetBlogById(int id);
        List<Blog> ListBlogAdmin();
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
    }
}
