using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAbstractionTut {
    class Sqr {
        
        public Rect rect { get; set; }

        public int Perimeter() {
            return rect.Perimeter();
        }

        public int Area() {
            return rect.Area();
        }

        public Sqr() { }

        public Sqr(int s1) {
            this.rect = new Rect(s1, s1);
        }

        
    }
}
