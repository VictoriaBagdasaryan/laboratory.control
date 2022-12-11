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
    /// Логика взаимодействия для VisitorView.xaml
    /// </summary>
    public partial class VisitorView : Window
    {
        public Visitor Visitor { get; private set; }
        public VisitorView(Visitor visitor)
        {
            InitializeComponent();
            Visitor = visitor;
            DataContext = Visitor;
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
