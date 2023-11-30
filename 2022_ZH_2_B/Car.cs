using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_ZH_2_B
{
    public class Car
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private int price;
        public int Price { get { return price; } set { price = value; } }
        private string type;
        public string Type { get { return type; } set { type = value; } }

        public Car(string name, int price, string type)
        {
            this.name = name;
            this.price = price;
            this.type = type;
        }
    }
}
