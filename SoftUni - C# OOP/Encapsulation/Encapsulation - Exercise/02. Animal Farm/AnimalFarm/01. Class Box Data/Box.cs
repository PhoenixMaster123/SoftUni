using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Class_Box_Data
{
    public class Box
    {
        // Encapsulation -> hide all data that shoudn't be accessible outside of the class/context
        // Always start with the highest encapsulation level and drop if the data is needed

        // private -> Visible only inside the current class
        // protected -> Visible in the current class and inherited class+
        // internal -> Visible in the current project
        // public -> Visible in the whole solution

        // constructors -> private, protected, public
        // const,field -> private
        // property -> public getter, private/protected setter
        // methods -> private, protected, public 


        //private const int BoxMinValue = 0;

        // Validation -> Use private fields + full property
        private double length;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Length = lenght;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {

                if (value <= 0) // BoxMinValue = 0;
                {
                    throw new ArgumentException($"{nameof(this.Length)} cannot be zero or negative.");
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
            private set
            {

                if (value <= 0) // BoxMinValue = 0;
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative."); // nameof -> string
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
            private set
            {

                if (value <= 0) // BoxMinValue = 0;
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative."); // nameof -> string
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }
        public double LateralSurfaceArea()

            => 2 * this.Length * this.Height + 2 * this.Width * this.Height; // => isEqual to return ; don't need breckets

        public double Volume()
        {
            return this.Length * this.Width * this.Height;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():F2}"); // AppendLine -> add on the first line
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():F2}");
            sb.AppendLine($"Volume - {this.Volume():F2}");

            return sb.ToString().TrimEnd(); // TrimEnd -> remove Empty spaces

        }


    }
}
 
