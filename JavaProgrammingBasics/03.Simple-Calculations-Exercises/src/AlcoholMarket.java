import java.util.Scanner;

public class AlcoholMarket {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);

        double whiskeyPrice = Double.parseDouble(myObj.nextLine());
        double beerLitres = Double.parseDouble(myObj.nextLine());
        double wineLitres = Double.parseDouble(myObj.nextLine());
        double rakiaLitres = Double.parseDouble(myObj.nextLine());
        double whiskeyLitres = Double.parseDouble(myObj.nextLine());

        double rakiaPrice = whiskeyPrice * 0.50;
        double winePrice = rakiaPrice - (rakiaPrice * 0.40);
        double beerPrice = rakiaPrice - (rakiaPrice * 0.80);

        double rakiaSum = rakiaLitres * rakiaPrice;
        double whiskeySum = whiskeyLitres * whiskeyPrice;
        double wineSum = wineLitres * winePrice;
        double beerSum = beerLitres * beerPrice;
        double totalSum = rakiaSum + whiskeySum + wineSum + beerSum;

        System.out.printf("%.2f", totalSum);
    }
}
