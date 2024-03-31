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
    public class ProjectRepo : IProjectRepo
    {
        public void AddProject(Project project) => ProjectDAO.Instance.AddProject(project);

        public Project GetProjectById(int id) => ProjectDAO.Instance.GetProjectById(id);

        public List<Project> ListProject() => ProjectDAO.Instance.ListProject();

        public List<Project> ListProjectAdmin() => ProjectDAO.Instance.ListProjectAdmin();

        public void UpdateProject(Project project) => ProjectDAO.Instance.UpdateProject(project);
    }
}
