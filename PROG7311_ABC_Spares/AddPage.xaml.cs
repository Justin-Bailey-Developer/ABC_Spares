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
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {

        Singleton s;

        public AddPage()
        {
            InitializeComponent();

            s = Singleton.getInstance;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            if(txbPartName.Text != null && txbPartName.Text != null && IsDigitsOnly(txbPrice.Text))
            {
                string partName = txbPartName.Text;
                
                double partPrice = Convert.ToDouble(txbPrice.Text);

                Part part = new Part(GeneratePartID(), partName, partPrice);

                s.AddPart(part.toString());
            }
            else
            {
                MessageBox.Show("Invalid input. Try again");
            }
            

        }

        //generate a new unique part id
        public string GeneratePartID()
        {
            Part lastPart = s.getParts().LastOrDefault();

            int newId = Convert.ToInt32(lastPart.PartId) + 1;

            return (newId.ToString());

        }

        /*
         * Code Attribution
         * Stackoverflow: jakobbotsch
         * https://stackoverflow.com/questions/7461080/fastest-way-to-check-if-string-contains-only-digits
         */ 
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        //End Attribution
    }
}
