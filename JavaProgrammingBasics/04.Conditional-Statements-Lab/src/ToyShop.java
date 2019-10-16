import java.util.Scanner;

public class ToyShop {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);

        double tripPrice = Double.parseDouble(myObj.nextLine());
        int puzzles = Integer.parseInt(myObj.nextLine());
        int talkingPuppet = Integer.parseInt(myObj.nextLine());
        int teddyBears = Integer.parseInt(myObj.nextLine());
        int minions = Integer.parseInt(myObj.nextLine());
        int trucks = Integer.parseInt(myObj.nextLine());
        double discount = 0;

        double toysSum = puzzles * 2.60 + talkingPuppet * 3 + teddyBears * 4.10 + minions * 8.20 + trucks * 2;
        int toysCount = puzzles + talkingPuppet + teddyBears + minions + trucks;

        if (toysCount >= 50) {
            discount = 0.25;
        }
        double finalPrice = toysSum - (toysSum * discount);
        double rent = finalPrice * 0.10;
        double profit = finalPrice - rent;

        if (profit >= tripPrice) {
            double leftOver = profit - tripPrice;
            System.out.printf("Yes! %.2f lv left.", leftOver);
        }
        else {
            double deficit = tripPrice - profit;
            System.out.printf("Not enough money! %.2f lv needed.", deficit);
        }
    }
}
