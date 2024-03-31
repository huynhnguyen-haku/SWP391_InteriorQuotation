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
    public class InteriorRepo : IInteriorRepo
    {
        public void AddInterior(Interior interior) => InteriorDAO.Instance.AddInterior(interior);

        public void DeleteInterior(int id) => InteriorDAO.Instance.DeleteInterior(id);

        public Interior GetInteriorById(int id) => InteriorDAO.Instance.GetInteriorById(id);

        public List<Interior> ListByCategory(int? id) => InteriorDAO.Instance.ListByCategory(id);

        public List<Category> ListCategory() => InteriorDAO.Instance.ListCategory();

        public List<Interior> ListInterior() => InteriorDAO.Instance.ListInterior();

        public List<Interior> ListInteriorAdmin() => InteriorDAO.Instance.ListInteriorAdmin();

        public void UpdateInterior(Interior interior) => InteriorDAO.Instance.UpdateInterior(interior);
    }
}
