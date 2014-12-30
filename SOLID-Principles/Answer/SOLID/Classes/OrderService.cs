using System;
using System.Collections;
using System.Collections.Generic;

namespace SOLID.Classes
{
    // This class violating which SOLID principles?

    public class OrderService
    {
        public Order Get(int orderId)
        {
            throw new NotImplementedException();
        }

        public Order Save(Order order)
        {
            throw new NotImplementedException();
        }

        public Order SubmitOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByName(string name)
        {
            throw new NotImplementedException();
        }

        public void CancelOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public void ProcessOrderReturn(int orderId)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetShippedOrders()
        {
            throw new NotImplementedException();
        }

        public void ShipOrder(Address address)
        {
            throw new NotImplementedException();
        }

    }

}
