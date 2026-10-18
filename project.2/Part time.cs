using System;


namespace project._2
{
    public class Parttime : Employee
    {


        public int HoursWorked { get; set; }
    public decimal HourlyRate { get; set; }

    public Part time(int id, string name, int hoursWorked, decimal hourlyRate) : base(id, name)
        {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
        Salary = CalculateSalary();
    }

        public override decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
        public override void workable()
        {
            Console.WriteLine($"{Name} is working part time.");
        }
        public override void Displayinfo()
        {
            base.Displayinfo();
            Console.WriteLine("Employee Type: Part Time");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }
    }

