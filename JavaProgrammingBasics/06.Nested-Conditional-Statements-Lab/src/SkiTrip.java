import java.util.Scanner;

public class SkiTrip {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double accommodation = Double.parseDouble(myObj.nextLine()) - 1;
        String apartmentType = myObj.nextLine();
        String satisfaction = myObj.nextLine();

        double discount = 0;
        double price = 0;

        if (apartmentType.equals("room for one person")) {
            price = 18 * accommodation;
        }
        else if (apartmentType.equals("apartment")) {
            price = 25 * accommodation;
            if (accommodation < 10) {
                discount = price * 0.3;
            }
            else if (accommodation >= 10 && accommodation <= 15) {
                discount = price * 0.35;
            }
            else {
                discount = price * 0.5;
            }
            price -= discount;
        }
        else {
            price = 35 * accommodation;
            if (accommodation < 10) {
                discount = price * 0.1;
            }
            else if (accommodation >= 10 && accommodation <= 15) {
                discount = price * 0.15;
            }
            else {
                discount = price * 0.2;
            }
            price -= discount;
        }
        if (satisfaction.equals("positive")) {
            price = price + price * 0.25;
        }
        else {
            price = price - price * 0.1;
        }
        System.out.printf("%.2f", price);
    }
}
