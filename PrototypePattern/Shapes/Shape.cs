using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Shapes
{
    public abstract class Shape
    {
        public int x;
        public int y;
        public string? color;

        public Shape()
        {

        }

        public Shape(Shape target)
        {
            this.x = target.x;
            this.y = target.y;
            this.color = target.color;
        }

        public abstract Shape Clone();

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            Shape other = obj as Shape;
            return other.x == x && other.y == y && other.color == color;
        }
    }
}
