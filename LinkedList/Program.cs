using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int option =0, value = 0;
            LinkedLists linkedList = new LinkedLists();
            while(option != 10){
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("Menu \n");
            System.Console.WriteLine("1. Append \n");
            System.Console.WriteLine("2. Preappend \n");
            System.Console.WriteLine("3. Delete \n");
            System.Console.WriteLine("4. Print \n");
            option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1: System.Console.WriteLine("Press a value");
                            value = int.Parse(Console.ReadLine());
                            linkedList.append(value);
                            break;
                    case 2: System.Console.WriteLine("Press a value");
                            value = int.Parse(Console.ReadLine());
                            linkedList.preappend(value);
                            break;
                    case 3: System.Console.WriteLine("Press a value");
                            value = int.Parse(Console.ReadLine());
                            linkedList.deleteWithValue(value);
                            break;
                    case 4: 
                            linkedList.print();
                            break;                                                                   
                    default:    System.Console.WriteLine("Incorrect Option");
                                break;
                }
            }
            
        }
    }
}
