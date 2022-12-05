using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TodoListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void HandleTexttChanged(object sender, TextChangedEventArgs args)
        {
            Console.WriteLine(args.NewTextValue);
        }
           
    }
}
