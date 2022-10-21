using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;

namespace Source;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // frame.Source = new Uri("https://www.google.com/");



        // Button
        // RepeatButton
        // ToggleButton
        // CheckBox
        // RadioButton
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



    // int counter = 0;
    // private void Button_Click(object sender, RoutedEventArgs e)
    // {
    //     textBlock.Text = counter++.ToString();
    // }



    private void RepeatButton_Click(object sender, RoutedEventArgs e)
    {
        //if (sender is RepeatButton btn)
        //{
        //    progressBar.Value = (btn.HorizontalAlignment == HorizontalAlignment.Left)
        //        ? --progressBar.Value
        //        : ++progressBar.Value;
        //}
    }

    private void ToggleButton_Checked(object sender, RoutedEventArgs e)
    {
        MessageBox.Show((sender as ToggleButton)?.IsChecked.ToString());
    }

    private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
    {
        MessageBox.Show((sender as ToggleButton)?.IsChecked.ToString());
    }
}
