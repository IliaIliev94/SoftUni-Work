import java.util.Scanner;

public class MovingWithBreak {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int freeSpaceWidth = Integer.parseInt(myObj.nextLine());
        int freeSpaceLength = Integer.parseInt(myObj.nextLine());
        int freeSpaceHeight = Integer.parseInt(myObj.nextLine());
        int totalFreeSpace = freeSpaceHeight * freeSpaceLength * freeSpaceWidth;
        int box = 0;
        int totalUsedSpace = 0;
        String command = "";
        while (!command.equals("Done")) {
            command = myObj.nextLine();
            if (!command.equals("Done")) {
                box = Integer.parseInt(command);
                totalUsedSpace += box;
            }
            if (totalUsedSpace > totalFreeSpace) {
                break;
            }

        }
        if (totalFreeSpace >= totalUsedSpace) {
            System.out.printf("%d Cubic meters left.", totalFreeSpace - totalUsedSpace);
        }
        else {
            System.out.printf("No more free space! You need %d Cubic meters more.", totalUsedSpace - totalFreeSpace);
        }

    }
}
