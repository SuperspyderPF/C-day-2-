///1. 
public class Employee

    {

      public Employee(int id, string name)

      {

        EmpId = id;

        EmpName = name;

      }



      private int _EmpId;



      public int EmpId

      {

        get { return _EmpId; }

        set { _EmpId = value; }

      }



      private string _EmpName;



      public string EmpName

      {

        get { return _EmpName; }

        set { _EmpName = value; }

      }

   }

///2. 

using System;

namespace Employee
{
	// Create a class
	class Employee
	{
		// Data Members
		int employeeNumber;
		string name;
		string dateOfHire;
		string jobDescription;
		string department;
		double monthlySalary;

		// Default constructor
		public Employee()
		{
			this.employeeNumber = 0;
			this.name = "";
			this.dateOfHire = "";
			this.jobDescription = "";
			this.department = "";
			this.monthlySalary = 0.00;
		}

		// Parameter constructor
		public Employee(int employeeNumber, string name, string dateOfHire, string JobDescription, string department, double monthlySalary)
		{
			this.employeeNumber = employeeNumber;
			this.name = name;
			this.dateOfHire = dateOfHire;
			this.jobDescription = JobDescription;
			this.department = department;
			this.monthlySalary = monthlySalary;
		}


		// Properties for the data members
		public int EmployeeNumber
		{
			get
			{
				return employeeNumber;
			}
			set
			{
				employeeNumber = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public string DateOfHire
		{
			get
			{
				return dateOfHire;
			}
			set
			{
				dateOfHire = value;
			}
		}


		public string Department
		{
			get
			{
				return department;
			}
			set
			{
				department = value;
			}
		}
		public string JobDescription
		{
			get
			{
				return jobDescription;
			}
			set
			{
				jobDescription = value;
			}
		}

		public double MonthlySalary
		{
			get
			{
				return monthlySalary;
			}
			set
			{
				monthlySalary = value;
			}
		}

		// Override the ToString ( ) method to return all data members
		public override string ToString()
		{
			return "\nEmployee Name: " + name +
					"\tEmployee ID: " + employeeNumber +
				   "\tEmployee Hire Date: " + DateOfHire +
				   "\tEmployee JobDescription: " + JobDescription +
				   "\tEmployee Department: " + department +
				   "\tEmployee Monthly Salary: $" + monthlySalary;
		}
	}

	// Create a second class to test your Employee class.
	class TestEmployee
	{
		// Main Method 
		static public void Main(String[] args)
		{

			Employee[] empList = new Employee[3];

			// Employee 1
			empList[0] = new Employee();
			empList[0].EmployeeNumber = 102;
			empList[0].Name = "Michal";
			empList[0].DateOfHire = "30/05/2010";
			empList[0].JobDescription = "Sr. Software Developer";
			empList[0].Department = "Java";
			empList[0].MonthlySalary = 35000.00;

			// Employee 2
			empList[1] = new Employee();
			empList[1].EmployeeNumber = 103;
			empList[1].Name = "Alex";
			empList[1].DateOfHire = "15/06/2015";
			empList[1].JobDescription = "Software Developer";
			empList[1].Department = "Java";
			empList[1].MonthlySalary = 25000.00;

			// Employee 3
			empList[2] = new Employee();
			empList[2].EmployeeNumber = 101;
			empList[2].Name = "Nike";
			empList[2].DateOfHire = "22/08/2009";
			empList[2].JobDescription = "Manager";
			empList[2].Department = "Oracle";
			empList[2].MonthlySalary = 70000.00;


			// This code is used to diplay the employee data in alphabetical order
			char alphabet = 'a';
			while (alphabet <= 'z')
			{
				foreach (Employee eachEmployee in empList)
				{
					if (alphabet == eachEmployee.Name.ToLower()[0])
					{
						Console.WriteLine(eachEmployee.ToString());
					}
				}

				alphabet++;
			}

			Console.ReadKey();
		}
	}
}

///3. using System;

public class Example
{
   public static void Main()
   {
      TimeZoneInfo localZone = TimeZoneInfo.Local;
      Console.WriteLine("Local Time Zone ID: {0}", localZone.Id);
      Console.WriteLine("   Display Name is: {0}.", localZone.DisplayName);
      Console.WriteLine("   Standard name is: {0}.", localZone.StandardName);
      Console.WriteLine("   Daylight saving name is: {0}.", localZone.DaylightName); 
   }
}
///4.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ferrari = new Car("Ferrari");
            Ferrari.EngineV1();
            Ferrari.Tyre();
            Ferrari.SoundSystem();
            Ferrari.Colour("SkyBlue");
 
            Console.WriteLine("\n\n*********************\n");
            Car BMW = new Car("BMW");
            BMW.EngineV2();
            BMW.Tyre();
            BMW.SoundSystem();
            BMW.Colour("Red");
            
            Console.WriteLine("\n\n*********************\n");
            Car Ford = new Car("Ford");
            Ford.EngineV3();
            Ford.Tyre();
            Ford.SoundSystem();
            Ford.Colour("Coffee");
            
            Console.ReadKey();
        }
    }
 
    class Car : CarBase, CarColour
    {
        public Car(String CarName) : base(CarName)
        {            
        }
        public void Colour(String color)
        {
            Console.WriteLine("Car Colour is : " + color);
        }
    }
 
    class CarBase
    {
        public CarBase(String CarName)
        {
            Console.WriteLine("This is " + CarName);
        }
 
        public void EngineV1()
        {
            Console.WriteLine("Engine Type is V.1 4500CC Engine");
        }
 
        public void EngineV2()
        {
            Console.WriteLine("Engine Type is V.2 5500CC Engine");
        }
        
        public void EngineV3()
        {
            Console.WriteLine("Engine Type is V.2 6500CC Engine");
        }
 
        public void Tyre()
        {
            Console.WriteLine("Tyre Type is MRF TubeLess Tyre");
        }
        public void SoundSystem()
        {
            Console.WriteLine("Sound System Type is Sony Dolby Digital Extra Bass System");
        }
    }
    interface CarColour
    {
        void Colour(String color);
    }
}
///5.
using System;  
public class Exercise31  
{  
    public static void Main()
{
   int i,j,r;
   
	Console.Write("\n\n");
    Console.Write("Display the pattern like diamond:\n");
    Console.Write("-----------------------------------");
    Console.Write("\n\n");     
   
   Console.Write("Input number of rows (half of the diamond) :");
   r = Convert.ToInt32(Console.ReadLine());   
   for(i=0;i<=r;i++)
   {
     for(j=1;j<=r-i;j++)
     Console.Write(" ");
     for(j=1;j<=2*i-1;j++)
     Console.Write("*");
     Console.Write("\n");
   }
 
   for(i=r-1;i>=1;i--)
   {
     for(j=1;j<=r-i;j++)
     Console.Write(" ");
     for(j=1;j<=2*i-1;j++)
       Console.Write("*");
     Console.Write("\n");
   }
  }
}
///6.
using System;  
public class Exercise9  
{  
    public static void Main() 
{
    string str;
    int i, len, vowel, cons;
	
      Console.Write("\n\nCount total number of vowel or consonant :\n");
      Console.Write("----------------------------------------------\n"); 	
      Console.Write("Input the string : ");
      str = Console.ReadLine();		

    vowel = 0;
    cons = 0;
    len = str.Length;

    for(i=0; i<len; i++)
    {

        if(str[i] =='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u' || str[i]=='A' || str[i]=='E' || str[i]=='I' || str[i]=='O' || str[i]=='U')
        {
            vowel++;
        }
        else if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
        {
            cons++;
        }
    }
   Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
   Console.Write("The total number of consonant in the string is : {0}\n\n", cons);
	}
}
///7. 
using System;  
public class Exercise5
{  
    public static void Main() 
{
    string str;
    int i, wrd,l;
	
      Console.Write("\n\nCount the total number of words in a string :\n");
      Console.Write("------------------------------------------------------\n"); 	
      Console.Write("Input the string : ");
      str = Console.ReadLine();
	
    l = 0;
    wrd = 1;

    
    while (l <= str.Length - 1)
    {
        
        if(str[l]==' ' || str[l]=='\n' || str[l]=='\t')
        {
            wrd++;
        }

        l++;
    }

   Console.Write("Total number of words in the string is : {0}\n", wrd);
	}
}
///8.
using System;
public class funcexer10
{     
public static int SumCal( int n ) 
    { 
       string n1 = Convert.ToString(n);
       int sum = 0;  
       for (int i = 0; i < n1.Length; i++)
         sum += Convert.ToInt32(n1.Substring(i,1));
         return sum;
    }
 
public static void Main() 
    {
	  int num;
	  Console.Write("\n\nFunction : To calculate the sum of the individual digits of a number :\n");
      Console.Write("--------------------------------------------------------------------------\n");   
      Console.Write("Enter a number: ");
      num = Convert.ToInt32( Console.ReadLine() );
      Console.WriteLine("The sum of the digits of the number {0} is : {1} \n",num,SumCal(num));    
    }
}
///9.
class Program {  
    static void Main(string[] args) {  
        int num, rem, sum = 0, temp;  
           
        Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");  
        Console.Write("\n Enter a number: ");  
        num = Convert.ToInt32(Console.ReadLine());  
        temp = num;  
        while (num > 0) {  
            rem = num % 10;     
            num = num / 10;     
            sum = sum * 10 + rem;  
              
        }  
        Console.WriteLine("\n The Reversed Number is: {0} \n", sum);  
        if (temp == sum)   
        {  
            Console.WriteLine("\n Number is Palindrome \n\n");  
        } else {  
            Console.WriteLine("\n Number is not a palindrome \n\n");  
        }  
        Console.ReadLine();  
    }  
}  


///10.
using System;
  
class GFG{
  

public static void Main(string[] args)
{
      
    
    int num = 15;
      
    decimaltobinary(num);
}
  

public static int decimaltobinary(int val)
{
    int binary;
      
    if (val != 0)
    {
        binary = (val % 2) + 10 * decimaltobinary(val / 2);
        Console.Write(binary);
        return 0;
    }
    else
    {
        return 0;
    }
}
}