using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ProjectDAO
    {
        private static ProjectDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProjectDAO() { }
        public static ProjectDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProjectDAO();
                    }
                    return instance;
                }

            }
        }

        public List<Project> ListProject()
        {
            List<Project> projects;
            try
            {

                using (var MySale = new styleContext())
                {
                    projects = MySale.Projects.Where(x => x.Status == 1).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return projects;

        }


        public Project GetProjectById(int id)
        {
            Project project = null;
            try
            {
                using (var MySale = new styleContext())
                {
                    project = MySale.Projects.SingleOrDefault(x => x.Id == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return project;
        }
        public List<Project> ListProjectAdmin()
        {
            List<Project> projects;
            try
            {

                using (var MySale = new styleContext())
                {
                    projects = MySale.Projects.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return projects;

        }
        public void AddProject(Project project)
        {
            try
            {
                Project c = GetProjectById(project.Id);
                if (c == null)
                {
                    using (var MySale = new styleContext())
                    {
                        MySale.Projects.Add(project);
                        MySale.SaveChanges();
                    }

                }
                else
                {
                    throw new Exception("The project is already exist");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateProject(Project project)
        {
            try
            {
                Project p = GetProjectById(project.Id);
                if (p != null)
                {
                    using (var MySale = new styleContext())
                    {
                        MySale.Entry<Project>(project).State = EntityState.Modified;
                        MySale.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The project does not exist");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
