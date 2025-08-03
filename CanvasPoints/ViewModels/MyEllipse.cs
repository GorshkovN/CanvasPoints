using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasPoints.ViewModels
{
    public class MyEllipse : INotifyPropertyChanged
    {
        private int _pointX;
        public int PointX
        {
            get => _pointX;
            set
            {
                if (_pointX != value)
                {
                    _pointX = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _pointY;
        public int PointY
        {
            get => _pointY;
            set
            {
                if (_pointY != value)
                {
                    _pointY = value;
                    OnPropertyChanged();
                }
            }
        }
        public MyEllipse(int PointX_, int PointY_)
        {
            PointX = PointX_;
            PointY = PointY_;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
