using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class InteriorDAO
    {
        private static InteriorDAO instance = null;
        private static readonly object instanceLock = new object();
        private InteriorDAO() { }
        public static InteriorDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new InteriorDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Interior> ListByCategory(int? id)
        {
            List<Interior> interiors;
            try
            {
                using (var MySale = new styleContext())
                {
                    interiors = MySale.Interiors.Where(x => x.CateId == id && x.Status == 1).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return interiors;
        }

        public List<Interior> ListInterior()
        {
            List<Interior> interiors;
            try
            {
                using (var MySale = new styleContext())
                {
                    interiors = MySale.Interiors.Where(x => x.Status == 1).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return interiors;
        }

        public List<Interior> ListInteriorAdmin()
        {
            List<Interior> interiors;
            try
            {
                using (var MySale = new styleContext())
                {
                    interiors = MySale.Interiors.Include(x => x.Cate).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return interiors;
        }

        public List<Category> ListCategory()
        {
            List<Category> categories;
            try
            {
                using (var MySale = new styleContext())
                {
                    categories = MySale.Categories.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return categories;
        }

        public Interior GetInteriorById(int id)
        {
            Interior interior = null;
            try
            {
                using (var MySale = new styleContext())
                {
                    interior = MySale.Interiors.SingleOrDefault(x => x.Id == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return interior;
        }

        public void AddInterior(Interior interior)
        {
            try
            {
                Interior c = GetInteriorById(interior.Id);
                if (c == null)
                {
                    using (var MySale = new styleContext())
                    {
                        MySale.Interiors.Add(interior);
                        MySale.SaveChanges();
                    }

                }
                else
                {
                    throw new Exception("The interior is already exist");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateInterior(Interior interior)
        {
            try
            {
                Interior p = GetInteriorById(interior.Id);
                if (p != null)
                {
                    using (var MySale = new styleContext())
                    {
                        MySale.Entry<Interior>(interior).State = EntityState.Modified;
                        MySale.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The interior does not exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteInterior(int id)
        {
            try
            {
                Interior c = GetInteriorById(id);
                if (c != null)
                {
                    using (var MySale = new styleContext())
                    {

                        MySale.Interiors.Remove(c);
                        MySale.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The interior does not exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
