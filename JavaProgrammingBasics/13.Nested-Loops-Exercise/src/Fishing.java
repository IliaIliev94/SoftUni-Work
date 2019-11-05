import java.util.Scanner;

public class Fishing {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int dailyQuote = Integer.parseInt(myObj.nextLine());
        String fish = "";
        double weight;
        double total = 0;
        double profit = 0;
        int counter = 0;
        for (int i = 1; i <= dailyQuote; i++) {
            fish = myObj.nextLine();
            if (fish.equals("Stop")) {
                break;
            }
            weight = Double.parseDouble(myObj.nextLine());
            for (int j = 0; j < fish.length(); j++) {
                if (i % 3 != 0) {
                    profit -= (int) fish.charAt(j);
                }
                else {
                    profit += (int) fish.charAt(j);
                }
            }
            profit /= weight;
            total += profit;
            profit = 0;
            counter++;
        }
        if (!fish.equals("Stop")) {
            System.out.println("Lyubo fulfilled the quota!");
        }
        if (total > 0) {
            System.out.printf("Lyubo's profit from %d fishes is %.2f leva.", counter, total);
        }
        else {
            System.out.printf("Lyubo lost %.2f leva today.", Math.abs(total));
        }
    }
}
