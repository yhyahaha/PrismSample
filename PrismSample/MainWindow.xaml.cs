using MahApps.Metro.Controls;
using System;

namespace PrismSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MetroWindow_Closed(object sender, System.EventArgs e)
        {
            //(this.DataContext as IDisposable)?.Dispose();
        }
    }
}
