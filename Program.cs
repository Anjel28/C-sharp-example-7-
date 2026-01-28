using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography;
/*class Program
{
    static void Main()
    {

   char studentGrade = 'A';

   Console.WriteLine("Student Grade: " +studentGrade);
       /* bool isLightOn = true;

        Console.WriteLine("Light Status: " +isLightOn);*/


/*int temperature = 25 ;

Console.WriteLine("Temperature:  " +temperature +"degree celsius");*/
/*double bankBalance = 1500.75;

Console.WriteLine("Bank Balance: " +bankBalance);*/


/* string studentName = "Rahul";
 int studentAge = 20;

 Console.WriteLine("studentName: " +studentName);
 Console.WriteLine("studentAge: " +studentAge);        
  }
}*/
//explicit example
class Program
{
    static void Main(string[] args)
    {

        int temperature = 34;

        if(temperature > 35)
        {
            Console.WriteLine("Hot Day");
        }
        else if(temperature > 15)
        {
            Console.WriteLine("Cold Day");
        }
        else
        {
            Console.WriteLine("Normal Day");
        }
       /*int enteredPin = 1234;
       int correctPin = 1234;
        int balance = 2000;

        if(enteredPin == correctPin && balance > 1000)
        {
            Console.WriteLine("Cash withdrawn");
        }
        else
        {
            Console.WriteLine("Transaction Failed");
        }*/

      /*int age = 15;

      if(age < 13)
        {
            Console.WriteLine("child");
        }
        else if(age < 20)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }*/
        /*string trafficLight = "Yellow";

        if(trafficLight == "Red")
        {
            Console.WriteLine("Stop");
        }
        else if(trafficLight == "Yellow")
        {
            Console.WriteLine("yellow");
        }
        else
        {
            Console.WriteLine("Go");
        }*/

       /*int atmBalance = 5000;
       int withdrawalAmount = 3000;

       if(atmBalance >= withdrawalAmount)
        {
            Console.WriteLine("Transaction Successful");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }*/

      /*string today = "Sunday";

      if(today == "Sunday")
        {
            Console.WriteLine("Holiday");
        }
        else
        {
            Console.WriteLine("Working Day");
        }*/

        /*int marks = 78;

        if(marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        if (marks >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else
        {
            Console.WriteLine("Fail");
        }*/

     /*int age = 18;
     string country = "India";

     if(age > 18 && country == "India")
        {
            Console.WriteLine("You can vote in india");
        }
        else
        {
            Console.WriteLine("You cannot vote in india");
        }*/

       /* int num = 4;

        if(num % 2 == 0)
        {
            Console.WriteLine("It is even number");
        }
        else
        {
            Console.WriteLine("It is odd number");
        }*/

/*string password = "1234";

if(password == "1234")
        {
            Console.WriteLine("Login Successfull");
        }
        else
        {
            Console.WriteLine("Wrong password");
        }*/
     /*int Salary = 60000;

     if (Salary > 50000)
        {
            Console.WriteLine("High Salary");
        }
        else
        {
            Console.WriteLine("Normal Salary");
        }*/
    /*int Salary = 60000;

    if(Salary > 50000)
        {
            Console.WriteLine("The Salary is greater than is 50000");
        }
        else
        {
        Console.WriteLine("The Salary is 50000 or less.");
        }*/

    /* string correctPassword = "12345";
     string enteredPassword = "12345";

     if (enteredPassword == correctPassword)
        {
            Console.WriteLine("password is correct. Access granted");
        }
        else
        {
            Console.WriteLine("Incorrect Password. Access denied");
        }*/

     /* bool isRaining = false;

      if(isRaining)
        {
            Console.WriteLine("Take an umbrella , it is raining outside");
        }
        else
        {
            Console.WriteLine("No rain, you can go without umbrella");
        }*/
        /*int battery =  15;

        if(battery > 20)
        {
            Console.WriteLine("Battery is low! Please Charge your Phone");
        }
        else
        {
            Console.WriteLine("Battery level is sufficient");
        }*/

      /*string trafficLight = "Green";

      if(trafficLight == "Green")
        {
            Console.WriteLine("You can go now");
        }
        else
        {
            Console.WriteLine("Stop! Wait for the green Light");
        }*/

     /* int score = 40;

      if(score > 33)
        {
            Console.WriteLine("The Student has passes the exam");
        }
        else
        {
            Console.WriteLine("The student has failed the exam");
        }*/
     /*bool isShopOpen = true;

        if (isShopOpen)
        {
            Console.WriteLine("The shop is open, you can buy things.");
        }
        else
        {
            Console.WriteLine("The shop is closed now");
        }*/
        /*int temp = 42;

        if(temp > 40)
        {
            Console.WriteLine("It is very hot outside");
        }
        else
        {
            Console.WriteLine("The temperature is normal");
        }*/

     /*int age = 20;

     if(age >= 18)
        {
            Console.WriteLine("Elligible is vote");
        }
        else
        {
            Console.WriteLine("Ellogible is not vote");
        }*/

     /*double payment = 1234.75;
     int wholeRupees = (int)payment;

     Console.WriteLine("Payment in double : " +payment);
     Console.WriteLine("Payment in int (whole rupees ): " + wholeRupees);*/


       /* string birthdateString = "15-08-2007";

        DateTime birthDate = Convert.ToDateTime(birthdateString);

        DateTime today = DateTime.Now;

        int age = today.Year - birthDate.Year;

        if(today < birthDate.AddYears(age))
        {
            age--;
        }

        Console.WriteLine("BirthDate entered: " +birthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + today.ToShortDateString());
        Console.WriteLine("Calculated Age: " + age + "Years");*/


    
    /* float marks = 85.5f;

     string marksString = marks.ToString();

     Console.WriteLine("Report Card");
     Console.WriteLine("---------");
     Console.WriteLine("Student Name: Rahul Sharma");
     Console.WriteLine("Marks Obtained: "+marksString);*/

    /*double tempreatureData = 32.7;

    int roundedTempreature = Convert.ToInt32(tempreatureData);

    Console.WriteLine("Original Temperature (double): " +tempreatureData);
    Console.WriteLine("Rounded Tempreature (int): " +roundedTempreature);*/

     /* decimal pricePerItem = 250.50m;

    string quantityString = "4";

    int quantity = Convert.ToInt32(quantityString);

    decimal totalPrice = pricePerItem * quantity;

    Console.WriteLine("Price per item: " +pricePerItem);
    Console.WriteLine("Quantity entered: " +quantity);
    Console.WriteLine("Total price: " +totalPrice);*/



     /* string balanceString = "10500.75";

      decimal accountBalance = Convert.ToDecimal(balanceString);

      decimal interestRate = 0.05m;
      decimal interestAmount = accountBalance * interestRate;
      decimal newBalance = accountBalance *interestAmount;

      Console.WriteLine("Original Balance: "+accountBalance);
      Console.WriteLine("Interest Amount: " +interestAmount);
      Console.WriteLine("New Balance after interest: "+ newBalance);*/

     /* string userInput = "4500";

      int number = Convert.ToInt32(userInput);

      int result = number + 500;
      Console.WriteLine("Final Result: " + result);*/


     /*double price = 450.99;
     int castePrice = (int)price;

     int convertedPrice = Convert.ToInt32(price);

     Console.WriteLine("Using (int) casting: " + castePrice);
     Console.WriteLine("Using Convert.ToInt32: " + convertedPrice);*/

     /* char grade = 'A';
      int asciiValue = (int)grade;

      Console.WriteLine(asciiValue);*/
       /* decimal amount = 1234.56m;
        int paise = (int)amount;

        Console.WriteLine(paise);*/

       /* float temp = 36.7f;
        int displayTemp = (int)temp;

        Console.WriteLine(displayTemp);*/

        /*double marks = 89.67;
        int finalMarks = (int)marks;

        Console.WriteLine(finalMarks);*/

        /*double balance = 10500.75;
        int wholeRupees = (int)balance;

        Console.WriteLine("Balance stored  in database (whole rupees): "  +wholeRupees);*/

        /*double productPrice = 1999.99;
        int roundedPrice = (int)productPrice;

        Console.WriteLine("Rounded Price: " +roundedPrice);*/
    }
}
//implicit example
/*class Program
{
    static void Main(string[]args)
    {

        float averageMarks = 85.5f;
        double finalResult = averageMarks;

        Console.WriteLine("Final Result: " +finalResult);

      /*  double monthlySalary = 50000;
        double yearlySalary = monthlySalary * 12;
        Console.WriteLine("Yearly Salary: " +yearlySalary);*/

       /* double bigValue = 9.78;
        int smallValue = (int)bigValue;
        Console.WriteLine(smallValue);*/

       /* int smallNumber = 10;
        double bigNumber = smallNumber;
        Console.WriteLine(bigNumber);*/

      /*  int smallCup =  100;
        double bigJug = smallCup;
        Console.WriteLine(bigJug);*/
       /*string orderID;

       orderID = "ORD12345";

       Console.WriteLine("Order ID: " +orderID);*/

       /*int library;

       library = 3500;

       Console.WriteLine("total books in library: " +library);*/

        /*int score;

        score = 120;

        Console.WriteLine("run scored by a batsman: " +score);*/


       /*double temperature;

       temperature = 32.5;

       Console.WriteLine("Today's temperature: " +temperature);*/

       /*int price;
        
        price = 250;

        Console.WriteLine("Ticket Price : " +price);*/

  /*int Math;
 
  Math = 92;

  Console.WriteLine("marks in Math subject: " +Math);*/


    /*double accountBalance;

    accountBalance = 10000;

    Console.WriteLine("customer's account balance: " +accountBalance);*/
    /*int items;

    items = 5;

    Console.WriteLine("number of itmes: "+items);*/


/*double monthSalary;

monthSalary = 45000;

Console.WriteLine("Employee Month's Salary: " +monthSalary);*/

       /* int age;

        age = 18;

        Console.WriteLine("Student Age: " +age);
    }
}*/
