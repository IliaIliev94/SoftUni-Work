import java.util.Scanner;

public class CleverLily {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int age = Integer.parseInt(myObj.nextLine());
        double price = Double.parseDouble(myObj.nextLine());
        int toyPrice = Integer.parseInt(myObj.nextLine());
        double savings = 0;
        for (int i = 1; i <= age; i++) {
            if (i % 2 == 0) {
                savings += i * 5;
                savings -= 1;
            }
            else {
                savings += toyPrice;
            }
        }
        if (savings >= price) {
            System.out.printf("Yes! %.2f", savings - price);
        }
        else {
            System.out.printf("No! %.2f", price - savings);
        }
    }
}
