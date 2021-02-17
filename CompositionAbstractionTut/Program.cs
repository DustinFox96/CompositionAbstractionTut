using System;

namespace CompositionAbstractionTut {
    class Program {
        static void Main(string[] args) {

            var rect1 = new Rect(3, 8);
            Console.WriteLine($"Perimeter is {rect1.Perimeter()}");
            Console.WriteLine($"Area      is {rect1.Area()}");

        }
    }
}
