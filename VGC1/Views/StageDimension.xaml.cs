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

namespace VGC1
{
    /// <summary>
    /// Interaction logic for StageDimension.xaml
    /// </summary>
    public partial class StageDimension : Window
    {
        MainWindow parent1;
        int dimY,dimX;

        public StageDimension()
        {
            InitializeComponent();
        }
        public StageDimension(MainWindow parent)
        {
            InitializeComponent();
            parent1 = parent;
            
           
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dimX = Convert.ToInt16(TextBoxX.Text);
            dimY = Convert.ToInt16(TextBoxY.Text);
            int col = (int)(dimX - (dimX % 1.2) / 1.2);
            int row = (int)(dimY - (dimY % 1.2) / 1.2);
            Dimention dim = new Dimention(col, row);
            Stage stage = new Stage(dim);
            StageCreator create = new StageCreator(parent1,stage);
            create.Show();
            this.Hide();

        }
    }
}
