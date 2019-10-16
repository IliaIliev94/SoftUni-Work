import java.util.Scanner;
public class NumberInRange {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int num = Integer.parseInt(myObj.nextLine());
        while (num < 1 || num > 100) {
            System.out.println("Invalid Number");
            num = Integer.parseInt(myObj.nextLine());
        }
        System.out.printf("The number is: %d", num);
    }
}
