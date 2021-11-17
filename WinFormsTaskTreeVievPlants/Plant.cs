using System;
using System.Collections.Generic;

namespace WinFormsTaskTreeVievPlants
{
    class Plant : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime DateWatering { get; set; }
        public Plant(string name, double price, DateTime dateWatering)
        {
            Name = name;
            Price = price;
            DateWatering = dateWatering;
        }

        public int CompareTo(object obj)
        {
            return String.Compare(this.Name, (obj as Plant).Name);
        }

    }

    class DateWateringComparer : IComparer<Plant>
    {
        public int Compare(Plant x, Plant y)
        {
            return DateTime.Compare(x.DateWatering, y.DateWatering);
        }
    }

    class PriceComparer : IComparer<Plant>
    {
        public int Compare(Plant x, Plant y)
        {
            if (x.Price > y.Price) return 1;
            else if (x.Price < y.Price) return -1;
            return 0;
        }
    }
}
