import java.util.Scanner;

public class Scholarships {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        double income = Double.parseDouble(myObj.nextLine());
        double grade = Double.parseDouble(myObj.nextLine());
        double minimalWage = Double.parseDouble(myObj.nextLine());
        double socialScholarship = 0;
        double excellanceScholarship = 0;

        if (income < minimalWage && grade > 4.50) {
            socialScholarship = 0.35 * minimalWage;
        }
        if (grade >= 5.50) {
            excellanceScholarship = grade * 25;
        }
        if (excellanceScholarship >= socialScholarship && excellanceScholarship != 0) {
            System.out.printf("You get a scholarship for excellent results %.0f BGN", Math.floor(excellanceScholarship));
        }
        else if (socialScholarship > excellanceScholarship) {
            System.out.printf("You get a Social scholarship %.0f BGN", Math.floor(socialScholarship));
        }
        else {
            System.out.println("You cannot get a scholarship!");
        }


    }
}
