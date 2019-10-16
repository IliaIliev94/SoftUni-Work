import java.util.Scanner;

public class GodzillaVsKong {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double movieBudget = Double.parseDouble(myObj.nextLine());
        int actors = Integer.parseInt(myObj.nextLine());
        double clothingPrice = Double.parseDouble(myObj.nextLine());

        double decor = movieBudget * 0.10;
        double clothingSum = clothingPrice * actors;

        if (actors > 150) {
            clothingSum = clothingSum - (clothingSum * 0.10);
        }
        double totalPrice = decor + clothingSum;
        double result = 0;

        if (movieBudget >= totalPrice) {
            result = movieBudget - totalPrice;
            System.out.printf("Action!\nWingard starts filming with %.2f leva left.", result);
        }
        else {
            result = totalPrice - movieBudget;
            System.out.printf("Not enough money!\nWingard needs %.2f leva more.", result);
        }
    }
}
