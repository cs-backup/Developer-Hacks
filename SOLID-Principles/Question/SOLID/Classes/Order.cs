using System;
using System.Collections.Generic;

namespace SOLID.Classes
{
    public class Item
    {
        public bool IsInStock { get; set; }
    }

    public class Order
    {
        private readonly List<Item> _items = new List<Item>();

        public bool IsValid
        {
            get
            {
                return CheckIsValid();
            }
        }

        private bool CheckIsValid()
        {
            var isValid = true;
            _items.ForEach(item =>
            {
                if (!item.IsInStock) isValid = false;
            });
            return isValid;
        }
    }

    public class PriorityOrder : Order
    {
        private readonly List<Item> _items = new List<Item>();

        public new bool IsValid
        {
            get
            {
                return AreItemsInStock();
            }
        }

        private bool AreItemsInStock()
        {
            _items.ForEach(item =>
            {
                if (!item.IsInStock) throw new Exception("No items in stock.");
            });
            return true;
        }
    }
}
