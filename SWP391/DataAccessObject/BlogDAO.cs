using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class BlogDAO
    {
        private static BlogDAO instance = null;
        private static readonly object instanceLock = new object();
        private BlogDAO() { }
        public static BlogDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BlogDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Blog> ListBlog()
        {
            List<Blog> blogs;
            try
            {

                using (var MySale = new styleContext())
                {
                    blogs = MySale.Blogs.Where(x => x.Status == 1).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return blogs;
        }

        public Blog GetBlogById(int id)
        {
            Blog blog = null;
            try
            {
                using (var MySale = new styleContext())
                {
                    blog = MySale.Blogs.SingleOrDefault(x => x.Id == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return blog;
        }

        public List<Blog> ListBlogAdmin()
        {
            List<Blog> blogs;
            try
            {
                using (var MySale = new styleContext())
                {
                    blogs = MySale.Blogs.Include(x => x.Account).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return blogs;
        }

        public void AddBlog(Blog blog)
        {
            try
            {
                Blog c = GetBlogById(blog.Id);
                if (c == null)
                {
                    using (var MySale = new styleContext())
                    {
                        MySale.Blogs.Add(blog);
                        MySale.SaveChanges();
                    }

                }
                else
                {
                    throw new Exception("The blog is already exist");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateBlog(Blog blog)
        {
            try
            {
                Blog p = GetBlogById(blog.Id);
                if (p != null)
                {
                    using (var MySale = new styleContext())
                    {
                        MySale.Entry<Blog>(blog).State = EntityState.Modified;
                        MySale.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The blog does not exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
