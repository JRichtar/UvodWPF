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

namespace ÚvodWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label label2 = new Label();

            label2.Content = "Welcome aboard, " + textbox1.Text + "!";
            label2.Height = 40;
            label2.Width = 479;
            label2.Foreground = new SolidColorBrush(Colors.Black);
            label2.HorizontalAlignment = HorizontalAlignment.Right;
            label2.VerticalAlignment = VerticalAlignment.Bottom;
            label2.FontFamily = new FontFamily("Cooper Black");
            label2.FontSize = 20;
            label2.Margin = new Thickness(0, 0, 10, 10);
            Grid.Children.Add(label2);

            textbox1.Clear();
            
        }
    }
}
