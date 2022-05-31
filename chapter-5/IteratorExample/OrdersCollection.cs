﻿using System.Collections;

namespace IteratorExample;

public class OrdersCollection : IteratorAggregate
{
    public List<BicycleOrder> Orders { get; set; }

    public OrdersCollection()
    {
        Orders = new List<BicycleOrder>();
    }

    public void AddOrder(BicycleOrder order)
    {
        Orders.Add(order);
    }

    public void AddOrders(List<BicycleOrder> orders)
    {
        Orders.AddRange(orders);
    }
    
    public override IEnumerator GetEnumerator()
    {
        return new PaintOrderIterator(this);
    }
}