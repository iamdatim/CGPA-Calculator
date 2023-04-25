using System;
using System.Collections.Generic;

namespace GpaCalculator
{
    internal class Program
    {
       
        static void Main(string[] args)
        {


            //Regex very = new Regex(@"^[a-zA-Z]+$");


            string[] courseAndCode = new string[1000];
            int[] courseUnit = new int[1000];
            int[] courseScore = new int[1000];
            int[] gradeUnit = new int[1000];
            char[] grade = new char[1000];
            int[] weightPoint = new int[1000];
            string[] remark = new string[1000];
            int totalCourseUnitRegistered = 0;
            int totalWeightPoint = 0;
            int totalGradeUnit = 0;
            int totalCourseUnitPassed = 0;
            int numCourses = 0;


            bool isDecision = true;
            Console.WriteLine("-----------------------------------------| CGPA CALCULATOR |--------------------------------------------------");
            Console.WriteLine();
            Console.Write("Kindly Enter Your Name: ");
            string studentName = Convert.ToString(Console.ReadLine());
            Console.Clear();



            do
            {
                Console.WriteLine("-----------------------------------------| CGPA CALCULATOR |--------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Welcome " + studentName);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter your details for course {0}:", numCourses + 1);
                Console.WriteLine();
                Console.Write("Enter Course Name and Code: ");
                courseAndCode[numCourses] = Console.ReadLine();
                while (courseAndCode[numCourses].Length != 6)
                {
                    Console.WriteLine("Error!!! Your Course and Code Lenght must not be less than 6 or greater than 6");
                    Console.WriteLine();
                    Console.Write("Enter Course Name and Code Again: ");
                    courseAndCode[numCourses] = (Console.ReadLine());
                }

                Console.Write("Enter Course Units: ");
                courseUnit[numCourses] = int.Parse(Console.ReadLine());
                while (courseUnit[numCourses] > 5 || (courseUnit[numCourses] < 1))
                {
                    Console.WriteLine("Error Input Course Unit from 1 - 5");
                    Console.WriteLine();
                    Console.Write("Enter Course Unit Again: ");
                    courseUnit[numCourses] = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter Course Score: ");
                courseScore[numCourses] = int.Parse(Console.ReadLine());
                while (courseScore[numCourses] > 100 || courseScore[numCourses] < 0)
                {
                    Console.WriteLine("Error Input Course Score from 0 - 100");
                    Console.WriteLine();
                    Console.Write("Enter Course Score Again: ");
                    courseScore[numCourses] = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter Yes to add another course or Enter No to print table: ");
                string decision = Console.ReadLine();

                Console.Clear();

                if (decision == "Yes")
                {
                    isDecision = true;

                }

                else if (decision == "No")
                {
                    isDecision = false;
                }

                if (courseScore[numCourses] >= 70)
                {
                    grade[numCourses] = 'A';
                    gradeUnit[numCourses] = 5;
                    weightPoint[numCourses] = courseUnit[numCourses] * gradeUnit[numCourses];
                    remark[numCourses] = "Excellent";

                }

                else if (courseScore[numCourses] >= 60)
                {
                    grade[numCourses] = 'B';
                    gradeUnit[numCourses] = 4;
                    weightPoint[numCourses] = courseUnit[numCourses] * gradeUnit[numCourses];
                    remark[numCourses] = "Very Good";
                }

                else if (courseScore[numCourses] >= 50)
                {
                    grade[numCourses] = 'C';
                    gradeUnit[numCourses] = 3;
                    weightPoint[numCourses] = courseUnit[numCourses] * gradeUnit[numCourses];
                    remark[numCourses] = "Good";
                }

                else if (courseScore[numCourses] >= 45)
                {
                    grade[numCourses] = 'D';
                    gradeUnit[numCourses] = 2;
                    weightPoint[numCourses] = courseUnit[numCourses] * gradeUnit[numCourses];
                    remark[numCourses] = "Fair";
                }

                else if (courseScore[numCourses] >= 40)
                {
                    grade[numCourses] = 'E';
                    gradeUnit[numCourses] = 1;
                    weightPoint[numCourses] = courseUnit[numCourses] * gradeUnit[numCourses];
                    remark[numCourses] = "Pass";
                }

                else
                {
                    grade[numCourses] = 'F';
                    gradeUnit[numCourses] = 0;
                    weightPoint[numCourses] = courseUnit[numCourses] * gradeUnit[numCourses];
                    remark[numCourses] = "Fail";
                }

                ++numCourses;

            }
            while (isDecision);




            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------| RESULT TABLE |-------------------------------------------------------");
            Console.WriteLine("________________________________________________________________________________________________________________________");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("|--------------------|----------|------------------|----------|--------------------|----------|");
            Console.WriteLine("|Course & Code       |Unit      |Grade Unit        |Grade     |Weight Point        |Remarks   |");
            Console.WriteLine("|--------------------|----------|------------------|----------|--------------------|----------|");


            for (int i = 0; i < numCourses; i++)

            {
                Console.WriteLine("|{0,-20}|{1,-10}|{2,-18}|{3,-10}|{4,-20}|{5,-10}|", courseAndCode[i], courseUnit[i], gradeUnit[i], grade[i], weightPoint[i], remark[i]);
                Console.WriteLine("|--------------------|----------|------------------|----------|--------------------|----------|");

                totalCourseUnitRegistered += courseUnit[i];
                totalWeightPoint += weightPoint[i];
                totalGradeUnit += gradeUnit[i];


                if (courseScore[i] > 39)
                {
                    totalCourseUnitPassed += courseUnit[i];
                }

            }


            double gpa = Convert.ToDouble(totalWeightPoint) / Convert.ToDouble(totalCourseUnitPassed);
            //gpa = Math.Round(gpa, 2);


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Total Course Unit Registered is " + totalCourseUnitRegistered);
            Console.WriteLine("The total Course Unit Passed " + totalCourseUnitPassed);
            Console.WriteLine("The total Weight Point is " + totalWeightPoint);
            Console.WriteLine("Your GPA = {0:F2}", gpa);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________________________________________________________");




        }
        
    }
}
