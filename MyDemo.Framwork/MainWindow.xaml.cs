using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

namespace MyDemo.Framwork
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var human = this.FindResource("human") as Human;
            if (human != null)
            {
                MessageBox.Show(human.Clild.Name);
            }
        }
    }

    [TypeConverter(typeof(StringConverHuman))]
    public class Human
    {
        public Human Clild { get; set; }
        public string Name { get; set; }
    }

    public class StringConverHuman : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string name = value.ToString();

            var child = new Human();
            child.Name = name;
            return child;
        }
    }
}
