using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Indeed
{
    [DataContract]
    public enum Countries
    {

        [EnumMember(Value = "ar")]
        ar,
        [EnumMember(Value = "au")]
        au,
        [EnumMember(Value = "at")]
        at,
        [EnumMember(Value = "bh")]
        bh,
        [EnumMember(Value = "gb")]
        gb


    }
}
