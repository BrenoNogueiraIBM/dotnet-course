using System;
using System.Globalization;
using System.Collections.Generic;
using Curso.Entities;
using Curso.Entities.Enums;

namespace Curso
{
    class Breno
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }
            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
                Console.WriteLine($"Balance Updated for {acc.Number} is " + acc.Balance.ToString("F2"));
            }


            //=============================================================================================================

            //List<Employee> list = new List<Employee>();

            //Console.Write("Enter the number of employees");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Employee #{i} data");
            //    Console.Write("Outsourced? (y/n): ");
            //    char ch = char.Parse(Console.ReadLine());

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Hours: ");
            //    int hours = int.Parse(Console.ReadLine());

            //    Console.Write("Value per Hour: ");
            //    double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    if(ch == 'y')
            //    {
            //        Console.Write("Additional Charge: ");
            //        double addCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        list.Add(new OutsourcedEmployee(name, hours, valueHour, addCharge));
            //    }
            //    else
            //    {
            //        list.Add(new Employee(name, hours, valueHour));
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("PAYMENTS: ");
            //foreach(Employee emp in list)
            //{
            //    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            //}


            //=============================================================================================================


            //BusinessAccount bacc = new BusinessAccount(8010, "Bob Brown", 0.0, 500.0);

            //Account acc = new Account(1001, "Alex Green", 0.0);


            //// Upcasting
            //Account acc1 = bacc;

            //Account acc2 = new BusinessAccount(8010, "Maria Pink", 0.0, 500.0);
            //Account acc3 = new SavingsAccount(8010, "Maria Pink", 0.0, 500.0);


            //// Downcasting
            //BusinessAccount acc4 = (BusinessAccount) acc2;
            //acc4.Loan(100.0);

            //if (acc3 is BusinessAccount)
            //    Console.WriteLine("É business account");

            //if(acc3 is SavingsAccount)
            //    Console.WriteLine("É savings account");

            //Account acca = new Account(1001, "Alex", 500.0);
            //Account accb = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            //acca.Withdraw(10.0);
            //accb.Withdraw(10.0);

            //Console.WriteLine(acca.Balance);
            //Console.WriteLine(accb.Balance);

            //=============================================================================================================

            //Console.WriteLine("Enter Client Data: ");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Email: ");
            //string email = Console.ReadLine();

            //Console.Write("Birth Date (DD/MM/YYYY): ");
            //DateTime birth = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Order Data: ");
            //Console.Write("Status: ");
            //OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            //Client cl = new Client(name, email, birth);
            //Order order = new Order(DateTime.Now, status, cl);

            //Console.Write("How many items to this order? : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Enter #{i} item data: ");
            //    Console.Write("Product Name: ");
            //    string product = Console.ReadLine();

            //    Console.Write("Product Price: ");
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    Console.Write("Quantity: ");
            //    int quantity = int.Parse(Console.ReadLine());

            //    Product p = new Product(product, price);
            //    OrderItem oi = new OrderItem(quantity, price, p);
            //    order.AddItem(oi);
            //}

            //Console.WriteLine();
            //Console.WriteLine(order);


            //=============================================================================================================

            //Comment c1 = new Comment("Have a nice trip");
            //Comment c2 = new Comment("Wow that's awesome!");

            //Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Travelling to New Zealand", "I'm going to visit this wonderful country", 12);
            //p1.AddComment(c1);
            //p1.AddComment(c2);

            //Comment c3 = new Comment("Good Night");
            //Comment c4 = new Comment("May the force be with you");

            //Post p2 = new Post(DateTime.Parse("18/07/2018 23:14:41"), "Good Night Guys", "See you tomorrow", 12);
            //p2.AddComment(c3);
            //p2.AddComment(c4);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            //=============================================================================================================


            //Console.WriteLine("Enter department's name: ");
            //string dep = Console.ReadLine();

            //Console.WriteLine("Enter worker data: ");
            //Console.Write("Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Level (Junior/MidLevel/Senior): ");
            //WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            //Console.Write("Base Salary: ");
            //double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Department dept = new Department(dep);
            //Worker worker = new Worker(name, level, baseSalary, dept);

            //Console.Write("How many contracts for this worker? : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Enter #{i} contract data: ");
            //    Console.Write("Date (DD/MM/YYYY): ");
            //    DateTime date = DateTime.Parse(Console.ReadLine());

            //    Console.Write("Value per hour: ");
            //    double valuePerHour = double.Parse(Console.ReadLine());

            //    Console.Write("Duration (hours): ");
            //    int hours = int.Parse(Console.ReadLine());

            //    HourContract contract = new HourContract(date, valuePerHour, hours);
            //    worker.AddContract(contract);
            //}

            //Console.WriteLine();

            //Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            //string monthAndYear = Console.ReadLine();
            //int month = int.Parse(monthAndYear.Substring(0, 2));
            //int year = int.Parse(monthAndYear.Substring(3));

            //Console.WriteLine("Name: " + worker.Name);
            //Console.WriteLine("Department: " + worker.Department.Name);
            //Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));


            //=============================================================================================================


            //Order order = new Order
            //{
            //    Id = 1000,
            //    Moment = DateTime.Now,
            //    Status = OrderStatus.PendingPayment
            //};

            //Console.WriteLine(order);

            //string txt = OrderStatus.PendingPayment.ToString();
            //OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            //Console.WriteLine(os);
            //Console.WriteLine(txt);
        }
    }
}
