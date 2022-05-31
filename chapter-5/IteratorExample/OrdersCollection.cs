using System.Collections;

namespace IteratorExample;

public class OrdersCollection : IteratorAggregate
{
    private List<BicycleOrder> _orders;

    public OrdersCollection()
    {
        _orders = new List<BicycleOrder>();
    }
    public List<BicycleOrder> GetOrders()
    {
        return _orders;
    }

    public void AddOrder(BicycleOrder order)
    {
        _orders.Add(order);
    }

    public void AddOrders(List<BicycleOrder> orders)
    {
        _orders.AddRange(orders);
    }
    
    public override IEnumerator GetEnumerator()
    {
        return new PaintOrderIterator(this);
    }
}