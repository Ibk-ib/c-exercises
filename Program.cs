//Console.WriteLine("Hello, World!");

//int? num1;
//int? num2;
//char[] operators = { '+', '-', '*', '/'};
//Console.WriteLine("This is a basic calculator.");
//Console.WriteLine("Enter the first number: ");
//num1 = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Enter the second number: ");
//num2 = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Enter your operator: ");
//char oper = Convert.ToChar(Console.ReadLine());

//if (oper == '+') {
//    Console.WriteLine(num1 + num2);
//} else if (oper == '-')
//{
//    Console.WriteLine(num1 - num2);
//}
//else if (oper == '*')
//{
//    Console.WriteLine(num1 * num2);
//}
//else if (oper == '/')
//{
//    Console.WriteLine(num1 / num2);
//}
//else
//{
//    Console.WriteLine("Invalid operator");
//}



//int? num1;
//Console.WriteLine("Enter a whole number: ");
//num1 = Convert.ToInt16(Console.ReadLine());
//if (num1 % 2 == 0)
//{
//    Console.WriteLine("The number is even.");

//}
//else
//{
//    Console.WriteLine("The number is odd.");
//}



//int? num1;
//Console.WriteLine("Input your score to check your grade: ");
//num1 = Convert.ToInt16(Console.ReadLine());
//if (num1 <= 100 && num1 >= 90)
//{
//    Console.WriteLine("Your grade is A");
//}
//else if (num1 <= 89 && num1 >= 80)
//{
//    Console.WriteLine("Your grade is B");

//}
//else if (num1 <= 79 && num1 >= 70)
//{
//    Console.WriteLine("Your grade is C");
//}
//else if (num1 <= 69 && num1 >= 60)
//{
//    Console.WriteLine("Your grade is D");
//}
//else if (num1 < 60)
//{
//    Console.WriteLine("Your grade is F");
//} else
//{
//    Console.WriteLine("Invalid score, your score should be between 0 and 100");
//}



//int? num1;
//Console.WriteLine("Enter a positive number");
//num1 = Convert.ToInt16(Console.ReadLine());


//if (num1 % 5 == 0 && num1 % 3 == 0)
//{
//    Console.WriteLine("FizzBuzz");
//}
//else if (num1 % 5 == 0)
//{
//    Console.WriteLine("Buzz");
//}
//else if (num1 % 3 == 0)
//{
//    Console.WriteLine("Fizz");
//} else
//{
//    Console.WriteLine(num1);
//}



//Water Reservoir level tracker

//int litres = 120;
//int days = 0;

//while (litres < 500 && litres >= 50)
//{

//    days++;

//    litres += 85;

//    if (days % 2 == 0)
//    {
//        litres -= 65;
//    }
//    else
//    {
//        litres -= 40;
//    }

//}
//Console.WriteLine("The final volume is {0} on the {1}th day", litres, days);



//Process Inventory Orders 

//int stock = 300;
//int[] orders = { 50, 120, 80, 100, 40 };
//int fulfilledOrders = 0;

//foreach (int order in orders)
//{
//    if (order <= stock)
//    {
//        stock -= order;
//        fulfilledOrders++;
//    }
//    else
//    {
//        Console.WriteLine("Backordered");
//    }
//}
//Console.WriteLine("Total Fulfilled Orders: {0}, Remaining Stock: {1}", fulfilledOrders, stock);



//Loan Payoff calculator

//double loan = 1000;
//double interestRate = 0.02;
//double payment = 200;
//int months = 0;

//while (loan > 0) {
//    loan += loan * interestRate;

//    if (loan > payment)
//    {
//        loan -= payment;
//    } else
//    {
//        loan = 0;
//    }
//    months++;
//}
//Console.WriteLine("The total months used to clear the loan is {0} months", months);


//Temperature Sensor Threshold Audit

//double[] temperatures = { 3.2, 4.0, 8.5, 7.1, 1.8, 6.4, 9.0 };
//double safeRange1 = 2.0;
//double safeRange2 = 8.0;
//int fallOutReadings = 0;

//foreach (double temperature in temperatures)
//{
//    if (temperature < safeRange1 || temperature > safeRange2)
//    {
//        fallOutReadings++;
//    }
//}
//Console.WriteLine("The number of fallout readings is {0}", fallOutReadings);


//Solar Battery Charge 

//int charge = 35;
//int day = 0;

//while (charge < 100)
//{
//    day++;

//    charge += 14;
//    charge -= 9;

//    if (charge >= 100)
//    {
//        charge = 100;
//        break;
//    }
//}
//Console.WriteLine("Day {0}", day);


//Student Grade Calculator  

//int[] scores = { 78, 45, 92, 63, 88, 54, 39, 71 };
//int distinction = 0;
//int pass = 0;
//int fail = 0;

//foreach (int score in scores)
//{
//    if (score >= 75)
//    {
//        distinction++;
//    }
//    else if (score >= 50 && score <= 74)
//    {
//        pass++;
//    }
//    else
//    {
//        fail++;
//    }
//}
//Console.WriteLine("We have {0} students with distinction, {1} students passed and {2} students failed", distinction, pass, fail);




//Vehicle decelaration


//double speed = 180;
//double interval = 0;

//while ( speed > 0)
//{
//    speed -= speed * 0.2;
//    interval++;

//    if ( interval >=3)
//    {
//        speed -= 15;

//    }
//}
//Console.WriteLine("Total Intervals is {0}", interval);


//Bank account overdraft


//double balance = 500;
//double overdraft = 0;
//double[] transactions = { -200, -400, 300, -350, 100 };

//foreach( double transaction in transactions) {

//    balance += transaction;

//    if (balance < 0) {

//        overdraft++;

//    }
//}
//Console.WriteLine("Overdraft occurred {0} times", overdraft);



//Submersible Staged Descent



int depth = 0;
int  stages = 0;
while (depth < 2000)
{
    if (depth >= 800 && depth < 1600)
    {
        depth += 40;
    } else
    {
        depth += 100;
    }

    stages++;
}
 Console.WriteLine("The total stages used to reach the target depth is {0}", stages);






//Server Recovery Simulation

//int servers = 40;
//int hours = 0;

//while(hours < 10)
//{
//    servers -= 3;
//    hours++;

//    if (hours >= 5)
//    {
//        servers += 3;
//    } else
//    {
//        servers += 1;
//    }
//}
//Console.WriteLine("Servers remaining after {0} hours is {1}", hours, servers);