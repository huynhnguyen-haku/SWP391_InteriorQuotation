using BusinessObjects.Models;
using DataAccessObject;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class BlogRepo : IBlogRepo
    {
        public void AddBlog(Blog blog) => BlogDAO.Instance.AddBlog(blog);

        public Blog GetBlogById(int id) => BlogDAO.Instance.GetBlogById(id);

        public List<Blog> ListBlog() => BlogDAO.Instance.ListBlog();

        public List<Blog> ListBlogAdmin() => BlogDAO.Instance.ListBlogAdmin();

        public void UpdateBlog(Blog blog) => BlogDAO.Instance.UpdateBlog(blog);
    }
}
