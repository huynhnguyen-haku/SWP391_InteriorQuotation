using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IInteriorRepo
    {
        List<Interior> ListByCategory(int? id);
        List<Interior> ListInterior();
        List<Interior> ListInteriorAdmin();
        List<Category> ListCategory();
        Interior GetInteriorById(int id);
        void AddInterior(Interior interior);
        void UpdateInterior(Interior interior);
        void DeleteInterior(int id);
    }
}
