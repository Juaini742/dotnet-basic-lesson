class Program
{
       public static void Main(string[] args)
       {
              int[] number = new int[5];
              number[0] = 10;
              number[1] = 20;
              number[2] = 30;
              number[3] = 40;
              number[4] = 50;
              System.Console.WriteLine(number.Length);
              System.Console.WriteLine(number[0]);
              System.Console.WriteLine(number[1]);
              System.Console.WriteLine(number[2]);
              System.Console.WriteLine(number[3]);
              System.Console.WriteLine(number[4]);
              // number[5] = 60; // -> error karena out of the range

              int[] number2 = {1,2,3,4,5,6};
              System.Console.WriteLine(number2.Length);

              for(int i = 0; i < number2.Length; i++){
                     System.Console.WriteLine($"Index: {i}, Value: {number2[i]}");
              }
              
              string[] names = {"John", "Alice", "Bob"};
              for (int i = 0; i < names.Length; i++) {
                     System.Console.WriteLine("FOR: " + names[i]);
              }

              foreach (var item in names)
              {
                     System.Console.WriteLine("FOREACH: " + item);
              }

              // multi dimentions
              int[,] matrix = new int[2,3] { {1,2,3}, {4,5,6} };
              System.Console.WriteLine(matrix[0,0]);
              System.Console.WriteLine(matrix[0,1]);
              System.Console.WriteLine(matrix[0,2]);
              System.Console.WriteLine(matrix[1,0]);
              System.Console.WriteLine(matrix[1,1]);
              System.Console.WriteLine(matrix[1,2]);
              System.Console.WriteLine("=================");

              for(int i = 0; i < matrix.GetLength(0); i++) {
                     for(int j = 0; j < matrix.GetLength(1); j++) {
                            System.Console.WriteLine(matrix[i,j]);
                     }
              }

              System.Console.WriteLine("=======SORT==========");

              //  array sort
              int[] numbers3 = {10, 3,33,23,5,2};
              Array.Sort(numbers3);
              foreach(var item in numbers3) {
                     System.Console.WriteLine(item);
              }      

              // find index
              System.Console.WriteLine("=======FIND INDEX==========");
              int[] numbers4 = {10, 3,33,23,5,2};
              int searchValue = 33;
              int index = Array.IndexOf(numbers4, searchValue);
              if(index != -1) {
                     System.Console.WriteLine($"Value {searchValue} found at index {index}.");
              } else {
                     System.Console.WriteLine($"Value {searchValue} not found.");
              }
       }
}