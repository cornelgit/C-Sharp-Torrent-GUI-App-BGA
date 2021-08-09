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
    /// Interaction logic for ManualEntryWindow.xaml
    /// </summary>
    public partial class ManualEntryWindow : Window
    {
        public string TorrentName { get; set; }
        public string Size { get; set; }
        public string Network { get; set; }
        public int Port { get; set; }

        public ManualEntryWindow(string name, string size, string network)
        {
            InitializeComponent();

            txtName.Text = name;
            txtSize.Text = size;
            txtNetwork.Text = network;
        }

        private bool ValidateFields()
        {
            bool result = true;

            result = result && !string.IsNullOrWhiteSpace(TorrentName);
            if (!result)
            {
                txtErrorName.Visibility = Visibility.Visible;
            }
            
            result = result && !string.IsNullOrWhiteSpace(Size);

            if (!result)
            {
                txtErrorName.Visibility = Visibility.Visible;
            }

            result = result && !string.IsNullOrWhiteSpace(Network);

            if (!result)
            {
                txtErrorName.Visibility = Visibility.Visible;
            }

            return result;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                TorrentName = txtName.Text;
                Size = txtSize.Text;
                Network = txtNetwork.Text;

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
