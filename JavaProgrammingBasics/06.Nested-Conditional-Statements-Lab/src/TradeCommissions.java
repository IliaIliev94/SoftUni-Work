import java.util.Scanner;

public class TradeCommissions {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String city = myObj.nextLine();
        double sales = Double.parseDouble(myObj.nextLine());
        double commision = 0;
        if (city.equals("Sofia")) {
            if (sales >= 0 && sales <= 500) {
                commision = 0.05;
            }
            else if (sales > 500 && sales <= 1000) {
                commision = 0.07;
            }
            else if (sales > 1000 && sales <= 10000) {
                commision = 0.08;
            }
            else if (sales > 10000) {
                commision = 0.12;
            }
            else {
                System.out.println("error");
                return;
            }
        }
        else if (city.equals("Varna")) {
            if (sales >= 0 && sales <= 500) {
                commision = 0.045;
            }
            else if (sales > 500 && sales <= 1000) {
                commision = 0.075;
            }
            else if (sales > 1000 && sales <= 10000) {
                commision = 0.1;
            }
            else if (sales > 10000) {
                commision = 0.13;
            }
            else {
                System.out.println("error");
                return;
            }
        }
        else if (city.equals("Plovdiv")) {
            if (sales >= 0 && sales <= 500) {
                commision = 0.055;
            }
            else if (sales > 500 && sales <= 1000) {
                commision = 0.08;
            }
            else if (sales > 1000 && sales <= 10000) {
                commision = 0.12;
            }
            else if (sales > 10000) {
                commision = 0.145;
            }
            else {
                System.out.println("error");
                return;
            }
        }
        else {
            System.out.println("error");
            return;
        }
        double sum = sales * commision;
        System.out.printf("%.2f", sum);
    }
}
