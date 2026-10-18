using System;


namespace project._2
{
    public abstract class Employee : I_workable
    {
        private decimal _Salary;


    public int Id {  get; set; }
        string Name { get; set; }

        public decimal Salary
        {
            get => _Salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary hasn't can be negtive");
                    
            }
                _Salary = value;
            }
        }
        
        public Employee(int id, string name)
        {
            Id = id;
            Name= name;
            
        }
        public abstract decimal CalculateSalary();
       
       
        public void Displayinfo()
        {
            Console.WriteLine($"id :{Id} , name:{Name}");
        }
        public abstract void workable();

    }
        
    }
  


