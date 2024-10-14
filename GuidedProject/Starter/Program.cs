using System;

// initialize variables - exam assignments
int examAssignments = 5;

// Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

List<int[]> scores = [
    [90,86,87,98, 100, 94, 90],
    [92,89,81,96,90,89],
    [90, 85, 87, 98, 68, 89, 89, 89],
    [90, 95, 87, 88, 96, 96]];

int[] studentScores = new int[10];
string letterGrade;

// Write the Report Header to the console
Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\t\tExtra Credits\n");

foreach (string name in studentNames) {

    switch (name) {
        case "Sophia":
            studentScores = scores[0];
            break;
        case "Andrew":
            studentScores = scores[1];
            break;
        case "Emma":
            studentScores = scores[2];
            break;
        case "Logan":
            studentScores = scores[3];
            break;
    }

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the sum of only the exam Scores
    int sumSimpleScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // initialize/reset the sum of only extra exam scores
    int sumExtraScores = 0;

    // initialize/reset a counter for the number of extra exams
    int extraExams = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores) {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments) {
            // add the exam score to the sum
            sumSimpleScores += score;
            sumAssignmentScores += score;
        } else {
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            extraExams += 1;
            sumAssignmentScores += score / 10;
            sumExtraScores += score;
        }
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97) {
        letterGrade = "A+";
    } else if (currentStudentGrade >= 93) {
        letterGrade = "A";
    } else if (currentStudentGrade >= 90) {
        letterGrade = "A-";
    } else if (currentStudentGrade >= 87) {
        letterGrade = "B+";
    } else if (currentStudentGrade >= 83) {
        letterGrade = "B";
    } else if (currentStudentGrade >= 80) {
        letterGrade = "B-";
    } else if (currentStudentGrade >= 77) {
        letterGrade = "C+";
    } else if (currentStudentGrade >= 73) {
        letterGrade = "C";
    } else if (currentStudentGrade >= 70) {
        letterGrade = "C-";
    } else if (currentStudentGrade >= 67) {
        letterGrade = "D+";
    } else if (currentStudentGrade >= 63) {
        letterGrade = "D";
    } else if (currentStudentGrade >= 60) {
        letterGrade = "D-";
    } else {
        letterGrade = "F";
    }

    decimal examScore = (decimal)sumSimpleScores/examAssignments;
    decimal extraScore = (decimal)sumExtraScores/extraExams;
    decimal extraExamPoints = (decimal)sumExtraScores/examAssignments*10/100;

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{name}\t\t{examScore}\t\t{currentStudentGrade}\t{letterGrade}\t\t{extraScore} ({extraExamPoints} pts)");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
