using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UnemploymentAssistant.ViewModel;

namespace UnemploymentAssistant.Views
{
    /// <summary>
    /// Interaction logic for AddJobApplication.xaml
    /// </summary>
    public partial class AddJobApplication : Window
    {
        public AddJobApplication()
        {
            InitializeComponent();
            AddJobApplicationViewModel addJobApplicationViewModel = new AddJobApplicationViewModel();
            this.DataContext = addJobApplicationViewModel;
            myDatePicker.SelectedDate = DateTime.Now;
        }
    }
}
