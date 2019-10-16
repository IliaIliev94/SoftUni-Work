import java.util.Scanner;

public class ExamPreparation {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int badGradeTreshold = Integer.parseInt(myObj.nextLine());
        int badGradeCount = 0;
        int counter = 0;
        String problem = "";
        double averageScore = 0;
        int grade = 0;
        String lastProblem = "";
        boolean isFailed = true;
        while (!problem.equals("Enough") && badGradeCount < badGradeTreshold) {
            problem = myObj.nextLine();
            if (problem.equals("Enough")) {
                isFailed = false;
            }
            else {
                lastProblem = problem;
                grade = Integer.parseInt(myObj.nextLine());
                averageScore += grade;
                if (grade <= 4) {
                    badGradeCount++;
                }
                counter++;
            }
        }
        if (!isFailed) {
            System.out.printf("Average score: %.2f\n", averageScore/counter);
            System.out.printf("Number of problems: %d\n", counter);
            System.out.printf("Last problem: %s", lastProblem);
        }
        else {
            System.out.printf("You need a break, %d poor grades.", badGradeTreshold);
        }
    }
}
