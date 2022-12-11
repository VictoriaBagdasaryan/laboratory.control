using ComputerClub.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для ComputerView.xaml
    /// </summary>
    public partial class ComputerView : Window
    {
        public Computer Computer { get; private set; }
        public ComputerView(Computer computer, ObservableCollection<ComputerStatus> listOfComputerStatuses)
        {
            InitializeComponent();
            Computer = computer;
            ComputerStatusTextBox.ItemsSource = listOfComputerStatuses;
            ComputerStatusTextBox.SelectedItem = Computer.ComputerStatus;
            DataContext = Computer;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void ComputerStatusTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Computer.ComputerStatus = (ComputerStatus)ComputerStatusTextBox.SelectedItem;
            Computer.StatusID = ((ComputerStatus)ComputerStatusTextBox.SelectedItem).StatusID;
        }
    }
}
