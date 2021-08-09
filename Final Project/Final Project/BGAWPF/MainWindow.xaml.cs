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
using BGALib;
using HelloDictionaryWPF;
using Microsoft.Win32;

namespace BGAWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<TorrentInfo> torrentList;

        public MainWindow()
        {
            InitializeComponent();

            torrentList = new List<TorrentInfo>();

            displayTorrents();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void displayTorrents()
        {
            torrentList.Clear();

            TorrentInfo t1 = new TorrentInfo();
            t1.Name = "Zack Snyder's Justice League";
            t1.Size = "17.5 GB";
            t1.Speed = "12 MB/s";
            t1.Progress = 50;
            t1.Eta = "3 Hrs";            
            torrentList.Add(t1);

            TorrentInfo t2 = new TorrentInfo();
            t2.Name = "Lady Gaga - New Album 2021";
            t2.Size = "300 MB";
            t2.Speed = "2.7 MB/s";
            t2.Progress = 80;
            t2.Eta = "40 Min";
            torrentList.Add(t2);

            TorrentInfo t3 = new TorrentInfo();
            t3.Name = "Path of Exile 2 PC Demo";
            t3.Size = "35 GB";
            t3.Speed = "4.8 MB/s";
            t3.Progress = 25;
            t3.Eta = "5 Hrs";
            torrentList.Add(t3);
           
            list.ItemsSource = torrentList;
        }       

        private void LoadFile_Click(object sender, RoutedEventArgs e)
        {
            String input = string.Empty;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "BGA files (*.bga)|*.bga|All files (*.*)|*.*";
            bool? result = dlg.ShowDialog();
        }

        private void LoadManual_Click(object sender, RoutedEventArgs e)
        {
            ManualEntryWindow manualEntry = new ManualEntryWindow("", "", "BGA Network (default)");
            bool? result = manualEntry.ShowDialog();

            if (result.HasValue && result.Value)
            {
                string name = manualEntry.TorrentName;
                string size = manualEntry.Size;
                string network = manualEntry.Network;
            }
        }
        private void LoadOptions_Click(object sender, RoutedEventArgs e)
        {
            Options manualEntry = new Options();
            bool? result = manualEntry.ShowDialog();
        }
    }
}