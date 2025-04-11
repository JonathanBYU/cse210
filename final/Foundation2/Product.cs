using System;

class Product
{
    private string _name;
    private int _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int productId, double pricePerUnit, int quantity) {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _quantity * _pricePerUnit;
    }

    public string GetProductLabel()
    {
        return $"Name: {_name}, ProductId: {_productId}";
    }
}