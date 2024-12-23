using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace LiveChartLegend_Demo.ViewModels
{
    public class CustomSeriesViewModel : INotifyPropertyChanged
    {
        public string Title { get => SeriesViewModel.Title; }
        public Brush Stroke { get => SeriesViewModel.Stroke; }

        public Brush Fill { get => SeriesViewModel.Stroke; }

        public SeriesViewModel SeriesViewModel { get; }

        public ISeriesView View { get; }

        public bool IsVisible
        {
            get => ((UIElement)View).Visibility == Visibility.Visible;
            set
            {
                if (IsVisible != value)
                {
                    ((UIElement)View).Visibility = value ? Visibility.Visible : Visibility.Hidden;

                    OnPropertyChanged();
                }
            }
        }

        public CustomSeriesViewModel(SeriesViewModel svm, ISeriesView view)
        {
            this.SeriesViewModel = svm;
            this.View = view;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
