using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WPF_DZ6
{
    public class Product
    {
        public ImageSource Image { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public Unit Unit { get; set; }

        public Product() 
        {
            Image = new BitmapImage(new Uri("Images/NoneImage.png", UriKind.Relative));
            Name = "без названия";
            Unit = Unit.things;
        }

        public Product(string image, string name, Unit unit, int count)
        {
            Image = new BitmapImage(new Uri(image, UriKind.Relative));
            Name = name;
            Unit = unit;
            Count = count;
        }

        public Product(Product product)
        {
            Image = product.Image;
            Name = product.Name;
            Unit = product.Unit;
            Count = product.Count;
        }

        private static IReadOnlyList<Unit> allUnits = Unit.All;
        public IReadOnlyList<Unit> AllUnits => allUnits;
    }
}
