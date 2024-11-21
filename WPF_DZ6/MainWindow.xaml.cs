using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
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

namespace WPF_DZ6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; } = new() 
        {
            new Product("Images/NoneImage.png", "dd", Unit.milliliter, 750)
        };
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Products;
        }
        private void Button_Add(object sender, RoutedEventArgs e)
        {
            ProductChange productChange = new ProductChange();
            productChange.DataContext = new Product();
            if (productChange.ShowDialog() == true)
            {
                Products.Add((Product)productChange.DataContext);
                ProductsList.SelectedItem = Products[^1];
            }
        }

        private void Button_Change(object sender, RoutedEventArgs e)
        {
            if (ProductsList.SelectedItem == null)
            {
                return;
            }
            int index = ProductsList.SelectedIndex;
            ProductChange productChange = new ProductChange();
            productChange.DataContext = new Product((Product)ProductsList.SelectedItem);
            if (productChange.ShowDialog() == true)
            {
                Products[index] = (Product)productChange.DataContext;
            }
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if (ProductsList.SelectedItem is null)
            {
                return;
            }
            Products.Remove((Product)ProductsList.SelectedItem);
        }
    }
}