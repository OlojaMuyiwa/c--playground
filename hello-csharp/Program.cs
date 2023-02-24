using System;

namespace Program
{
  class Program
  {
    static void Main(string[] args)
    {
      /*  Console.Write("Enter a number: ");
        double num1 =  Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter another number: ");
        double num2 =  Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(num1 + num2);
        string color,noun,celeb;

        Console.Write("Enter a color: ");
        color = Console.ReadLine();

        Console.Write("Enter a noun: ");
        noun = Console.ReadLine();

        Console.Write("Enter a celebrity: ");
        celeb = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Roses are {color}");
        Console.WriteLine($"{noun} are blue");
        Console.WriteLine($"I love {celeb}");

        int [] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24};
        arr[arr.Length - 1] = 26;

        string [] friends = new String[10];
        friends[1] = "Kelly";

        Console.WriteLine(friends[1]);

        METHODS
        Console.WriteLine(cube(40));
        int cubedNumber = cube(4);
        Console.WriteLine(cubedNumber);

        bool isMale = true;
        bool isTall = true;

        if (isMale && isTall)
        {
          Console.WriteLine("He is a male and tall");
        }
        else if(isMale || isTall)
        {
          Console.WriteLine("He is a male");
        }
        else
        {
          Console.WriteLine("She is a female");
        }

        Console.WriteLine(Math.Max(60, 60));
         Console.WriteLine( GetMax(70, 60));
         Console.WriteLine( GetMin(70, 60));

        try
        {
          Console.Write("Enter a number: ");
          double num1 = Convert.ToDouble(Console.ReadLine());

          Console.Write("Enter an operator: ");
          char opr = Convert.ToChar(Console.ReadLine());


          Console.Write("Enter another number: ");
          double num2 = Convert.ToDouble(Console.ReadLine());

          if (opr == '+')
          {

            Console.WriteLine(num1 + num2);

          }
          else if (opr == '-')
          {
            Console.WriteLine(num1 - num2);
          }
          else if (opr == '/')
          {
            Console.WriteLine(num1 / num2);

          }
          else if (opr == '*')
          {
            Console.WriteLine(num1 * num2);
          }
          else if (opr == '%')
          {
            Console.WriteLine(num1 % num2);
          }
          else
          {
            throw new Exception("Unknown operator");
          }

        }
        catch(Exception e)
        {
          Console.WriteLine(e.Message);
        }
        finally
        {
          Console.WriteLine("Done");
        }

        while (i <= 10)
        {
          Console.WriteLine($"Still true at {i}");
          i++;
        }

        int i = 0;

        do
        {
          Console.WriteLine("From a do...while loop");
          i++;
        } while (i < 10);

        int[,] numberGrid = {
          { 1, 2, 3, 4},
          { 5, 6, 7, 8},
          { 9, 10, 11, 12},
         { 13, 14, 15, 16}
        };

        Console.WriteLine(numberGrid[0, 3]);

      */

      Book book1 = new Book("Harry Potter", "JK Rowling", 400);
      /*
      book1.title = "Harry Potter";
      book1.author = "JK Rowling";
      book1.pages = 400;
      */


      Book book2 = new Book("Lord of the rings", "Tolkein", 1400);
      /*
      book2.title = "Lord of the rings";
      book2.author = "Tolkein";
      book2.pages = 1400;
      */

      Console.WriteLine(book2.title);


    }

    static int GetMax(int num1, int num2)
    {
      int result;
      if (num1 > num2)
      {
        result = num1;
      }
      else if (num2 > num1)
      {
        result = num2;
      }
      else
      {
        result = num1;
      }
      return result;
    }


    static int GetMin(int num1, int num2)
    {
      int result;
      if (num1 > num2)
      {
        result = num2;
      }
      else if (num2 > num1)
      {
        result = num1;
      }
      else
      {
        result = num1;
      }
      return result;
    }

    static void SayHi(string name, int age)
    {
      Console.WriteLine($"Welcome {name} your age is {age}.");
    }

    static int cube(int num)
    {
      int result = num * num * num;
      return result;
    }
  }
}

