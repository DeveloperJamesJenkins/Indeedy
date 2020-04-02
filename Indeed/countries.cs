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
        Argentina,
        [EnumMember(Value = "au")]
        Australia,
        [EnumMember(Value = "at")]
        Austria,
        [EnumMember(Value = "bh")]
        Bahrain,
        [EnumMember(Value = "gb")]
        gb


    }
}
