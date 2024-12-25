namespace _3_encapsulation
{
       class Program
       {

              public static Helper helper = new Helper();
              public static Circle circle = new Circle();

              public static void Main(string[] args)
              {
                     Person person = new Person();

                     person.Name = "Dody";
                     System.Console.WriteLine(person.Name);

                     Person[] persons = new Person[3];
                     persons[0] = new Person { Name = "John" };
                     persons[1] = new Person {Name = "Alice"};
                     persons[2] = new Person {Name = "Bob"};
                     System.Console.WriteLine(persons.Length);

                     foreach (Person item in persons)
                     {
                            System.Console.WriteLine(item.Name);
                     }
                     System.Console.WriteLine("================================================================");

                     // BRAND
                     Car car = new Car();
                     car.Brand = "Toyota";
                     System.Console.WriteLine(car.Brand);
                     System.Console.WriteLine("================================================================");

                     // method
                     int a = 4;
                     int b = 12;
                     System.Console.WriteLine(helper.plus(a, b));
                     System.Console.WriteLine(helper.minus(a, b));
                     System.Console.WriteLine(helper.divide(a, b));
                     System.Console.WriteLine(helper.multiply(a, b));

                     circle.Radius = 5;
                     System.Console.WriteLine(circle.CaculateArea());

                     Student[] students = {new Student {Name = "John", Age = 12}, new Student {Name = "Alice", Age = 22} };
                     System.Console.WriteLine(students.Length);
                     foreach (Student  item in students) {
                            item.DisplayInfo();
                     }


                     int[] numbers = { 2, 10, 12,  8, 5 };
                     System.Console.WriteLine("Before sort");
                     foreach (var item in numbers)
                     {
                            System.Console.WriteLine(item);
                     }
                     helper.sortArray(numbers);
                     System.Console.WriteLine("After sort");
                     foreach (var item in numbers)
                     {
                            System.Console.WriteLine(item);
                     }


              }
       }
}