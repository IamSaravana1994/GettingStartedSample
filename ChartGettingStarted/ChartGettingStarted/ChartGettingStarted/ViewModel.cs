using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChartGettingStarted
{
    public class ViewModel
    {
        public List<Person> Data { get; set; }
        public ViewModel()
        {
            Data = new List<Person>()
            {
                new Person("David", 180),
                new Person("Micheal", 170),
                new Person("Steve", 160),
                new Person("Joel", 185),
                new Person("Mitchell", 165),
                new Person("Smith", 150),
                new Person("Joesph", 180),
                new Person("John", 170)
            };
        }
    }
}
