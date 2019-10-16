import java.util.Scanner;

public class Graduation {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String name = myObj.nextLine();
        int counter = 0;
        double grade;
        double total = 0;
        while (counter < 12) {
            grade = Double.parseDouble(myObj.nextLine());
            if (grade < 4) {
                grade = Double.parseDouble(myObj.nextLine());
            }
            total += grade;
            counter++;
        }
        total /= 12;
        System.out.printf("%s graduated. Average grade: %.2f", name, total);
    }
}
