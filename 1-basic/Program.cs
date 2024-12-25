class Program
{
    //  properti
    private static int globalNumber = 20;
    private static int number = 82734;

    public static void Main(string[] args)
    {
        // declare variables
        int num1 = 10;
        int num2 = 10;
        System.Console.WriteLine(num1 + num2);
        string name = "John";
        name = "Alice"; // -> merubah nilai name menjadi Alice
        System.Console.WriteLine(name);
        double value = 10.1;
        System.Console.WriteLine(value);
        bool isTrue = true;
        System.Console.WriteLine(isTrue);

        // CONST
        const string nameConstant = "Andi";
        // nameConstant = "Agus"; // -> error karena const todak bisa dirubah
        System.Console.WriteLine(nameConstant);

        dynamic value1 = 2023;
        value1 = "Jadi string";
        value1 = true;
        System.Console.WriteLine(value1);

        var angka1 = 1; // otomatis akan ditek dipe data
        System.Console.WriteLine(angka1);
        var nama1 = "Alice J";
        System.Console.WriteLine(nama1);
        sayHello(nama1);

        void sayHelloInternal(string message)
        {
            System.Console.WriteLine("print message: " + message);
        }

        sayHelloInternal("Hello, this is new Message");

        void updateNumber(ref int number)
        {
            number += 10;
        }

        int angka2 = 10;
        updateNumber(ref angka2);
        System.Console.WriteLine(angka2); // berubah menjadi 20 karena sudah ditambahkan otomatis oleh updateNumbe

        int calculateNumber(int n1, int n2)
        {
            return n1 + n2;
        }

        int n1 = 12,
            n2 = 33;
        System.Console.WriteLine(calculateNumber(n1, n2));

        // access property
        System.Console.WriteLine(globalNumber);

        // variable  and property
        int number = 55;
        System.Console.WriteLine(number);
        System.Console.WriteLine(Program.number);

        // System.Console.WriteLine("What is your name: " );
        // string name = Console.ReadLine();
        // System.Console.WriteLine("Hello, " + name);
    }

    public static void sayHello(string name)
    {
        string message = "Hello";
        System.Console.WriteLine(message + " " + name);
    }
}
