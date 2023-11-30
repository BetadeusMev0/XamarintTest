using App1.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            XTasks_mvvm mvvm = new XTasks_mvvm();
            mvvm.tasks.Add(new XTask("name", "description", false));
            mvvm.tasks.Add(new XTask("test", "descripdas", true));

            

        }
    }
}