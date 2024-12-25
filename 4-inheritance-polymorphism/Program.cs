namespace _4_inheritance_polymorphism
{
       class Program
       {
              public static void Main(string[] args)
              {
                     Cat cat = new Cat();
                     cat.Name = "Oyen";
                     cat.Eat();
                     cat.Meow();

                     System.Console.WriteLine("================================================");
                     Vehicle car = new Car {Brand = "Toyota", NumberOfDoors = 100};
                     Vehicle motor = new Motorcycle {Brand = "Herly"};
                     car.Drive();
                     motor.Drive();
              }
       }
}