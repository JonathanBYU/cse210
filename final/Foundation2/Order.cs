using System;

class Order
{
    private Product[] _productsList;
    private Customer _customer;

    public Order(Product[] productsList, Customer customer) {
        _productsList = productsList;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _productsList) {
            totalCost += product.GetTotalCost();
        }
        totalCost += _customer.GetAddress().IsUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _productsList) {
            packingLabel = packingLabel + '\n' + product.GetProductLabel();
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomer();
    }
}