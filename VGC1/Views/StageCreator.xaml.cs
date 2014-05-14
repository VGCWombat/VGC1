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
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Shapes;
namespace VGC1
{
    /// <summary>
    /// Interaction logic for StageCreator.xaml
    /// </summary>
    public partial class StageCreator : Window
    {
        public StageCreator()
        {
            InitializeComponent();
        }
        public StageCreator(MainWindow parent, Stage st)
        {
            InitializeComponent();
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            System.Windows.Size max = new System.Windows.Size(workingRectangle.Width, workingRectangle.Height - 100);
            obszar.Measure(max);
            obszar.Arrange(new Rect(0, 0, max.Width, max.Height));
            int col = st.Dim.X;
            int row = st.Dim.Y;

            
            int wi = (int)((float)col / row * obszar.ActualHeight);
            int roz = (int)(obszar.ActualWidth - wi) / 2;

            Grid1.Width = roz;

            for (int i = 0; i < col; i++)
            {
                ColumnDefinition col1 = new ColumnDefinition();
                Grid.ColumnDefinitions.Add(col1);
             
            }
            for (int i = 0; i < row; i++)
            {
                RowDefinition row1 = new RowDefinition();
                Grid.RowDefinitions.Add(row1);

            }
                  
          
                
               


            
        }
    }
}
