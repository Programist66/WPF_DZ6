using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DZ6
{
    public class Unit
    {
        public static Unit gramme {get;} = new Unit("гр.");
        public static Unit milliliter { get;} = new Unit("мл.");
        public static Unit things { get;} = new Unit("шт.");

        public static IReadOnlyList<Unit> All { get; } =
        [
            gramme, milliliter, things
        ];

        public string Name { get;set;}
        private Unit(string name) 
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
