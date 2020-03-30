using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Test;

public class StaffMember : IPerson
{
    public static StaffMember DefaultStaffMember = new StaffMember(null, "Default Staff Member");

    public StaffMember(IEnumerable<StaffMember> parentCollection, string name = null, StaffMemberType type = StaffMemberType.New)
    {
        ID = Guid.NewGuid();
        Index = (short)(parentCollection?.Count() ?? 0);
        Name = name;
        Type = type;
    }

    #region Fields

    private string _name;
    private StaffMemberType _Type;

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
    public StaffMemberType Type
    {
        get { return _Type; }
        set
        {
            _Type = value;
            OnType_Changed();
        }
    }

    public Guid ID { get; set; }
    public short Index { get; set; }

    public List<object> SoldProducts { get; set; }

    public string GetApplicationName()
    {
        return "";
    }

    public void AddBoughtProduct(object person)
    {
        //not needed
    }

    public void AddSoldProduct(object person)
    {
        SoldProducts.Add(person);
    }

    public void OnType_Changed()
    {
        Debug.Print($"{nameof(StaffMember)} Type changed to {Type}");
    }
    #endregion
}
