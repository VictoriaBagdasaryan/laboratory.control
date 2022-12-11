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
    /// Логика взаимодействия для VisitView.xaml
    /// </summary>
    public partial class VisitView : Window
    {
        public Visit Visit { get; private set; }
        public VisitView(Visit visit, ObservableCollection<Computer> listOfComputers, ObservableCollection<Visitor> listOfVisitors)
        {
            InitializeComponent();
            Visit = visit;

            VisitorIDTextBox.ItemsSource = listOfVisitors;
            VisitorIDTextBox.SelectedItem = Visit.Visitor;

            ComputerIDTextBox.ItemsSource = listOfComputers;
            ComputerIDTextBox.SelectedItem = Visit.Computer;

            DataContext = Visit;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void VisitorIDTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Visit.Visitor = (Visitor)VisitorIDTextBox.SelectedItem;
            Visit.VisitorID = ((Visitor)VisitorIDTextBox.SelectedItem).VisitorID;
        }

        private void ComputerIDTextBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Visit.Computer = (Computer)ComputerIDTextBox.SelectedItem;
            Visit.ComputerID = ((Computer)ComputerIDTextBox.SelectedItem).ComputerID;
        }
    }
}
