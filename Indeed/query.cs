using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;

namespace Indeed
{
    public class Query
    {
 
        public string Publisher { get; set; }

        public int Version { get; set; }

        public IPAddress UserIP { get; set; }

        public string UserAgent { get; set; }

        public Format Format { get; set; }

        public string Callback { get; set; }

        public string SearchPhrase { get; set; }

        public string Location { get; set; }

        public int Radius { get; set; }

        public SiteType SiteType { get; set; }

        public SortType SortType { get; set; }

        public JobType JobType { get; set; }

        public int Start { get; set; }

        public int Limit { get; set; }

        public int FromAge { get; set; }

        public bool Highlight { get; set; }

        public bool HideDuplicates { get; set; }

        public bool IncludeLatLong { get; set; }

        public Countries Country { get; set; }

        public string Channel { get; set; }


    }
}
