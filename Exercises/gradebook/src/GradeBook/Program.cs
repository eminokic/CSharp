using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is your grade calculator!");
            Console.WriteLine("We will ask a few questions to understand your class...");
            PrintLine();

            //Get homework grades and weight
            Console.WriteLine("What are your homework grades out of 100? \n\n Formula: Points Earned / Points Possible \n\n Enter a comma in between each grade, \n\n ie) 0,1,2,3,4 \n\n (Press Enter if NA) ");
            string homeworkGrades = Console.ReadLine();
            Console.WriteLine("What is the total weight in percentage for homework? \n\n ie) 20% of your total grade \n\n (Press Enter if NA) ");
            string homeworkWeight = Console.ReadLine();
            PrintLine();

            //Get quiz grades and weight
            Console.WriteLine("What are your quiz grades out of 100? \n\n Formula: Points Earned / Points Possible \n\n Enter a comma in between each grade, \n\n ie) 0,1,2,3,4 \n\n (Press Enter if NA) ");
            string quizGrades = Console.ReadLine();
            Console.WriteLine("What is the total weight in percentage for quizzes? \n\n ie) 20% of your total grade \n\n (Press Enter if NA) ");
            string quizWeight = Console.ReadLine();
            PrintLine();

            //Get exam grades and weight
            Console.WriteLine("What are your exam grades (excluding final) out of 100? \n\n Formula: Points Earned / Points Possible \n\n Enter a comma in between each grade, \n\n ie) 0,1,2,3,4 \n\n (Press Enter if NA) ");
            string examGrades = Console.ReadLine();
            Console.WriteLine("What is the total weight in percentage for exams? \n\n ie) Exam 1: 20% of your final grade \n\n Exam 2: 20% of your final grade \n\n then total weight is 40% of total grade \n\n (Press Enter if NA) ");
            string examWeight = Console.ReadLine();
            PrintLine();

            //Get final exam grade and weight
            Console.WriteLine("What are your final exam grade out of 100? \n\n Formula: Points Earned / Points Possible \n\n Enter a comma in between each grade, \n\n ie) 0,1,2,3,4 \n\n (Press Enter if NA) ");
            string finalExamGrades = Console.ReadLine();
            Console.WriteLine("What is the total weight in percentage for the final exam? \n\n ie) 20% of your total grade \n\n (Press Enter if NA) ");
            string finalExamWeight = Console.ReadLine();
            PrintLine();

            //Give user entertainment while calculating
            Console.WriteLine("\n\nHold on calculating... \n\n calculating... \n\n calculating... \n\n Here are the results! ");
            
            //Take inputs and calculate results
            double finalHomeworkGrade = getGrades(homeworkGrades, homeworkWeight);
            double finalQuizGrade = getGrades(quizGrades, quizWeight);
            double finalExamGrade = getGrades(examGrades, examWeight);
            double finalFinalExamGrade = getGrades(finalExamGrades, finalExamWeight);
            double finalGrade = (finalHomeworkGrade + finalQuizGrade + finalExamGrade + finalFinalExamGrade);


            //int tableWidth = 100;
            PrintLine();
            PrintRow("Gradebook Results", "@author", "Emin Okic", "");
            PrintLine();
            PrintRow("Category", "Percent Earned", "Percent Possible", "");
            PrintLine();
            PrintRow("Homework", finalHomeworkGrade.ToString(), homeworkWeight, "");
            PrintLine();
            PrintRow("Quiz", finalQuizGrade.ToString(), quizWeight, "");
            PrintLine();
            PrintRow("Exams", finalExamGrade.ToString(), examWeight, "");
            PrintLine();
            PrintRow("Final Exam", finalFinalExamGrade.ToString(), finalExamWeight, "");
            PrintLine();
            PrintRow("Final Grade", finalGrade.ToString(), "100", "");
            PrintLine();
            
        }

        /* Get Grades Method
         * Takes string input of grades
         * Takes in total weight for given category of grades
         * 
         * @param string givenGrades - grades given
         * @param int totalWeight - total weight in percent for category
         * @return grade - grade for given category
         */
        public static double getGrades(string givenGrades, string totalWeight) {
            string[] totalGrades = givenGrades.Split(',', givenGrades.Length);
            double total = 0;
            double grade = 0.0;
            
            if(givenGrades == null) {
                return grade;
            }
            for (int i = 0; i < totalGrades.Length; i++) {
                total += Int64.Parse(totalGrades[i]);
            }
            grade = (double)(total / totalGrades.Length) * Int64.Parse(totalWeight) * 0.01;
            return grade;   
        }
        static void PrintLine()
        {
            int tableWidth = 100;
            Console.WriteLine(new string('-', tableWidth));   
        }
        static void PrintRow(params string[] givenColumns)
        {
            int tableWidth = 100;
            int width = (tableWidth - (givenColumns.Length - 1) ) / (givenColumns.Length - 1);
            string row = "|";
            foreach (string column in givenColumns)
            {
                row += AlignCentre(column, width) + "|";    
            }
            
            Console.WriteLine(row);
        }
        static string AlignCentre(string givenText, int givenWidth)
        {
            givenText = givenText.Length > givenWidth ? givenText.Substring(0, givenWidth - 3) + "..." : givenText;
            if (string.IsNullOrEmpty(givenText))
            {
                return new string(' ', givenWidth);
            } else {
                return givenText.PadRight(givenWidth - (givenWidth - givenText.Length) / 2).PadLeft(givenWidth);
            }
        }

    }

}
