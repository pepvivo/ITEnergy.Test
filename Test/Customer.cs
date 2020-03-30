using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Test;

public class Customer : IPerson
{
    public static Customer DefaultCustomer = new Customer(null, "Default Customer");

    public Customer(IEnumerable<Customer> parentCollection, string name = null, CustomerType type = CustomerType.New)
    {
        ID = Guid.NewGuid();
        Index = (short)(parentCollection?.Count() ?? 0);
        Name = name;
        Type = type;
    }

    #region Fields

    private string _name;
    private CustomerType _type;

    #endregion

    #region Properties

    public string Name
    {
        get { return _name; }
        set
        {
            _name = value;
        }
    }
    public CustomerType Type
    {
        get { return _type; }
        set
        {
            _type = value;
            OnType_Changed();
        }
    }

    public Guid ID { get; set; }
    public short Index { get; set; }

    public List<object> BoughtProducts { get; set; }

    public string GetApplicationName()
    {
        return System.AppDomain.CurrentDomain.FriendlyName;
    }

    public void AddBoughtProduct(object person)
    {
        BoughtProducts.Add(person);
    }

    public void AddSoldProduct(object person)
    {
        //not needed
    }

    public void OnType_Changed()
    {
        Debug.Print($"{nameof(Customer)} Type changed to {Type}");
    }

    #endregion
}
