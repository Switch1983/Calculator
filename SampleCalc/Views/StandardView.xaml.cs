using System;
using System.Collections.Generic;
using System.Linq;
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

namespace SampleCalc.Views
{
    /// <summary>
    /// Interaction logic for StandardView.xaml
    /// </summary>
    public partial class StandardView : Window
    {
        public StandardView()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = (MenuItem)sender;

            switch (mnu.Name)
            {
                case "Standard":
                    Views.StandardView view = new Views.StandardView();
                    view.DataContext = new ViewModels.StandardViewModel();
                    view.Show();
                    this.Close();
                    break;

                case "Scientific":
                    Views.ScientificView view2 = new Views.ScientificView();
                    view2.DataContext = new ViewModels.ScientificViewModel();
                    view2.Show();
                    this.Close();
                    break;
            }
        }
    }
}
