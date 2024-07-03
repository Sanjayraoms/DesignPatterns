using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClosedPrinciple
{
    public enum Color
    {
        GREEN, YELLOW, RED
    }
    public enum Size
    {
        SMALL, MEDIUM, LARGE
    }
    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        // This Below Filtering patterns violates Open Closed Principle
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products,Color color)
        {
            foreach (var item in products)
            {
                if(item.Color == color)
                    yield return item;
            }
        }

        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var item in products)
            {
                if (item.Size == size)
                    yield return item;
            }
        }

        public IEnumerable<Product> FilterBySizeandColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var item in products)
            {
                if (item.Size == size && item.Color == color)
                    yield return item;
            }
        }

    }

    public interface ISpecification<T>
    {
        bool IsSatisfied(Product product);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColorSpec : ISpecification<Product>
    {
        private Color color;
        public ColorSpec(Color color)
        {
            this.color = color;
        }
        public bool IsSatisfied(Product product)
        {
            return product.Color == color;
        }
    }

    public class SizeSpec : ISpecification<Product>
    {
        private Size size;
        public SizeSpec(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Size == size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first,second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool IsSatisfied(Product product)
        {
            return first.IsSatisfied(product) && second.IsSatisfied(product);
        }
    }
    public class BetterFilter : IFilter<Product>
    {
        // Closed for Extension
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
        {
            foreach (var item in products)
            {
                if (spec.IsSatisfied(item))
                   yield return item;
            }
        }
    }
}
