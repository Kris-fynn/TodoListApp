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

        public void HandleTextChanged(object sender, TextChangedEventArgs args) 
        { 
           Console.WriteLine(args.NewTextValue);
        }

        public void HandleEnterPress(object sender, EventArgs args)
        {
            Console.WriteLine("Enter Pressed");
            Label newTodo = new Label();
            newTodo.Text = InputField.Text;
            newTodo.FontSize = 20;
            TodoList.Children.Add(newTodo);
            InputField.Text = "";
        }
           
    }
}
