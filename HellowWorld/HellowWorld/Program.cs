using HellowWorld;
using HellowWorld.Math;

namespace HelloWorld
    {
        class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!!!");

            var Sam = new Person("Sam", "Tee");

            Sam.Introduce();

            var Calculator = new Calculator();

            Console.WriteLine(Calculator.Add(2, 3));
        }
    }
}