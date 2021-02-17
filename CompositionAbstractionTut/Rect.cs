using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAbstractionTut {
    class Rect {
        public Quad quad { get; set; }
        // here are the changes needed in order to make double work with int because of the changes made in Quad.
        public int Perimeter() {
            var p = quad.Perimeter(); //make notes as to what's happening here 
            var pi = Convert.ToInt32(p);
            return pi;

        }
        public double PerimeterAsDouble() {
            return quad.Perimeter(); 
        }

        public int Area() {
            return Convert.ToInt32(quad.Side1 * quad.Side2); // we are using the quad. becuase it the quad class that has the side1 and side2 properties, we have to call it here to make it work with Rect
        }

        public Rect() { }

        public Rect(int s1, int s2) {
            this.quad = new Quad(s1, s2, s1, s2);// this. was used to tell it that the two quads were the same thing and that they were properties of the class
        }
    }
}
