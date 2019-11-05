import java.util.Scanner;

public class TrainTheTrainers {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int judges = Integer.parseInt(myObj.nextLine());
        String presentation = myObj.nextLine();
        double grade = 0;
        double finalGrade = 0;
        int counter = 0;

        while (!presentation.equals("Finish")) {
            for (int i = 0; i < judges; i++ ) {
                grade += Double.parseDouble(myObj.nextLine());
            }
            System.out.printf("%s - %.2f.%n", presentation, grade/judges);
            finalGrade += grade/judges;
            grade = 0;
            counter++;
            presentation = myObj.nextLine();
        }
        System.out.printf("Student's final assessment is %.2f.", finalGrade/counter);
    }
}
