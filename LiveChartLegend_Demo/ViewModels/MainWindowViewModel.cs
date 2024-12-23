using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LiveChartLegend_Demo.ViewModels
{
    public class MainWindowViewModel
    {

        public string[] Labels { get; private set; }
        public SeriesCollection SeriesCollection { get; private set; } = new SeriesCollection();
        public MainWindowViewModel() 
        {
            SeriesCollection = new SeriesCollection
            {
                // 添加假数据并设置填充颜色
                new LineSeries
                {
                    Title = "曲线 1",
                    Values = new ChartValues<double> { 3, 7, 2, 5, 6 },
                    Fill = new SolidColorBrush(Colors.LightBlue), // 设置填充颜色
                    PointGeometry = null // 禁用点的几何形状
                },
                new LineSeries
                {
                    Title = "曲线 2",
                    Values = new ChartValues<double> { 4, 2, 5, 6, 3 },
                    Fill = new SolidColorBrush(Colors.LightCoral), // 设置填充颜色
                    PointGeometry = null // 禁用点的几何形状
                }
                // 添加更多曲线...
            };
            // 创建标签数组
            Labels = new string[] { "一", "二", "三", "四", "五" };
        }
    }
}
