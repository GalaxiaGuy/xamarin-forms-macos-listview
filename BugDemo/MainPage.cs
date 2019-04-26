using System;
using Xamarin.Forms;

namespace BugDemo
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            BackgroundColor = Color.Red;
            Content = new ListView
            {
                Margin = new Thickness(20),
                BackgroundColor = Color.FromRgba(0, 0, 1, 0.5), 
                ItemsSource = new string[] { "Row 1", "Row 2", "Row 3" }
            };
        }
    }
}
