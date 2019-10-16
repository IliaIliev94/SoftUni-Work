import java.util.Scanner;

public class OperationsBetweenNumbers {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int num1 = Integer.parseInt(myObj.nextLine());
        int num2 = Integer.parseInt(myObj.nextLine());
        String operator = myObj.nextLine();
        int result;
        if (operator.equals("+")) {
            result = num1 + num2;
            if (result % 2 == 0) {
                System.out.printf("%d + %d = %d - even", num1, num2, result);
            }
            else {
                System.out.printf("%d + %d = %d - odd", num1, num2, result);
            }
        }
        else if (operator.equals("-")) {
            result = num1 - num2;
            if (result % 2 == 0) {
                System.out.printf("%d - %d = %d - even", num1, num2, result);
            }
            else {
                System.out.printf("%d - %d = %d - odd", num1, num2, result);
            }
        }
        else if (operator.equals("*")) {
            result = num1 * num2;
            if (result % 2 == 0) {
                System.out.printf("%d * %d = %d - even", num1, num2, result);
            }
            else {
                System.out.printf("%d * %d = %d - odd", num1, num2, result);
            }
        }
        else if ((operator.equals("/") || operator.equals("%")) && num2 == 0) {
            System.out.printf("Cannot divide %d by zero", num1);
        }
        else if (operator.equals("/")) {
            System.out.printf("%d / %d = %.2f", num1, num2, num1/(double) num2);
        }
        else if (operator.equals("%")) {
            System.out.println(num1 + " % " + num2 + " = " + num1 % num2);
        }

    }
}
