

using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AKTimeTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            static string[] Scopes = { CalendarService.Scope.Calendar };
            static string ApplicationName = "Google Calendar API .NET Quickstart";

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // Initialize Calendar service with valid OAuth credentials
            Google.Apis.Calendar.v3.Data.Calendar service = new Google.Apis.Calendar.v3.Data.Calendar();
            service.Summary = textBoxDesc.ToString();

        }
    }
}
