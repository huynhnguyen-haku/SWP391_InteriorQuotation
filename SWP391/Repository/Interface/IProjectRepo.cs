using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IProjectRepo
    {
        List<Project> ListProject();
        Project GetProjectById(int id);
        List<Project> ListProjectAdmin();
        void AddProject(Project project);
        void UpdateProject(Project project);
    }
}
