import java.util.Scanner;

public class AccountBalance {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int transactions = Integer.parseInt(myObj.nextLine());
        double total = 0;
        double increase;
        int count = 0;

        while (count < transactions) {
            increase = Double.parseDouble(myObj.nextLine());
            if (increase < 0) {
                System.out.println("Invalid operation!");
                break;
            }
            System.out.printf("Increase: %.2f\n", increase);
            total += increase;
            count++;
        }
        System.out.printf("Total: %.2f", total);
    }
}
