namespace Specifiers;

public class Computer : Product
{
    protected override bool? GetProductStatus()
    {
        return base.GetProductStatus();
    }

    internal decimal? GetComputerPrice()
    {
        return ProductPrice;
    }

}
