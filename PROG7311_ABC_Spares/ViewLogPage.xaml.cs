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

namespace PROG7311_ABC_Spares
{
    /// <summary>
    /// Interaction logic for ViewLogPage.xaml
    /// </summary>
    public partial class ViewLogPage : Page
    {
                
        List<Log> Logs { get; set; }
        Singleton s;

        public ViewLogPage()
        {
            InitializeComponent();

            s = Singleton.getInstance;

            UpdateListView();
        }

        public void UpdateListView()
        {

            Logs = new List<Log>();

            
            
            foreach (Log l in s.getLog())
            {
                Logs.Add(l);                            
            }

            if (Logs.Count > 0)
            {
                lvLog.ItemsSource = Logs;
            }
            else
            {
                MessageBox.Show("No logs to show...");
            }
            
        }
    }
}
