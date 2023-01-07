namespace Specifiers;

public abstract class Product
{
    private string? _productName;
    public string? ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }

    private decimal? _productPrice;

    public decimal? ProductPrice
    {
        get { return _productPrice; }
        set { _productPrice = value; }
    }

    private bool? _productStatus;
    public bool? ProductStatus
    {
        get { return _productStatus; }
        set { _productStatus = value; }
    }
    public string GetProductName()
    {
        if (!IsProductAvailable())
        {
            return "Product is not available";
        }
        return ProductName ?? "";
    }

    private bool IsProductAvailable()
    {
        return false;
    }

    protected virtual bool? GetProductStatus()
    {
        return _productStatus;
    }
    internal decimal? GetProductPrice()
    {
        return ProductPrice ?? 0;
    }

}
