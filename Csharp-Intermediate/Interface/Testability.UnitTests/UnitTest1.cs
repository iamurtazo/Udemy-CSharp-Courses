
namespace Testability.UnitTests;

//[UnitTest1]
public class OrderProcessorTests
{
    //[TestMethod]
    //MethodName_Condition_Expectation => Naming Convention For Naming A Method In Unit Test Project
    public void Process_OrderIsAlreadyShipped_ThrowsAnException()
    {
        var orderProcessor = new OrderProcessor();
    }
}

public class FakeShippingCalculator : IShippingCalculator
{
}