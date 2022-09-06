using CefSharp.Wpf.HwndHost;
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

namespace TabbedCefSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NewTab();
            NewTab();
            NewTab();
            NewTab();
        }

        private void NewTabButton_Click(object sender, RoutedEventArgs e)
        {
            NewTab();
        }

        public void NewTab()
        {
            ChromiumWebBrowser Browser = new ChromiumWebBrowser("https://example.com");
            Browser.Address = "https://example.com";
            Tabs.Items.Add(new TabItem { Header = "Tab", Content = Browser });
        }

        private void CloseTabButton_Click(object sender, RoutedEventArgs e)
        {
            TabItem Tab = (TabItem)Tabs.Items[Tabs.SelectedIndex];
            ChromiumWebBrowser _Browser = (ChromiumWebBrowser)Tab.Content;
            Tab.Content = null;
            _Browser.Dispose();
            Tabs.Items.Remove(Tab);
        }
    }
}
