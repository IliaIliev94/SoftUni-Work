import java.util.Scanner;

public class WorldSnookerChampionship {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        String championshipStage = myObj.nextLine();
        String ticketType = myObj.nextLine();
        int tickets = Integer.parseInt(myObj.nextLine());
        char trophyPicture = myObj.nextLine().charAt(0);

        double ticketPrice;

        if (championshipStage.equals("Quarter final")) {
            switch (ticketType) {
                case "Standard":
                    ticketPrice = 55.50;
                    break;
                case "Premium":
                    ticketPrice = 105.20;
                    break;
                default:
                    ticketPrice = 118.90;
            }
        }
        else if (championshipStage.equals("Semi final")) {
            switch (ticketType) {
                case "Standard":
                    ticketPrice = 75.88;
                    break;
                case "Premium":
                    ticketPrice = 125.22;
                    break;
                default:
                    ticketPrice = 300.40;
            }
        }
        else {
            switch (ticketType) {
                case "Standard":
                    ticketPrice = 110.10;
                    break;
                case "Premium":
                    ticketPrice = 160.66;
                    break;
                default:
                    ticketPrice = 400;
            }
        }
        ticketPrice *= tickets;

        if (ticketPrice > 4000) {
            ticketPrice -= ticketPrice * 0.25;
        }
        else {
            if (ticketPrice > 2500) {
                ticketPrice -= ticketPrice * 0.10;
            }
            if (trophyPicture == 'Y') {
                ticketPrice += tickets * 40;
            }
        }
        System.out.printf("%.2f", ticketPrice);
    }
}
