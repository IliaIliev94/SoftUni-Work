import java.util.Scanner;

public class OnTimeForTheExam {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int examHour = Integer.parseInt(myObj.nextLine());
        int examMinute = Integer.parseInt(myObj.nextLine());
        int arrivalHour = Integer.parseInt(myObj.nextLine());
        int arrivalMinute = Integer.parseInt(myObj.nextLine());
        int minutes = (arrivalHour - examHour) * 60 + arrivalMinute - examMinute;
        if (minutes <= 0 && minutes >= -30) {
            System.out.println("On time");
            if (minutes < 0) {
                System.out.printf("%d minutes before the start", Math.abs(minutes % 60));
            }
        }
        else if (minutes > 0) {
            System.out.println("Late");
            if (minutes / 60 == 0) {
                System.out.printf("%d minutes after the start", minutes % 60);
            }
            else {
                if (minutes % 60 < 10) {
                    System.out.printf("%d:0%d hours after the start", Math.abs(minutes / 60), Math.abs(minutes % 60));
                }
                else {
                    System.out.printf("%d:%d hours after the start", Math.abs(minutes / 60), Math.abs(minutes % 60));
                }
            }
            }
        else {
            System.out.println("Early");
            if (minutes / 60 == 0) {
                System.out.printf("%d minutes before the start", Math.abs(minutes % 60));
            }
            else {
                if (minutes % 60 > -10) {
                    System.out.printf("%d:0%d hours before the start", Math.abs(minutes / 60), Math.abs(minutes % 60));
                }
                else {
                    System.out.printf("%d:%d hours before the start", Math.abs(minutes / 60), Math.abs(minutes % 60));
                }

            }

        }
    }
}
