using System;

namespace OnlineMarket
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Kind { get; set; }

        public int CompareTo(Product other)
        {
            int pos = this.Price.CompareTo(other.Price);
            if (pos == 0)
            {
                pos = this.Name.CompareTo(other.Name);
            }
            return pos;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Price);
        }
    }
}
