using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnemploymentAssistant.Models
{
    public class JobApplication
    {
        public JobApplication()
        {
            CompanyName = "default";
            PositionName = "default";
            AppliedDate = DateTime.Now;
            Url = "default";
        }

        public JobApplication(string companyName, string positionName, DateTime appliedDate, string url)
        {
            CompanyName = companyName;
            PositionName = positionName;
            AppliedDate = appliedDate;
            Url = url;
        }

        public string CompanyName { get; set; }

        public string PositionName { get; set; }

        public DateTime AppliedDate { get; set; } = DateTime.Now;

        public string Url { get; set; }
    }
}
