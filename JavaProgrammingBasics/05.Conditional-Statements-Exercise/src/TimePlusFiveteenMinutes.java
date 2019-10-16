import java.util.Scanner;

public class TimePlusFiveteenMinutes {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int hours = Integer.parseInt(myObj.nextLine());
        int minutes = Integer.parseInt(myObj.nextLine());

        minutes += 15;

        if (minutes >= 60) {
            hours = (hours + 1) % 24;
            minutes = minutes % 60;
        }
        if (minutes < 10) {
            System.out.printf("%d:0%d", hours, minutes);
        }
        else {
            System.out.printf("%d:%d", hours, minutes);
        }
    }
}
