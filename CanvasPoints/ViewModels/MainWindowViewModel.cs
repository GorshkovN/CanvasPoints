using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace CanvasPoints.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<MyEllipse> EllipseList { get; set; }
        public MainWindowViewModel()
        {
            EllipseList = new ObservableCollection<MyEllipse>(new List<MyEllipse>
            {
                new MyEllipse(1,2),
                new MyEllipse(123,290),
                new MyEllipse(14,502),
                new MyEllipse(572,34),
                new MyEllipse(514,300),
                new MyEllipse(154,400),
                new MyEllipse(354,345),
                new MyEllipse(342,2),
                new MyEllipse(100,200)
            });
        }
    }
   
}
