namespace _5_Interface_Abstract
{
    class Program
    {
        public static void Main(string[] args)
        {
            //  Interface
            IsShape circle = new Circle { Radius = 4.2 };
            IsShape rectangle = new Rectangle { Width = 4.2, Height = 4.2 };
            System.Console.WriteLine(circle.CalculateArae());
            System.Console.WriteLine(rectangle.CalculateArae());

            System.Console.WriteLine("================================================");
            //  Abstract Class
            Animal dog = new Dog { Name = "Doggy" };
            dog.sleep();
            dog.eat();
        }
    }
}
