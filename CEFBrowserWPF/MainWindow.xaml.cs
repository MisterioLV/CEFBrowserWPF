﻿using CefSharp;
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

namespace CEFBrowserWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICommand forwardCommand { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Load(AddressBar.Text);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Load("http://www.google.com");
        }
        
        // Working on these two
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Back();
        }

        public void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Forward();
        }
    }
}
