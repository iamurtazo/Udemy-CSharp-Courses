using Testability.UnitTests;

public class OrderProcessor
{
    private readonly IShippingCalculator _shippingcalculator;

    public OrderProcessor(IShippingCalculator shippingCalculator)
    {
        _shippingcalculator = shippingCalculator;
    }
    public void Process(Order order)
    {
        // defensive programming
        if(order.IsShipped)
            throw new InvalidOperationException("This order is already processed");
        order.Shipment = new Shipment
        {
            Cost = _shippingcalculator.CalculateShipping(order),
            ShippingDate = DateTime.Today.AddDays(1)
        };
    }
}