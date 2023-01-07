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
    public string ReturnProductName()
    {
        if (!CheckProductIsAvailable())
        {
            return "Product is not available";
        }
        return ProductName ?? "";
    }

    private bool CheckProductIsAvailable()
    {
        return false;
    }

    internal decimal? ReturnProductPrice()
    {
        return ProductPrice ?? 0;
    }

    protected virtual bool? ReturnProductStatus()
    {
        return _productStatus;
    }

    
}
