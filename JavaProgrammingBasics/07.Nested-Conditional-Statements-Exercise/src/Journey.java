import java.util.Scanner;

public class Journey {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double budget = Double.parseDouble(myObj.nextLine());
        String season = myObj.nextLine();
        String destination;
        String holidayType;
        double sum;
        if (budget <= 100) {
            destination = "Bulgaria";
            if (season.equals("summer")) {
                sum = budget * 0.3;
                holidayType = "Camp";
            }
            else {
                sum = budget * 0.7;
                holidayType = "Hotel";
            }
        }
        else if (budget <= 1000) {
            destination = "Balkans";
            if (season.equals("summer")) {
                sum = budget * 0.4;
                holidayType = "Camp";
            }
            else {
                sum = budget * 0.8;
                holidayType = "Hotel";
            }
        }
        else {
            sum = budget * 0.9;
            destination = "Europe";
            holidayType = "Hotel";
        }
        System.out.printf("Somewhere in %s\n%s - %.2f", destination, holidayType, sum);
    }
}
