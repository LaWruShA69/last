using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmployeeSecond 
    {
        private List<Employee> employees = new()
        {
            new Employee("Larin Danila", 1, 99999),
            new Employee("Ruby Carter", 2, 46961),
            new Employee("Terri Cole", 3, 17791),
            new Employee("Walter Rowe", 4, 35123),
            new Employee("Vicki Bradley", 5, 15566),
            new Employee("Linda Robertson", 1, 8671),
            new Employee("Kathleen Robinson", 2, 39390),
            new Employee("Sharon Andrews", 3, 38497),
            new Employee("Carol Garner", 4, 47247),
            new Employee("Jessie Nichols", 5, 25466),
            new Employee("Allison Snyder", 1, 30376),
            new Employee("Megan Graves", 2, 19509),
            new Employee("Marcus Ramos", 3, 33611),
            new Employee("Bradley Goodwin", 4, 19247),
            new Employee("Mike Park", 5, 7646)
        };
        public void PersInf()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"работник номер {emp._id} - {emp.Fio}, который работает в отделе " +
                    $"{emp.Department} зарабатывая " +
                    $" {emp.Salary}₽");
            }
        }
        public void SalarySum()
        {
            double sum = 0;
            foreach (Employee emp in employees)
            {
                sum += emp.Salary;
            }
            Console.WriteLine($"сумма зарплат: {sum}₽");

        }
        public void SalaryMax()
        {
            Console.WriteLine($"работник с самой большой зарплатой (я) {employees.Max(e => e.Salary + "₽: " + e.Fio)}");
        }
        public void SalaryMin() 
        {
            Console.WriteLine($"работник с самой маленькой зарплатой (бомже) {employees.Min(e => e.Salary + "₽: " + e.Fio)}");
        }
        public void SalaryMid() 
        {
            Console.WriteLine($"средняя зарплата: {employees.Average(e => e.Salary)}₽");
        }
        public void FIO()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"фио работника: {emp._id} {emp.Fio}");
            }

        }
        public void SalaryIndex()
        {
            Console.WriteLine("введите процент увеличения зарплаты: ");
            double percent = double.Parse(Console.ReadLine());

            double salary;
            foreach (var emp in employees)
            {
                salary = emp.Salary + (emp.Salary / percent);

                Console.WriteLine($"теперь зарплата {emp.Fio} : {salary}₽");
            }

        }
        public void SalaryMinDep()
        {
            Console.WriteLine("введите номер отдела, минимальную зарплату в котором хотите увидеть: ");
            double dep_choice = Double.Parse(Console.ReadLine());

            var emp_in_dep = employees.Where(e => e.Department == dep_choice);
            if (emp_in_dep.Any())
            {
                var minsalary = emp_in_dep.OrderBy(e => e.Salary).First();
                Console.WriteLine($"в отделе номер: {dep_choice} минимальная зарплата равна: {minsalary.Salary}₽ у работника: {minsalary.Fio}");
            }

        }

        public void SalaryMaxDep()
        {
            Console.WriteLine("введите номер отдела, максимальную зарплату в котором хотите увидеть: ");
            double dep_choice = Double.Parse(Console.ReadLine());

            var emp_in_dep = employees.Where(e => e.Department == dep_choice);
            if (emp_in_dep.Any())
            {
                var maxsalary = emp_in_dep.OrderBy(e => e.Salary).Last();

                Console.WriteLine($"в отделе номер: {dep_choice} максимальная зарплата равна: {maxsalary.Salary}₽ у работника: {maxsalary.Fio}");
            }
        }
        public void SalaryMidDep()
        {
            Console.WriteLine("введите номер отдела, среднюю зарплату которого хотите увидеть: ");
            double dep_choice = Double.Parse(Console.ReadLine());

            var emp_in_dep = employees.Where(e => e.Department == dep_choice);
            if (emp_in_dep.Any())
            {
                var averagesalary = emp_in_dep.Average(e => e.Salary);

                Console.WriteLine($"в отделе номер: {dep_choice} средняя зарплата равна: {averagesalary}₽");
            }
        }
        public void SalaryIndexDep()
        {
            Console.WriteLine("введите номер отдела, зарплату которого хотите изменить: ");
            int dep_choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите процент увеличения зарплаты: ");
            int index = Int32.Parse(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Department == dep_choice)
                {
                    emp.Salary += (emp.Salary / index);
                    Console.WriteLine($"Новая зарплата сотрудника: {emp.Fio} : {emp.Salary}₽");
                }
            }
        }
        public void DepInf()
        {
            Console.WriteLine("введите номер отдела, сотрудников которого хотите увидеть: ");
            int dep_choice = Int32.Parse(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Department == dep_choice)
                {
                    Console.WriteLine($"работник номер: {emp._id} : {emp.Fio} получает зарплату в размере: {emp.Salary}₽");
                }
            }
        }
        public void SalaryDepNumberMin()
        {
            Console.WriteLine("введите зарплату, ниже которой выведут работников:");
            double expected_salary = double.Parse(Console.ReadLine());

            foreach (var emp in employees)
            {
                if (emp.Salary < expected_salary)
                    Console.WriteLine($"работник номер: {emp._id} - {emp.Fio}, работающий в отделе: " +
                        $"{emp.Department} получает зарплату в размере: " +
                        $" {emp.Salary}₽");
            }
        }
        public void SalaryDepNumberMax() //14 - Все сотрудники с зарплатой больше числа
        {
            Console.WriteLine("введите зарплату, выше которой выведут работников:");
            double expected_salary = double.Parse(Console.ReadLine());

            foreach (var emp in employees)
            {
                if (emp.Salary >= expected_salary)
                    Console.WriteLine($"работник номер: {emp._id} - {emp.Fio}, работающий в отделе: " +
                        $"{emp.Department} получает зарплату в размере: " +
                        $" {emp.Salary}₽");
            }
        }
        public void EmployeeNew()
        {
            Console.WriteLine("введите фио работника: ");
            string FIO = Convert.ToString(Console.ReadLine());
            Console.WriteLine("введите отдел работника: ");
            int DEP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите зарплату работника: ");
            double SAL = Convert.ToDouble(Console.ReadLine());

            employees.Add(new Employee(fio: FIO, department: DEP, salary: SAL));
            Console.WriteLine($"добавлен работник : {FIO} в отдел: {DEP} с зарплатой: {SAL}₽");
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Fio} {emp.Department} {emp.Salary}");
            }
        }
        public void EmployeeDelete()
        {
            Console.WriteLine("введите ID уволившегося работника: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            foreach (Employee emp in employees)
            {
                if (emp._id == ID)
                {
                    employees.Remove(emp);
                    break;
                }
            }

            if (employees.Count > 0)
            {
                Console.WriteLine("список работников после удаления: ");
                foreach (Employee emp in employees)
                {
                    Console.WriteLine($"{emp._id}. {emp.Fio}, {emp.Department}, {emp.Salary}₽");
                }
            }
            else
            {
                Console.WriteLine("пустой список работников ");
            }
        }
        public void ChangeAll()
        {
            Console.WriteLine("введите ID работника, которого хотите изменить: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите отдел, в котором будет работать этот работник: ");
            int newDep11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите зарплату, которую будет получать этот работник: ");
            double newSAl = Convert.ToDouble(Console.ReadLine());
            foreach (Employee emp in employees)
            {
                if (emp._id == ID)
                {
                    emp.Department = newDep11;
                    emp.Salary = newSAl;
                    break;
                }
            }
            Console.WriteLine("список работников после измененийц:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp._id}. {emp.Fio}, {emp.Department}, {emp.Salary}₽");
            }
        }
        public void EmployeesInDepLAST()
        {
            var employeesInDepartment = employees.OrderBy(e => e.Department);
            foreach(var emp in employeesInDepartment)
            {
                Console.WriteLine($"работник из отдела: {emp.Department} - {emp.Fio}");
            }
            
        }
    }
}
