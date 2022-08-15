using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace LessonAdvanced
{

    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperation2(double n1, double n2);

    public delegate bool Predicate<in T>(T obj);

    class Program
    {
        static void Main(string[] args)
        {
            //List<Product> list = new List<Product>();

            //list.Add(new Product("TV", 900.00));
            //list.Add(new Product("Notebook", 1200.00));
            //list.Add(new Product("Tablet", 450.00));

            //list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}

            //===============================================================================

            //double a = 10;
            //double b = 12;

            //// BinaryNumericOperation op = CalculationService.Sum;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);

            //// double result = op(a, b);
            //double result = op.Invoke(a, b);
            //Console.WriteLine(result);
            //Console.WriteLine();

            //a = 10;
            //b = 12;
            //BinaryNumericOperation2 shop = CalculationService.ShowSum;
            //shop += CalculationService.ShowMax;
            //shop(a, b);

            //===============================================================================

            //List<Product> list = new List<Product>();
            //list.Add(new Product("Tv", 900.00));
            //list.Add(new Product("Mouse", 50.00));
            //list.Add(new Product("Tablet", 350.50));
            //list.Add(new Product("HD Case", 80.90));



            ////list.ForEach(UpdatePrice);
            //list.ForEach(p => { p.Price += p.Price * 0.1; });
            //foreach (Product p in list)
            //    Console.WriteLine(p);
            //Console.WriteLine();

            //List<string> result = list.Select(NameUpper).ToList();
            //foreach (string p in result)
            //    Console.WriteLine(p);
            //Console.WriteLine();

            //list.RemoveAll(p => p.Price >= 100.0);
            //foreach (Product p in list)
            //    Console.WriteLine(p);
            //Console.WriteLine();

            //===============================================================================

            //int[] numbers = new int[] { 2, 3, 4, 5 };

            //IEnumerable<int> result = numbers
            //    .Where(x => x % 2 == 0)
            //    .Select(x => x * 10);

            //foreach(int x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //=====================================================================================================

            //Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
            //Category c2 = new Category { Id = 2, Name = "Computers", Tier = 1 };
            //Category c3 = new Category { Id = 3, Name = "Eletronics", Tier = 1 };

            //List<Product> products = new List<Product>() {
            //    new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
            //    new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
            //    new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
            //    new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
            //    new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
            //    new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
            //    new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
            //    new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
            //    new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
            //    new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
            //    new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            //};

            ////var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            //var r1 = from p in products
            //         where p.Category.Tier == 1 && p.Price < 900.0
            //         select p;
            //Print("TIER 1 AND PRICE < 900.0", r1);

            ////var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            //var r2 = from p in products
            //        where p.Category.Name == "Tools"
            //        select p.Name;
            //Print("PRODUCTS FROM TOOLS", r2);

            ////var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            //var r3 = from p in products
            //         where p.Name[0] == 'C'
            //         select new { p.Name, p.Price, CategoryName = p.Category.Name };
            //Print("NAMES STARTING WITH 'C' AND ANONYMOUS OBJECT", r3);

            ////var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            //var r4 = from p in products
            //         where p.Category.Tier == 1
            //         orderby p.Name
            //         orderby p.Price
            //         select p;
            //Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            ////var r5 = r4.Skip(2).Take(4);
            //var r5 = (from p in r4 select p).Skip(2).Take(4);
            //Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            //var r6 = products.First();
            //Console.WriteLine("FIRST \n"+ r6);

            //var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            //Console.WriteLine("FIRST OR DEFAULT \n" + r7);

            //var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            //Console.WriteLine("SINGLE OR DEFAULT \n" + r8);

            //var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            //Console.WriteLine("\nSINGLE OR DEFAULT EMPTY\n" + r9);

            //var r10 = products.Max(p => p.Price);
            //Console.WriteLine("\nMAX PRICE\n" + r10);

            //var r11 = products.Min(p => p.Price);
            //Console.WriteLine("\nMIN PRICE\n" + r11);

            //var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            //Console.WriteLine("\nSUM PRICE CATEGORY 1\n" + r12);

            //var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            //Console.WriteLine("\nAVERAGE PRICE CATEGORY 1\n" + r13);

            //var r14 = products.Where(p => p.Category.Id == 5).Select(p=> p.Price).DefaultIfEmpty(0.0).Average();
            //Console.WriteLine("\nAVERAGE PRICE CATEGORY 5 EMPTY SHIELDED\n" + r14);

            //var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            //Console.WriteLine("\nAGGREGATE SUM CATEGORY 1\n" + r15);
            //Console.WriteLine();

            ////var r16 = products.GroupBy(p => p.Category);
            //var r16 = from p in products
            //          group p by p.Category;
            //foreach (IGrouping<Category, Product> group in r16)
            //{
            //    Console.WriteLine("Category " + group.Key.Name + ": ");
            //    foreach (Product p in group)
            //    {
            //        Console.WriteLine(p);
            //    }
            //    Console.WriteLine();
            //}

            //=====================================================================================================

            string path = @"C:\Users\017585631\Desktop\codes\Curso\LessonAdvanced\in.txt";
            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string [] data = sr.ReadLine().Split(',');
                    string name = data[0];
                    double price = double.Parse(data[1], CultureInfo.InvariantCulture);
                    list.Add(new Product { Name = name, Price = price });
                }
            }

            var r1 = list.Average(p => p.Price);
            Console.WriteLine("Average: " + r1.ToString("F2"));

            var r2 = list.Where(p => p.Price < r1).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (var item in r2)
            {
                Console.WriteLine(item);
            }
        }

        public static void Print<T> (string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
