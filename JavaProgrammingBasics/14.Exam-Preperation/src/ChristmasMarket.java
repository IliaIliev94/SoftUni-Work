import java.util.Scanner;

public class ChristmasMarket {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        double targetSum = Double.parseDouble(myObj.nextLine());
        int fantasyBooks = Integer.parseInt(myObj.nextLine());
        int horrorBooks = Integer.parseInt(myObj.nextLine());
        int romanticBooks = Integer.parseInt(myObj.nextLine());

        double profit = fantasyBooks * 14.90 + horrorBooks * 9.80 + romanticBooks * 4.30;
        profit -= profit * 0.2;

        if (profit >= targetSum) {
            profit -= targetSum;
            double sumSellers = Math.floor(profit * 0.10);
            profit -= sumSellers;
            System.out.printf("%.2f leva donated.%n", targetSum + profit);
            System.out.printf("Sellers will receive %.0f leva.", sumSellers);
        }
        else {
            System.out.printf("%.2f money needed.", targetSum - profit);
        }
    }
}
