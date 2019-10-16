import java.util.Scanner;

public class FishingBoat {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int groupBudget = Integer.parseInt(myObj.nextLine());
        String season = myObj.nextLine();
        int fishers = Integer.parseInt(myObj.nextLine());
        double price = 0;
        if (season.equals("Spring")) {
            price = 3000;
        }
        else if (season.equals("Summer") || season.equals("Autumn")) {
            price = 4200;
        }
        else {
            price = 2600;
        }

        if (fishers <= 6) {
            price = price - price * 0.1;
        }
        else if (fishers >= 7 && fishers <= 11) {
            price = price - price * 0.15;
        }
        else {
            price = price - price * 0.25;
        }
        if (fishers % 2 == 0 && !season.equals("Autumn")) {
            price = price - price * 0.05;
        }
        if (groupBudget >= price) {
            System.out.printf("Yes! You have %.2f leva left.", groupBudget - price);
        }
        else {
            System.out.printf("Not enough money! You need %.2f leva.", price - groupBudget);
        }
    }
}
