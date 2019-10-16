import java.util.Scanner;

public class Volleyball {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String year = myObj.nextLine();
        int holidays = Integer.parseInt(myObj.nextLine());
        int weekendsToHometown = Integer.parseInt(myObj.nextLine());

        double weekendsSofia = (48 - weekendsToHometown) * 3/4.0;
        double gamesHolidays = holidays * 2/3.0;
        double total = weekendsSofia + gamesHolidays + weekendsToHometown;
        if (year.equals("leap")) {
            total = total + total * 0.15;
        }
        System.out.printf("%.0f", Math.floor(total));
    }
}
