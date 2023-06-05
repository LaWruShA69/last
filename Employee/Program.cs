using Employee;

namespace Employee;
internal class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("введите номер задания: ");
        EmployeeSecond employeeBock = new EmployeeSecond();
        int choice = Int32.Parse(Console.ReadLine());
        switch (choice)
        {  
            case 1:
                employeeBock.PersInf();
                break;
            case 2:
                employeeBock.SalarySum();
                break;
            case 3:
                employeeBock.SalaryMax();
                break;
            case 4:
                employeeBock.SalaryMin();
                break;
            case 5:
                employeeBock.SalaryMid();
                break;
            case 6:
               employeeBock.FIO();
                break;
            case 7:
                employeeBock.SalaryIndex();
                break;
            case 8:
                employeeBock.SalaryMinDep();
                break;
            case 9:
                employeeBock.SalaryMaxDep();
                break;
            case 10:
                employeeBock.SalaryMidDep();
                break;
            case 11:
                employeeBock.SalaryIndexDep();
                break;
            case 12:
                employeeBock.DepInf();
                break;
            case 13:
                employeeBock.SalaryDepNumberMin();
                break;
            case 14:
                employeeBock.SalaryDepNumberMax();
                break; 
            case 15:
                employeeBock.EmployeeNew();
                break;    
            case 16:
                employeeBock.EmployeeDelete();
                break;
            case 17: 
                employeeBock.ChangeAll();
                break;
            case 18:
                employeeBock.EmployeesInDepLAST();
                break;
        }
    }
}