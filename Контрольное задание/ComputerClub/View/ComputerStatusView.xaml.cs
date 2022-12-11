using ComputerClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ComputerClub.View
{
    /// <summary>
    /// Логика взаимодействия для ComputerStatusView.xaml
    /// </summary>
    public partial class ComputerStatusView : Window
    {
        public ComputerStatus ComputerStatus { get; private set; }

        public ComputerStatusView(ComputerStatus computerStatus)
        {
            InitializeComponent();
            ComputerStatus = computerStatus;
            DataContext = ComputerStatus;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
