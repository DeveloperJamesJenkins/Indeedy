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

        /// <summary>
        /// Publisher ID. Indeed assigns the Publisher ID after you create a Publisher account. Locate this ID on the XML Feed tab of your Publisher account.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Version of the API. You must set this value to 2.
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// The IP address of the end user who will view job results from your website.
        /// </summary>
        public IPAddress UserIP { get; set; }

        /// <summary>
        /// The browser of the end user who will view job results from your website. You can obtain this parameter using the User-Agent HTTP request header from the end user.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Output format of the API. You can specify xml or json. Default = XML
        /// </summary>
        public Format Format { get; set; }

        /// <summary>
        /// Callback. The name of JavaScript callback function for passing search results. This parameter applies only when format is json.Note: For security reasons, you must restrict the callback name to letters, numbers, and the underscore character. Default = EMPTY
        /// </summary>
        public string Callback { get; set; }


        /// <summary>
        /// Query. By default, terms are ANDed. Tip: To format the search words for q, perform your search from the Job Search page.The URL displays the expected formatting for this parameter.For example, q= developer or q = java + developer.
        /// </summary>
        public string SearchPhrase { get; set; }


        /// <summary>
        /// Location. Use a postal code or a "city, state/province/region" combination. For example, l=Austin%2C+TX. Tip: Use the Job Search or Advanced Job Search page and inspect the URL to see how to encode your parameter values.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Distance from the search location (point-to-point aerial transit path, or "as the bird flies"). Note: The unit for this parameter is local to the country.For example, the default is 25 miles in the United States and 25 kilometers in the Netherlands. Default = 25
        /// </summary>
        public int Radius { get; set; }

        /// <summary>
        /// Site type. To show only jobs from job boards, use jobsite. For jobs from direct employer websites, use employer.
        /// </summary>
        public SiteType SiteType { get; set; }

        /// <summary>
        /// Sort by relevance or date.
        /// </summary>
        public SortType SortType { get; set; }

        /// <summary>
        /// Job type. You can specify fulltime, parttime, contract, internship, or temporary.	
        /// </summary>
        public JobType JobType { get; set; }

        /// <summary>
        /// Start returning jobs at this result number, beginning at 0. Note: You can use the start and limit parameters for pagination.
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// Maximum number of results to return per query. The maximum value is 25. Note: You can use the start and limit parameters for pagination. Default = 10
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Number of days since a job was published. If you specify 15, for example, the API searches jobs published only within the last 15 days.
        /// </summary>
        public int FromAge { get; set; }

        /// <summary>
        /// Highlight query terms. If you specify 1, this parameter applies boldface to the terms present in q.
        /// </summary>
        public bool Highlight { get; set; }

        /// <summary>
        /// Filter out duplicate jobs. To turn this off, specify 0.
        /// </summary>
        public bool HideDuplicates { get; set; }

        /// <summary>
        /// Latitude and longitude information. To return this information for each job result, set to 1.
        /// </summary>
        public bool IncludeLatLong { get; set; }

        /// <summary>
        /// Country to search. See Supported Countries for the complete list
        /// </summary>
        public Countries Country { get; set; }

        /// <summary>
        /// Channel name for grouping API requests. If you want to use this API for multiple websites, include a channel name here.
        /// </summary>
        public string Channel { get; set; }


    }
}
