public class DiscountCalculator<TProduct> where TProduct : Product
{
    // Example to class or any subclass
    public float CalculateDiscount(TProduct product)
    {
        return product.Price - product.Price * 0.2f;
    }
}
