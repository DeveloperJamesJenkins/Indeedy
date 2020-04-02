using System;
using System.Runtime.Serialization;

namespace Indeed
{
    [DataContract]
    public class Job
    {
        [DataMember(Name = "company")]
        public string Company { set; get; }

        [DataMember(Name = "city")]
        public string City { set; get; }

        [DataMember(Name = "country")]
        public string Country { set; get; }

        [DataMember(Name = "date")]
        public string Date { set; get; }

        [DataMember(Name = "expired")]
        public bool Expired { set; get; }

        [DataMember(Name = "formattedLocation")]
        public string FormattedLocation { set; get; }

        [DataMember(Name = "formattedLocationFull")]
        public string FormattedLocationFull { set; get; }

        [DataMember(Name = "formattedRelativeTime")]
        public string FormattedRelativeTime { set; get; }

        [DataMember(Name = "indeedApply")]
        public bool IndeedApply { set; get; }

        [DataMember(Name = "jobkey")]
        public string Key { set; get; }

        [DataMember(Name = "jobtitle")]
        public string Title { set; get; }

        [DataMember(Name = "language")]
        public string Language { set; get; }

        [DataMember(Name = "latitude")]
        public decimal Latitude { set; get; }

        [DataMember(Name = "longitude")]
        public decimal Longitude { set; get; }

        [DataMember(Name = "onmousedown")]
        public string OnMouseDown { set; get; }

        [DataMember(Name = "refNum")]
        public string RefNum { set; get; }

        [DataMember(Name = "snippet")]
        public string Snippet { set; get; }

        [DataMember(Name = "source")]
        public string Source { set; get; }

        [DataMember(Name = "sponsored")]
        public string Sponsored { set; get; }

        [DataMember(Name = "slate")]
        public string State { set; get; }

        [DataMember(Name = "slations")]
        public string Stations { set; get; } //?

        [DataMember(Name = "url")]
        public Uri URL { set; get; }



    }
}
