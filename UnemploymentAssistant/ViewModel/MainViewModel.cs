using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UnemploymentAssistant.Commands;
using UnemploymentAssistant.Models;
using UnemploymentAssistant.Views;

namespace UnemploymentAssistant.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<JobApplication> JobApplications { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            JobApplications = JobApplicationManager.GetJobApplications();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private void ShowWindow(object obj)
        {
            AddJobApplication addJobAppWin = new AddJobApplication();
            addJobAppWin.Show();
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }
    }
}
