using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Indeed
{
    
    [DataContract]
    public class Result 
    {

        [BsonId]
        public DateTime date { get { return DateTime.UtcNow; } }

        [DataMember(Name = "version")]
        public string Version{ set; get; }

        [DataMember(Name = "query")]
        public string Query { set; get; }

        [DataMember(Name = "location")]
        public string Location { set; get; } 


        [DataMember(Name = "paginationPayload")]
        public string PaginationPayload { set; get; }

        [DataMember(Name = "radius")]
        public int Radius { set; get; }

        [DataMember(Name = "dupefilter")]
        public bool Dupefilter { set; get; }

        [DataMember(Name = "highlight")]
        public bool Highlight { set; get; }

        [DataMember(Name = "totalResults")]
        public int TotalResults { set; get; }

        [DataMember(Name = "start")]
        public int Start { set; get; }

        [DataMember(Name = "end")]
        public int End { set; get; }

        [DataMember(Name = "pageNumber")]
        public int PageNumber { set; get; }

        
        [DataMember(Name = "results")]
        public Job[] Jobs { get; set; }
 
    }
}
