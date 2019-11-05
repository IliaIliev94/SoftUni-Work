import java.util.Scanner;

public class SumOfTwoNumbers {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int intervalStart = Integer.parseInt(myObj.nextLine());
        int intervalEnd = Integer.parseInt(myObj.nextLine());
        int magicNumber = Integer.parseInt(myObj.nextLine());
        boolean isFound = false;
        int counter = 0;
        int i;
        int j = 0;

        outerloop:
        for (i = intervalStart; i <= intervalEnd; i++) {
            for (j = intervalStart; j <= intervalEnd; j++) {
                counter ++;
                if (i + j == magicNumber) {
                    isFound = true;
                    break outerloop;
                }
            }
        }
        if (isFound) {
            System.out.printf("Combination N:%d (%d + %d = %d)", counter, i, j, i + j);
        }
        else {
            System.out.printf("%d combinations - neither equals %d", counter, magicNumber);
        }
    }
}
