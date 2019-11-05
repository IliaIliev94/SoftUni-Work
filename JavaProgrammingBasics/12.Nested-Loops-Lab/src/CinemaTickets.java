import java.util.Scanner;

public class CinemaTickets {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        String movieName = myObj.nextLine();
        int freePlaces;
        String ticketType = "";
        int studentTickets = 0;
        int standardTickets = 0;
        int kidTickets = 0;
        double totalTickets = 0;

        while (!movieName.equals("Finish")) {
            freePlaces = Integer.parseInt(myObj.nextLine());
            ticketType = myObj.nextLine();
            while (!ticketType.equals("End")) {
                if (ticketType.equals("student")) {
                    studentTickets++;
                }
                else if (ticketType.equals("standard")) {
                    standardTickets++;
                }
                else {
                    kidTickets++;
                }
                totalTickets++;
                if (totalTickets == freePlaces) {
                    break;
                }
                ticketType = myObj.nextLine();
            }
            System.out.printf("%s - %.2f%% full.%n", movieName, totalTickets/freePlaces * 100);
            totalTickets = 0;
            movieName = myObj.nextLine();
        }
        totalTickets = studentTickets + standardTickets + kidTickets;
        System.out.printf("Total tickets: %.0f%n", totalTickets);
        System.out.printf("%.2f%% student tickets.%n", studentTickets/totalTickets * 100);
        System.out.printf("%.2f%% standard tickets.%n", standardTickets/totalTickets * 100);
        System.out.printf("%.2f%% kids tickets.%n", kidTickets/totalTickets * 100);
    }
}
