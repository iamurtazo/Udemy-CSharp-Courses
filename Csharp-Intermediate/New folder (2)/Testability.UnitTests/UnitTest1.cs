namespace Testability.UnitTests;
//[UnitTest1]
public class OrderProcessorTests
{
    //[TestMethod]
    //MethodName_Condition_Expectation => Naming Convention For Naming A Method In Unit Test Project
    //[ExpectedException(typeof(InvalidOperationException))]
    public void Process_OrderIsAlreadyShipped_ThrowsAnException()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order
        {
            Shipment = new Shipment()
        };
        orderProcessor.Process(order);
    }
}

public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        return 1;
    }
}