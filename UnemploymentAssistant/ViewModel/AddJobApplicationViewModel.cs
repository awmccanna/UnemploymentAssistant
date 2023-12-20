using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UnemploymentAssistant.Commands;
using UnemploymentAssistant.Models;

namespace UnemploymentAssistant.ViewModel
{
    public class AddJobApplicationViewModel
    {
        public ICommand AddJobApplicationCommand { get; set; }
        public string CompanyName { get; set; }
        public string PositionName { get; set; }
        public DateTime AppliedDate { get; set; } = DateTime.Today;
        public string Url { get; set; }

        public AddJobApplicationViewModel()
        {
            AddJobApplicationCommand = new RelayCommand(AddJobApplication, CanAddJobApplication);
        }

        private bool CanAddJobApplication(object obj)
        {
            return true;
        }

        private void AddJobApplication(object obj)
        {
            JobApplicationManager.AddJobApplication(new JobApplication() { CompanyName = CompanyName, PositionName = PositionName, AppliedDate = AppliedDate, Url = Url});
        }
    }
}
