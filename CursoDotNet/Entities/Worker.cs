using Curso.Entities.Enums;
using System.Collections.Generic;

namespace Curso.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            this.Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            this.Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {

            double sum = BaseSalary;

            foreach(HourContract con in Contracts)
            {
                if(con.Date.Year == year && con.Date.Month == month)
                    sum += con.TotalValue();
            }

            return sum;
        }
    }
}
