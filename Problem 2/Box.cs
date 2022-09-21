using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    internal class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {((2 * this.length * this.Width) + (2 * this.length * this.Height) + (2 * Width * Height)):f2}");
            sb.AppendLine($"Lateral Surface Area - {((2 * this.length * this.Height) + (2 * this.Width * this.Height)):f2}");
            sb.Append($"Volume - {(this.length * this.Height * this.Width):f2}");

            return sb.ToString();
        }
    }
}

