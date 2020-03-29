using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace MyDemo.Framwork.AllPanls
{
    /// <summary>
    /// InkCanvas.xaml 的交互逻辑
    /// </summary>
    public partial class InkCanvas : Window
    {
        public InkCanvas()
        {
            InitializeComponent();
        }

        private void Button_Initialized(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.inkcan.EditingMode = (InkCanvasEditingMode)this.comboBox.SelectedItem;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (InkCanvasEditingMode item in Enum.GetValues(typeof(InkCanvasEditingMode)))
            {
                this.comboBox.Items.Add(item);
            }
            this.comboBox.SelectedIndex = 0;
        }
    }
}
