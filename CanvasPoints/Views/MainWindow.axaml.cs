using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Avalonia.VisualTree;
using CanvasPoints.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace CanvasPoints.Views;

public partial class MainWindow : Window
{
    private MyEllipse? _draggedEllipse;
    private Point _initialMousePosition;
    private bool _isDragging;
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
    public void Ellipse_PointerPressed(object sender, PointerPressedEventArgs e)
    {
        if(sender is Ellipse ellipse && ellipse.DataContext is MyEllipse myEllipse)
        {
            _isDragging = true;
            _draggedEllipse = myEllipse;
            _initialMousePosition = e.GetPosition(this.GetVisualRoot() as Control);
            e.Handled = true;
        }
    }
    public void Ellipse_PointerMoved(object sender, PointerEventArgs e)
    {
        if(_isDragging && _draggedEllipse != null)
        {
            var currentMousePosition = e.GetPosition(this.GetVisualRoot() as Control);
            var offset = currentMousePosition - _initialMousePosition;
            _draggedEllipse.PointX += (int)offset.X;
            _draggedEllipse.PointY += (int)offset.Y;
            _initialMousePosition = currentMousePosition;

        }
    }
    private void Ellipse_PointerReleased(object? sender, PointerReleasedEventArgs e)
    {
        _isDragging = false;
        _draggedEllipse = null;
    }
}