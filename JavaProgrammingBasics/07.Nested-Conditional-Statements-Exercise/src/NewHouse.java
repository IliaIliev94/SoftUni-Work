import java.util.Scanner;

public class NewHouse {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String flowersType = myObj.nextLine();
        int flowersCount = Integer.parseInt(myObj.nextLine());
        int budget = Integer.parseInt(myObj.nextLine());
        double sum = 0;
        if (flowersType.equals("Roses")) {
            sum = 5 * flowersCount;
            if (flowersCount > 80) {
                sum = sum - sum * 0.1;
            }
        }
        else if (flowersType.equals("Dahlias")) {
            sum = 3.80 * flowersCount;
            if (flowersCount > 90) {
                sum = sum - sum * 0.15;
            }
        }
        else if (flowersType.equals("Tulips")) {
            sum = 2.80 * flowersCount;
            if (flowersCount > 80) {
                sum = sum - sum * 0.15;
            }
        }
        else if (flowersType.equals("Narcissus")) {
            sum = 3 * flowersCount;
            if (flowersCount < 120) {
                sum = sum + sum * 0.15;
            }
        }
        else {
            sum = 2.50 * flowersCount;
            if (flowersCount < 80) {
                sum = sum + sum * 0.2;
            }
        }
        if (sum > budget) {
            System.out.printf("Not enough money, you need %.2f leva more.", sum - budget);
        }
        else {
            System.out.printf("Hey, you have a great garden with %d %s and %.2f leva left.", flowersCount, flowersType, budget - sum);
        }
    }
}
