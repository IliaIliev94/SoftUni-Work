import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	Scanner myObj = new Scanner(System.in);
	double grade = Double.parseDouble(myObj.nextLine());
	if (grade >= 5.50) {
	    System.out.println("Excellent!");
    }
    }
}
