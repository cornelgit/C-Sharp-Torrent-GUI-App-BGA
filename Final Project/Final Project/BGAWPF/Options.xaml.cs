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
using System.Windows.Shapes;

namespace BGAWPF
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    /// 
    public partial class Options : Window
    {
        public string StartWithWindows { get; set; }
        public string MaxDownload { get; set; }
        public string MaxUpload { get; set; }
        public string UsePnP { get; set; }
        public string DefaultDirectory { get; set; }
        public string Minimize { get; set; }    

        public Options()
        {
            InitializeComponent();

            txtStartWith.Text = "Yes";
            txtDown.Text = "20 MBps";
            txtUp.Text = "10 MBps";
            txtPnp.Text = "When possible";
            txtDirectory.Text = "C://BGA Application/Downloads";
            txtMinimize.Text = "Always";
        }

        private bool ValidateFields()
        {
            bool result = true;

            return result;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                this.DialogResult = true;
                this.Close();
            }

            else
            {
                MessageBox.Show("Input not correct. Please fix input."
                    , "Error Input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
