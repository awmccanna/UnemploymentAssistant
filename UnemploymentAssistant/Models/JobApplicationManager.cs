using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnemploymentAssistant.Models
{
    public class JobApplicationManager
    {
        public static ObservableCollection<JobApplication> JobApplications = new ObservableCollection<JobApplication>() {
            // Temp hardcode
            new JobApplication("Warner Bros Discovery", "Staff Software Engineer (R000074972)", DateTime.Today, "https://careers.wbd.com/global/en/job/R000074972/Staff-Software-Engineer"),
        };

        public static ObservableCollection<JobApplication> GetJobApplications()
        {
            return JobApplications;
        }

        public static void AddJobApplication(JobApplication job)
        {
            JobApplications.Add(job);
        }
    }
}
