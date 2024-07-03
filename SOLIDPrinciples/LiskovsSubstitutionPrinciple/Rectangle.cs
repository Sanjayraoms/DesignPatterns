using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovsSubstitutionPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}:{Width},{nameof(Height)}:{Height}";
        }
    }

    public class Square : Rectangle
    {
        override public int Width { set { base.Width = base.Height = value; } }

        public override int Height { set => base.Width = base.Height = value; }

    }
}
