using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Shapes
{
    public class Rectangle : Shape
    {
        public int width;
        public int height;

        public Rectangle()
        {

        }

        public Rectangle(Rectangle rectangle) : base(rectangle)
        {
            this.width = rectangle.width;
            this.height = rectangle.height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        public override bool Equals(object? obj)
        {
            if(obj is null) return false;
            Rectangle other = obj as Rectangle;
            return other.width == this.width && other.height == this.height;
        }
    }
}
