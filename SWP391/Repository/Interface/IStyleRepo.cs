using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IStyleRepo
    {
        List<Style> ListStyle();
        List<Style> ListStyleAdmin();
        Style GetStyleById(int id);
        void AddStyle(Style style);
        void UpdateStyle(Style style);
    }
}
