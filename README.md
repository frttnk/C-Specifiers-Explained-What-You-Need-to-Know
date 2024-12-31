
<h1 style="text-align: center;">C# Specifiers Explained: What You Need to Know</h1>
<p align="center">
  Understanding C# Access Modifiers for Improved Code Control
</p>
<br/>

<p align="center">
   <img src="https://github.com/user-attachments/assets/850c4978-a32e-4c19-8e3f-5ecbe540434a" />
</p>

<br/>


We use specifiers to manage the accessibility of our classes and methods. There are four different types of specifiers: `public`, `private`, `protected`, `internal`, and `protected internal`.


### Public Specifier

The `public` specifier is accessible at all levels of the project. <br/>

> An important point is that the public specifier can also be accessed by other assemblies when your DLL is referenced.


#### Product.cs

<br/>

```C#
namespace Specifiers;

public class Product
{
    private string? _productName;
    public string? ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }
    public string GetProductName()
    {
        return ProductName ?? "";
    }
}
```


#### Program.cs

<br/>

```C#
Product newProduct = new Product();
newProduct.ProductName = "Test Product";
newProduct.GetProductName();
```
<br/>

As you can see, we can access the public methods and fields anywhere in the project.

### Private Specifier

The private specifier is accessible only within the class where it is defined. <br/>


> Other assemblies cannot access the private specifier, even when your DLL is referenced.


#### Product.cs

<br/>

```C#
namespace Specifiers;

public class Product
{
    private string? _productName;
    public string? ProductName
    {
        get { return _productName; }
        set { _productName = value; }
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
}
```

<br/>

<p align="center">
   <img src="https://github.com/user-attachments/assets/345cb206-69d6-4b5d-84ff-eaecf4c33e3d" />
</p>

<br/>

As you can see, we cannot access the private method in `Program.cs`. However, we can access the private method in `Product.cs`


### Protected Specifier

The protected specifier can be accessed within the same class and in derived classes. 

<br/>

> If your derived class is in another assembly, your protected methods are still accessible.


#### Product.cs


```C#
namespace Specifiers;

public class Product
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
        if (!CheckProductIsAvailable())
        {
        return "Product is not available";
        }
        return ProductName ?? "";
    }

    private bool IsProductAvailable()
    {
        return false;
    }

    protected bool? GetProductStatus()
    {
        return _productStatus;
    }
}
```
<br/>


<p align="center">
   <img src="https://github.com/user-attachments/assets/93639381-0554-483a-bb5d-ab32dee8c56a" />
</p>

<br/>

As you can see, we cannot access the `GetProductStatus` method in the `Program.cs` file.

However, when I make the `Product.cs` class abstract, we can access the protected methods in the derived class.

#### Product.cs

```C#
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
}
```

#### Computer.cs

```C#
namespace Specifiers;

public class Computer : Product
{
    protected override bool? GetProductStatus()
    {
    return base.GetProductStatus();
    }
}
```

### Internal Specifier

The internal specifier can be accessed anywhere within the project.

<br/>

> Other assemblies cannot access the internal specifier, even when your DLL is referenced.


#### Product.cs

```C#
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
```


#### Program.cs

```C#
using Specifiers;

Product computer = new Computer();
computer.ProductPrice = 150;
computer.GetProductPrice();
```

#### ProtectedInternal Specifier

The protectedInternal specifier is accessible at all levels within the project, as well as by other assemblies when your DLL is referenced. 

<br/>

> If your derived class is in another assembly, your `protectedInternal` methods are accessible.

<br/>

> I did not include an example of the `protectedInternal` specifier because it is very similar to the `public` specifier. The only difference is that while the `public` specifier is accessible everywhere, including in other assemblies and external code, the `protectedInternal` specifier cannot be accessed by external code in other assemblies."

<br/>

For more articles, <a href="https://www.firattonak.com" target="_blank">visit FiratTonak.com</a>

