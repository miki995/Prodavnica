using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodavnica
{
    class Item
    {
        private string name;
        private string quantity;
        private double price;

     
        public string Name
        {
            get
            {
                return name;
            }    
                
            set
            {
                if (value.Length == 0)
                    throw new Exception("Naziv ne smije biti prazan");
                name = value;
            }
        }
        public string Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value.Length == 0)
                    throw new Exception("Kolicina ne smije biti 0");
                quantity = value;
            }

        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value.Equals(0))
                    throw new Exception("Kolicina ne smije biti 0");
                price = value;
            }
        }

        public Item(string name,string quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;

        }
        public override string ToString()
        {
            return Name + " " + Quantity;
        }

        public string PDV(Item shop)
        {
            return Math.Round((17 * shop.Price / 100), 2).ToString();

        }

        public string Serialize()
        {
            return name + '|' + quantity + '|' + price; 
        }

        public static Item Deserialize(string serialized)
        {
            string[] parts = serialized.Split('|');

            string name = parts[0];
            string quantity = parts[1];
            double price = Double.Parse(parts[2]);

            return new Item(name, quantity, price);
        }

      
    }
}
