using System;
using System.Collections.Generic;
using System.Globalization;
using Lecture.Entities;
using Lecture.Entities.Enums;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Dividing by zero is not allowed");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format of input");
            }
            finally
            {
                Console.WriteLine("Programa fechado");
            }

            //List<Shape> list = new List<Shape>();
            //Console.Write("Enter the number of shapes: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Shape #{i} data: ");
            //    Console.Write("Rectangle or Circle (r/c)? : ");
            //    char ch = char.Parse(Console.ReadLine());

            //    Console.Write("Color (Black/Blue/Red): ");
            //    Color color = Enum.Parse<Color>(Console.ReadLine());

            //    if (ch == 'r')
            //    {
            //        Console.Write("Width: ");
            //        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //        Console.Write("Height: ");
            //        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //        list.Add(new Rectangle(width, height, color));
            //    }
            //    else
            //    {
            //        Console.Write("Radius: ");
            //        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //        list.Add(new Circle(radius, color));
            //    }


            //}

            //Console.WriteLine();
            //Console.WriteLine("SHAPE AREAS: ");
            //foreach (Shape shape in list)
            //{
            //    Console.WriteLine(shape.Area());
            //}
        }
    }
}
