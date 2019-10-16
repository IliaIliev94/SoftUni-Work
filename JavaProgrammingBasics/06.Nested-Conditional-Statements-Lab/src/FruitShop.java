import java.util.Scanner;

public class FruitShop {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String product = myObj.nextLine();
        String day = myObj.nextLine();
        double quantity = Double.parseDouble(myObj.nextLine());
        double price = 0;

        if (day.equals("Monday") || day.equals("Tuesday") || day.equals("Wednesday") || day.equals("Thursday") || day.equals("Friday")) {
            switch(product) {
                case "banana":
                    price = 2.50;
                    break;
                case "apple":
                    price = 1.20;
                    break;
                case "orange":
                    price = 0.85;
                    break;
                case "grapefruit":
                    price = 1.45;
                    break;
                case "kiwi":
                    price = 2.70;
                    break;
                case "pineapple":
                    price = 5.50;
                    break;
                case "grapes":
                    price = 3.85;
                    break;
                default:
                    System.out.println("error");
                    return;
            }
        }
        else if (day.equals("Saturday") || day.equals("Sunday")) {
            switch(product) {
                case "banana":
                    price = 2.70;
                    break;
                case "apple":
                    price = 1.25;
                    break;
                case "orange":
                    price = 0.90;
                    break;
                case "grapefruit":
                    price = 1.60;
                    break;
                case "kiwi":
                    price = 3.00;
                    break;
                case "pineapple":
                    price = 5.60;
                    break;
                case "grapes":
                    price = 4.20;
                    break;
                default:
                    System.out.println("error");
                    return;
            }
        }
        else {
            System.out.println("error");
            return;
        }
        double sum = price * quantity;
        System.out.printf("%.2f", sum);
    }
}
