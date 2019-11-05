import java.util.Scanner;

public class BachelorParty {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int sumSinger = Integer.parseInt(myObj.nextLine());
        String command = myObj.nextLine();
        int reservation = 0;
        int guests;
        int totalGuests = 0;

        while (!command.equals("The restaurant is full")) {
            guests = Integer.parseInt(command);
            if (guests < 5) {
                reservation += guests * 100;
            }
            else {
                reservation += guests * 70;
            }
            totalGuests += guests;
            command = myObj.nextLine();
        }
        if (reservation >= sumSinger) {
            System.out.printf("You have %d guests and %d leva left.", totalGuests, reservation - sumSinger);
        }
        else {
            System.out.printf("You have %d guests and %d leva income, but no singer.", totalGuests, reservation);
        }
    }
}
