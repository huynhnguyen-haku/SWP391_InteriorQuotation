﻿using BusinessObjects.Models;
using DataAccessObject;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class QuotationRepo : IQuotationRepo
    {
        public void AddOrder(Order o, List<QuotationDetail> list) => QuotationDAO.Instance.AddOrder(o, list);

        public Quotation AddQuotation(Quotation quotation) => QuotationDAO.Instance.AddQuotation(quotation);

        public void AddQuotationDetail(QuotationDetail detail) => QuotationDAO.Instance.AddQuotationDetail(detail);

        public void ApproveOrder(int id) => QuotationDAO.Instance.ApproveOrder(id);

        public void CancelOrder(int id) => QuotationDAO.Instance.CancelOrder(id);

        public List<Background> GetAllBackground() => QuotationDAO.Instance.GetAllBackground();

        public List<CeilingHouse> GetAllCeil() => QuotationDAO.Instance.GetAllCeil();

        public List<Order> GetAllOrder(int user_id) => QuotationDAO.Instance.GetAllOrder(user_id);

        public List<Order> GetAllOrderAdmin() => QuotationDAO.Instance.GetAllOrderAdmin();

        public List<OrderDetail> GetAllOrderDetail(int id) => QuotationDAO.Instance.GetAllOrderDetail(id);

        public List<TypeHouse> GetAllTypeHouse() => QuotationDAO.Instance.GetAllTypeHouse();

        public List<Wall> GetAllWall() => QuotationDAO.Instance.GetAllWall();

        public List<QuotationDetail> GetCart(int user_id) => QuotationDAO.Instance.GetCart(user_id);

        public Order GetOrder(int id) => QuotationDAO.Instance.GetOrder(id);

        public QuotationDetail GetQuotationDetail(int id) => QuotationDAO.Instance.GetQuotationDetail(id);

        public QuotationDetail GetQuotationDetail(int id, int productID) => QuotationDAO.Instance.GetQuotationDetail(id, productID);

        public Quotation GetQuotationUser(int userID) => QuotationDAO.Instance.GetQuotationUser(userID);

        public void RemoveQuotation(int userID) => QuotationDAO.Instance.RemoveQuotation(userID);

        public void RemoveQuotationDetail(int id) => QuotationDAO.Instance.RemoveQuotationDetail(id);

        public void UpdateQuotationDetail(QuotationDetail detail) => QuotationDAO.Instance.UpdateQuotationDetail(detail);
    }
}
