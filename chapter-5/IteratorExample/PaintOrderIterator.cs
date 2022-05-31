namespace IteratorExample;

public class PaintOrderIterator : Iterator
{
    private OrdersCollection _orders;
    private int _position = -1;
    
    public PaintOrderIterator(OrdersCollection orders)
    {
        _orders = SeparateCustomPaintJobOrders(orders);
    }
    
    public override int Key()
    {
        return _position;
    }

    public override bool MoveNext()
    {
        var updatedPosition = _position++;
        if (updatedPosition < 0 || updatedPosition >= _orders.GetOrders().Count) return false;
        _position = updatedPosition;
        return true;
    }

    public override void Reset()
    {
        _position = 0;
    }

    public override object Current()
    {
        return _orders.GetOrders()[_position];
    }
    
    private OrdersCollection SeparateCustomPaintJobOrders(OrdersCollection orders)
    {
        // we need the standard paint jobs first and customs at the end
        var result = new OrdersCollection();
        var customPaintJobOrders = new List<BicycleOrder>();
        var standardPaintJobOrders = new List<BicycleOrder>();
        foreach (var order in orders.GetOrders())
        {
            var paintJobType = order.Bicycle.PaintJob.GetType().ToString();
            if (paintJobType == "CustomGradientPaintJob")
            {
                customPaintJobOrders.Add(order);
            }
            else
            {
                standardPaintJobOrders.Add(order);
            }
        }
        result.AddOrders(standardPaintJobOrders); 
        result.AddOrders(customPaintJobOrders);
        return result;
    }
}