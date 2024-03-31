using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IQuotationRepo
    {
        Quotation GetQuotationUser(int userID);
        Order GetOrder(int id);
        Quotation AddQuotation(Quotation quotation);
        void AddQuotationDetail(QuotationDetail detail);
        QuotationDetail GetQuotationDetail(int id);
        QuotationDetail GetQuotationDetail(int id, int productID);
        List<OrderDetail> GetAllOrderDetail(int id);
        List<Order> GetAllOrder(int user_id);
        List<Order> GetAllOrderAdmin();
        List<TypeHouse> GetAllTypeHouse();
        List<CeilingHouse> GetAllCeil();
        List<Wall> GetAllWall();
        List<Background> GetAllBackground();
        List<QuotationDetail> GetCart(int user_id);
        void UpdateQuotationDetail(QuotationDetail detail);
        void RemoveQuotationDetail(int id);
        void AddOrder(Order o, List<QuotationDetail> list);
        void CancelOrder(int id);
        void ApproveOrder(int id);
        void RemoveQuotation(int userID);
    }
}
