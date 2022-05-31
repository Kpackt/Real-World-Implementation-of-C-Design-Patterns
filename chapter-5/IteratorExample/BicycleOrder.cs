using BumbleBikesLibrary;

namespace IteratorExample;

public class BicycleOrder
{
    public Customer Customer { get; set; }
    public IPaintableBicycle Bicycle { get; set; }

    public BicycleOrder(Customer customer, IPaintableBicycle bicycle)
    {
        Customer = customer;
        Bicycle = bicycle;
    }
}