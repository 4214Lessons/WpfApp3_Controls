using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Source;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // frame.Source = new Uri("https://www.google.com/");
    }

    private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var listBox = sender as ListBox;
        // ListView



        if (listBox?.SelectedItem is ListBoxItem lboxItem)
        {
            var label = lboxItem.Content as Label;
            MessageBox.Show(label?.Content.ToString());
        }
        else if (listBox?.SelectedItem is Label lbl)
        {
            MessageBox.Show(lbl.Content.ToString());
        }
    }

    private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        //if (lbl is not null)
        //{
            //var slider = sender as Slider;
            //lbl.FontSize = slider?.Value ?? 10;
        //}
    }
}
