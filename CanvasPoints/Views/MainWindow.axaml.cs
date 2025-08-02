using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using CanvasPoints.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace CanvasPoints.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
    public void CanvasPointerPressed(object sender, PointerPressedEventArgs e)
    {
        Point point = e.GetPosition(sender as Control);

        var viewModel = (MainWindowViewModel)DataContext;

        //ObservableCollection<MyEllipse> EllipseList = viewModel.EllipseList;
        viewModel.EllipseList.Add(new MyEllipse(Convert.ToInt32(point.X)-15, Convert.ToInt32(point.Y)-15));
    }
}