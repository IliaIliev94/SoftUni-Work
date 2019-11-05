import java.util.Scanner;

public class ChristmasSweets {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        double baklavaPrice = Double.parseDouble(myObj.nextLine());
        double muffinsPrice = Double.parseDouble(myObj.nextLine());
        double calfQuantity = Double.parseDouble(myObj.nextLine());
        double candyQuantity = Double.parseDouble(myObj.nextLine());
        double cookieQuantity = Double.parseDouble(myObj.nextLine());

        double calfPrice = baklavaPrice + baklavaPrice * 0.60;
        double calfSum = calfPrice * calfQuantity;
        double candyPrice = muffinsPrice + muffinsPrice * 0.8;
        double candySum = candyPrice * candyQuantity;
        double cookieSum = cookieQuantity * 7.5;

        double total = calfSum + candySum + cookieSum;
        System.out.printf("%.2f", total);

    }
}
