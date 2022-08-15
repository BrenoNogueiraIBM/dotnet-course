using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace LessonGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintService ps = new PrintService();
            //GenericPrinter<int> gp = new GenericPrinter<int>();

            //Console.WriteLine("How many values? :");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    ps.AddValue(x);
            //}

            //ps.Print();
            //Console.WriteLine("First: " + ps.First());

            //===================================================

            //List<Product> list = new List<Product>();

            //Console.Write("Enter the number of products: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    string[] vect = Console.ReadLine().Split(',');
            //    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
            //    list.Add(new Product(vect[0], price));
            //}

            //CalculationService calculationService = new CalculationService();

            //Product p = calculationService.Max(list); // <Product> is optional

            //Console.WriteLine("Most expensive:");
            //Console.WriteLine(p);

            //========================================================================
            //string a = "maria";
            //string b = "alex";

            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.Equals(a));

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            //========================================================================

            //Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            //Client b = new Client() { Name = "Alex", Email = "alex@gmail.com" };

            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.Equals(a));

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            //========================================================================
            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set.Contains("Notebook"));

            //foreach (string i in set)
            //    Console.WriteLine(i);

            //SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            //SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //// Union
            //SortedSet<int> c = new SortedSet<int>(a);
            //c.UnionWith(b);
            //PrintCollection(c);

            //// Intersection
            //SortedSet<int> d = new SortedSet<int>(a);
            //d.IntersectWith(b);
            //PrintCollection(d);

            //// Intersection
            //SortedSet<int> e = new SortedSet<int>(a);
            //e.ExceptWith(b);
            //PrintCollection(e);

            //HashSet<string> compare = new HashSet<string>();

            //compare.Add("Maria");
            //compare.Add("Alex");

            //Console.WriteLine(compare.Contains("Maria"));
            //========================================================================

            //HashSet<Product> a = new HashSet<Product>();
            //a.Add(new Product("TV", 9000.0));
            //a.Add(new Product("Notebook", 1200.0));

            //HashSet<Point> b = new HashSet<Point>();
            //b.Add(new Point(3, 4));
            //b.Add(new Point(5, 10));

            //Product prod = new Product("Notebook", 1200.0);
            //Console.WriteLine(a.Contains(prod));

            //Point point = new Point(3, 4);
            //Console.WriteLine(b.Contains(point));

            //========================================================================

            //Dictionary<string, string> cookies = new Dictionary<string, string>();

            //cookies["User"] = "Maria";
            //cookies["Email"] = "Maria@gmail.com";
            //cookies["Phone"] = "99974837284";
            //cookies["Phone"] = "89284918492";

            //Console.WriteLine(cookies["Phone"]);

            //if (cookies.ContainsKey("Id"))
            //    Console.WriteLine(cookies["Id"]);
            //else
            //    Console.WriteLine("No Id in the Dictionary");

            //Console.WriteLine(cookies.Count);

            //foreach(KeyValuePair<string,string> item in cookies)
            //    Console.WriteLine(item.Key + ":" + item.Value);

            //========================================================================

            DateTime dt = new DateTime(2022, 4, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s = "Good Morning dear students!";
            Console.WriteLine(s.Cut(10));

        }

        static void PrintCollection <T> (IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
