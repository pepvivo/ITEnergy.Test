using System;
using System.Collections.Generic;

public interface IPerson
{
    Guid ID { get; set; }
    short Index { get; set; }
    string GetApplicationName();
    void AddBoughtProduct(object person);
    void AddSoldProduct(object person);
}