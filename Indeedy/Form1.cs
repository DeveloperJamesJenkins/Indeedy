using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Indeed;

namespace Indeedy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 

            Query query = new Query();
            query.Publisher = "YOUR PUBLISHER ID";
            query.Version = 2;
            query.UserIP = IPAddress.Parse("127.0.0.1");
            query.UserAgent = "Mozilla/%2F4.0%28Firefox%29";
            query.SearchPhrase = "c%23";
            query.Radius = 100;
            query.Location = "Saltash";
            query.Country = Countries.GB;
            query.Format = Format.JSON; // XML NOT IMPLEMENTED
            query.FromAge = 30;
            query.Start = 0;
            query.Limit = 30;
            query.IncludeLatLong = true;
            query.HideDuplicates = true;
            query.SiteType = SiteType.JobSite;
            query.IncludeLatLong = true;
            query.SortType = SortType.Date;
            query.JobType = JobType.FullTime;


            Search search = new Search();
            Result result = search.Load(query);
        
        
        }


    }
}
