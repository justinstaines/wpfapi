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
using Xceed.Wpf.AvalonDock.Layout;
using System.IO;
using System.Net.Http;

namespace wpfapidemo
{
    /// <summary>
    /// (C) Copyright 2021 Justin Staines
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {


        public MainWindow()
        {


            InitializeComponent();
        }

        private void sendapioneButton_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            string apisend = "https://jsonplaceholder.typicode.com/todos/1";
            client.GetAsync(apisend);

        }

        private void sendapitwoButton_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            string apisend = "https://jsonplaceholder.typicode.com/todos/2";
            client.GetAsync(apisend);
        }
    }
}
