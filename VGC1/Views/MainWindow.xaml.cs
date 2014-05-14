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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VGC1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Project project;
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Project project)
        {
            this.project = project;
            
            InitializeComponent();
        }

        private void MenuItem_Click(object sneder, RoutedEventArgs e)
        {
            this.project = DataGenerator.GetProject();
            
            StageDimension stage = new StageDimension(this);
           
            stage.Show();

        }
    }
}
