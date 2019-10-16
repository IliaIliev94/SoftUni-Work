import java.util.Scanner;

public class SwimmingRecord {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double record = Double.parseDouble(myObj.nextLine());
        double distance = Double.parseDouble(myObj.nextLine());
        double timePerMeter = Double.parseDouble(myObj.nextLine());

        double timeNeeded = timePerMeter * distance;
        double bonusTime = Math.floor((distance / 15)) * 12.5;
        double totalTime = timeNeeded + bonusTime;


        if (totalTime < record) {
            System.out.printf("Yes, he succeeded! The new world record is %.2f seconds.", totalTime);
        }
        else {
            System.out.printf("No, he failed! He was %.2f seconds slower.", totalTime - record);
        }
    }
}
