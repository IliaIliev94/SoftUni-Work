import java.util.Scanner;

public class Travelling {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        String country;
        double money;
        double savings = 0;

        while (true) {
            country = myObj.nextLine();
            if (country.equals("End")) {
                break;
            }
            money = Double.parseDouble(myObj.nextLine());
            while (savings < money) {
                savings += Double.parseDouble(myObj.nextLine());
            }
            System.out.println("Going to " + country + '!');
            savings = 0;
        }
    }
}
