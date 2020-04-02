using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Indeed
{
    public class Search
    {

        public Result Load(Query Query)
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append("http://api.indeed.com/ads/apisearch?");
            sb.Append("q=" + Query.SearchPhrase);
          
            foreach (var prop in Query.GetType().GetProperties())
            {
                string name = prop.Name.ToLower();
                var value = prop.GetValue(Query, null);

                switch(name)
                {
                    case "version":
                        name = "v";
                        break;

                    case "location":
                        name = "l";
                        break;

                    case "country":
                        name = "co";
                        break;

                    case "jobtype":
                        name = "jt";
                        break;

                    case "channel":
                        name = "chnl";
                        break;


                    case "searchphrase":
                        continue;
                  
                }

                sb.Append("&" + name + "=" + value);
 

            }

            string link = sb.ToString();

             HttpWebRequest searchRequest = (HttpWebRequest)WebRequest.Create(link);
            searchRequest.Method = "Get";

            using WebResponse searchResponse = searchRequest.GetResponse();
 
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Result));
            object objResponse = jsonSerializer.ReadObject(searchResponse.GetResponseStream());
            Result jsonResponse = objResponse as Result;

            return jsonResponse;

        }
 
    }
}
