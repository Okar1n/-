using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ras4etzp
{
    /// <summary>
    /// В программе доступны три класса, созданные для описанных в условии задачи групп, с заданными атрибутами.
    /// Классы созданы на базе родительского класса worker
    /// Программу можно улучшить, добавив ввод конкретного сотрудника из базы данных (чему я еще учусь)
    /// а также графический интерфейс,после чего программа примет рабочий вид
    /// </summary>
    class Worker//базовый класс
    {
        

        public string Name { get; set; }
        public int DateStart { get; set; }
        
        public Worker (string name, int dateStart)//конструктор
        {
            Name = name;
            DateStart = dateStart;
        }
        

       
    }
    class Manager : Worker
    {
        public double wage { get; set; }
        public Manager(int wage, string name, int dateStart) : base(name,dateStart)
        {
            this.wage = wage;

        }
        public void Salary()
        {
            wage = wage + (0.05 * wage) * (2018 - DateStart);
            if (wage < 42000)//проверка, не больше 40% суммарной надбавки
               
            {
                Console.WriteLine(wage);
            }else { Console.WriteLine(42000);
            }
        }
        
    }
    class Employee : Worker
    {
        public double wage { get; set; }
        public Employee(int wage, string name, int dateStart) : base(name, dateStart)
        {
            this.wage = wage;

        }
        public void Salary()
        {
            wage = wage + (0.03 * wage) * (2018 - DateStart);
            if (wage < 26000)//проверка, не больше 30% суммарной надбавки
            {
                Console.WriteLine(wage);
            }
            else
            {
                Console.WriteLine(26000);
            }
        }

    }
    class Salesman : Worker
    {
        public double wage { get; set; }
        public Salesman(int wage, string name, int dateStart) : base(name, dateStart)
        {
            this.wage = wage;

        }
        public void Salary()
        {
            wage = wage + (0.01 * wage) * (2018 - DateStart);
            if (wage < 67500)//проверка, не больше 35% суммарной надбавки
            {
                Console.WriteLine(wage);
            }
            else
            {
                Console.WriteLine(67500);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Manager Ivanov = new Manager(30000, "Aleksandr Ivanov", 2014);
            Ivanov.Salary();
            Employee Fedorov = new Employee(20000, "Petr Fedorov", 2015);
            Fedorov.Salary();
            Salesman Dzyuba = new Salesman(50000, "Artyom Dzyuba", 2017);
            Dzyuba.Salary();

            Console.ReadKey();
        }
    }
}
