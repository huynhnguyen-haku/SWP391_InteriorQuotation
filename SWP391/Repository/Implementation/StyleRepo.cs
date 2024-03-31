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
    public class StyleRepo : IStyleRepo
    {
        public void AddStyle(Style style) => StyleDAO.Instance.AddStyle(style);

        public Style GetStyleById(int id) => StyleDAO.Instance.GetStyleById(id);

        public List<Style> ListStyle() => StyleDAO.Instance.ListStyle();

        public List<Style> ListStyleAdmin() => StyleDAO.Instance.ListStyleAdmin();

        public void UpdateStyle(Style style) => StyleDAO.Instance.UpdateStyle(style);
    }
}
