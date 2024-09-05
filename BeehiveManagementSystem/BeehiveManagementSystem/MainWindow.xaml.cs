using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeehiveManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Queen _queen;

        public MainWindow()
        {
            InitializeComponent();
            _queen = new Queen();
        }

        private void AssignJob_Click(object sender, RoutedEventArgs e)
        {
            _queen.AssignBee(jobSelector.Text);
            statusReport.Text = _queen.StatusReport;
        }
        
        private void WorkShift_Click(object sender, RoutedEventArgs e)
        {
            _queen.WorkNextShift();
            statusReport.Text = _queen.StatusReport;
        }
    }
}