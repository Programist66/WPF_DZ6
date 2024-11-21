using Microsoft.Win32;
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

namespace WPF_DZ6
{
    /// <summary>
    /// Логика взаимодействия для ProductChange.xaml
    /// </summary>
    public partial class ProductChange : Window
    {
        public ProductChange()
        {
            InitializeComponent();
        }

        private void Button_ChoiseImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображение (*.png;*.jpg)|*.png;*.jpg|Все файлы(*.*)|*.*";
            if (dialog.ShowDialog() == true) 
            {
                ImageSource image = new BitmapImage(new Uri(dialog.FileName, UriKind.Absolute));
                imageBox.Source = image;
                ((Product)DataContext).Image = image;
            }                
        }
        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
