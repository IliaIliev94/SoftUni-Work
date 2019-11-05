import java.util.Scanner;

public class test {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int locations = Integer.parseInt(myObj.nextLine());
        double gold;
        int days;
        double goldPerDay = 0;
        double averageGold;
        int counter = 0;

        for (int i = 0; i < locations; i++) {
            gold = Double.parseDouble(myObj.nextLine());
            days = Integer.parseInt(myObj.nextLine());
            for (int j = 0; j < days; j++) {
                goldPerDay += Double.parseDouble(myObj.nextLine());
                counter++;
            }
            averageGold = goldPerDay / counter;
            if (averageGold >= gold) {
                System.out.printf("Good job! Average gold per day: %.2f.%n", averageGold);
            }
            else {
                System.out.printf("You need %.2f gold.%n", gold - averageGold);
            }
            goldPerDay = 0;
            counter = 0;
        }
    }
}
