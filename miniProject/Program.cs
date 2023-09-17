using System;


namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();

            Console.WriteLine("Please Enter your Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Please Enter your Grade: ");
            student.Grade = int.Parse(Console.ReadLine()); //convert input string to integer

            student.studentInfo();

        }

    }
    class Student
    {
        //two fields
        public string Name;
        public int Grade;

        public void studentInfo()
        {
            //this is method for print info
            if (Grade >= 60 && Grade<=100)
            {
                Console.WriteLine("Your Name is: {0}, and your Grade is: {1}" ,Name,Grade);
                Console.WriteLine("You Are Passed");
            }
            else if(Grade < 60)
            {
                Console.WriteLine("your name is: {0}, and your Grade is: {1}", Name, Grade);
                Console.WriteLine("You Are Failed");

            }
            else
            {
                Console.WriteLine("please try again ");
            }

        }
    }
}
