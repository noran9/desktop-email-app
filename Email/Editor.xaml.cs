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

namespace Email
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : UserControl
    {
        public Editor()
        {
            InitializeComponent();

            List<double> sizes = new List<double>(){8, 10, 12, 14, 16, 18, 20, 22, 24, 28, 32, 48, 56, 72, 100 };
            string[] fonts = { "Arial", "Helvetica", "Times New Roman", "Times", "Courier New", "Courier", "Verdana", "Georgia", "Palatino", "Garamond", "Bookman", "Comic Sans MS", "Trebuchet MS", "Arial Black", "Impact" };

            size.ItemsSource = sizes;
            font.ItemsSource = fonts;

        }

        private void size_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            box.Selection.ApplyPropertyValue(Inline.FontSizeProperty, size.SelectedItem);
        }

        private void font_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            box.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, font.SelectedItem);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            box.Selection.ClearAllProperties();
        }

        private void _colorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            box.Selection.ApplyPropertyValue(ForegroundProperty, new SolidColorBrush((Color)(_colorPicker.SelectedColor)));
        }
    }
}
