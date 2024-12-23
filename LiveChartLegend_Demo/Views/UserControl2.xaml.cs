using LiveChartLegend_Demo.ViewModels;
using System.Windows.Controls;

namespace LiveChartLegend_Demo
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            this.DataContext = new UserContorl2ViewModel();
        }
    }
}
