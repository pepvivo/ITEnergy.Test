using System.Collections;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;

namespace Test
{
    public class PersonHelper
    {
        public static string GetPersonName(object person)
        {
            switch (person)
            {
                case StaffMember staffMember:
                    return staffMember.Name;
                case Customer customer:
                    return customer.Name;
            }
            return null;
        }

        public static object GetPersonType(object person)
        {
            switch (person)
            {
                case StaffMember staffMember:
                    return staffMember.Type;
                case Customer customer:
                    return customer.Type;
            }
            return null;
        }
    }
}