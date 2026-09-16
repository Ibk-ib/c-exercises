using System;

public class Car
{
	public string Name { get; set; }
	public string Model { get; set; }
	public int Year { get; set; }
	public string Color { get; set; }


    public void DisplayCarInfo()
    {
        Console.WriteLine("Car Name: {0}", Name);
        Console.WriteLine("Car Model: {0}", Model);
        Console.WriteLine("Car Year: {0}", Year);
        Console.WriteLine("Car Color: {0}", Color);
    }
}

public class Student { 
    
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public int Level { get; set; }


    public void DisplayStudentInfo() { 
        
        Console.WriteLine("Student Name: {0}", Name);
        Console.WriteLine("Student Age: {0}", Age);
        Console.WriteLine("Student Department: {0}", Department);
        Console.WriteLine("Student Level: {0}", Level);
    }

}

public class Calculator { 
 
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }

}

public class BankAccount {

    public string AccountNumber { get; set; }
    public string AccountName { get; set; }
    public double Balance { get; set; }


    public void Deposit(double amount) { 
    
        Balance += amount;
        Console.WriteLine("{0} deposited successfully", amount);
    }

    public void Withdraw(double amount) {

        if (amount > Balance) {
            Console.WriteLine("Insufficient balance");
        } else { 
            Balance -= amount;
            Console.WriteLine("{0} withdrawn successfully", amount);
        }
    }

    public void DisplayAccountInfo()
    {

        Console.WriteLine("Account Number: {0}", AccountNumber);
        Console.WriteLine("Account Name: {0}", AccountName);
        Console.WriteLine("Account Balance: {0}", Balance);
    }
}