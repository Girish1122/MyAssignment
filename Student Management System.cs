using System;
namespace Hardwork
{
    public class Mehnat
    {
        int roll;
        string name;
        int total = 0;
        float avg;
        string grade;
        string[] sub = new string[] { "Maths", "Science", "English" };
        int[] marks = new int[3];
        public Mehnat()
        {
            Console.WriteLine("enter the rollno:");
            roll = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the name:");
            name = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter the marks for " + sub[i] + " =");
                marks[i] = int.Parse(Console.ReadLine());
                total += marks[i];
                avg = total / 3;
            }
        }
        public void print()
        {
            Console.WriteLine("Roll No of student is = " + roll);
            Console.WriteLine("NAME of student is = " + name);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("marks for " + sub[i] + " are = " + marks[i]);
            }
            if (avg >= 80 && avg <= 100)
            {
                grade = "First class with distinction";
                Console.WriteLine("Percentage score is = " + avg + " % and grade is = " + grade);
            }
            else if (avg >= 60 && avg <= 80)
            {
                grade = "First class";
                Console.WriteLine("Percentage score is = " + avg + " % and grade is = " + grade);
            }
            else if (avg >= 40 && avg <= 60)
            {
                grade = "second class";
                Console.WriteLine("Percentage score is = " + avg + " % and grade is = " + grade);
            }
            else
            {
                Console.WriteLine("Percentage score is = " + avg + " %  hence failed");
            }
        }
        static void Main(string[] args)
        {
            int i, j, n;
            int pass = 0, fail = 0;
            Console.WriteLine("Enter num of records = ");
            n = int.Parse(Console.ReadLine());
            Mehnat[] ob = new Mehnat[n];
            for (i = 0; i < n; i++)
            {
                ob[i] = new Mehnat();
                Console.WriteLine("______________________________________________________________________________________");
                ob[i].print();
                Console.WriteLine("______________________________________________________________________________________");
            }
            Mehnat temp;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (ob[j].avg > ob[j + 1].avg)
                    {
                        temp = ob[j];
                        ob[j] = ob[j + 1];
                        ob[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("______________________________________________________________________________________");
            Console.WriteLine("Topper in the class is :");
            ob[n - 1].print();
            Console.WriteLine("______________________________________________________________________________________");

            for (i = 0; i < n; i++)
            {
                if (ob[i].avg > 40)
                    pass++;
                else
                    fail++;
            }
            Console.WriteLine("Number of passed students are = " + pass + " and their details are as below: ");
            for (i = 0; i <n; i++)
            {
                if (ob[i].avg > 40)
                    ob[i].print();
            }
            Console.WriteLine("______________________________________________________________________________________");
            Console.WriteLine("Number of failed students are = " + fail + " and their details are as below: ");
            for (i = 0; i < n; i++)
            {
                if (ob[i].avg < 40)
                    ob[i].print();
            }
        }
    }
}