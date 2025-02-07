﻿namespace  Starter;
internal static class Program
{
    public static void Main(string[] args)
    {
        // initialize variables - graded assignments
        int examAssignments = 5;
        
        // Arrays storing the scores of each student
        int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
        int[] andrewScores = [92, 89, 81, 96, 90, 89];
        int [] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
        int [] loganScores = [90, 95, 87, 88, 96, 96];
        int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
        int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
        int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
        int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];  
        
        // array storing student names
        string [] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];
        // array for storing student scores

        Console.WriteLine("Student\t\tGrade" );
        
        foreach (var name in studentNames)
        {
            string currentStudent = name;

            int[] studentScores;
            if (currentStudent == "Sophia")
                studentScores = sophiaScores;
            else if (currentStudent == "Andrew")
                studentScores = andrewScores;
            else if (currentStudent == "Emma")
                studentScores = emmaScores;
            else if (currentStudent == "Logan")
                studentScores = loganScores;
            else if (currentStudent == "Becky")
                studentScores = beckyScores;
            else if (currentStudent == "Chris")
                studentScores = chrisScores;
            else if (currentStudent == "Eric")
                studentScores = ericScores;
            else if (currentStudent == "Gregor")
                studentScores = gregorScores;
            else
                continue;
            
            // initialize/reset the sum of scored assignments
            int sumAssignmentScores = 0;
            
            // initialize/reset the calculated average of exam + extra credit scores

            // initialize/reset a counter for the number of assignments
            int gradedAssignments = 0;
            
            foreach (var score in studentScores)
            {
                // increment the assigment counter
                gradedAssignments +=1;
                
                if (gradedAssignments <= examAssignments)
                    sumAssignmentScores += score;
                
                else 
                    // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                    sumAssignmentScores += score / 10;
            }
            
            var currentStudentGrade = (decimal) sumAssignmentScores / examAssignments;

            string currentStudentLetterGrade;
            
            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";
            
            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";

            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";

            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";

            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";

            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";

            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";

            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";

            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";

            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";

            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";

            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F"; 
            
            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }
        
        Console.Write("\nPress the Enter key to continue ");
        Console.ReadLine();
    }
}

