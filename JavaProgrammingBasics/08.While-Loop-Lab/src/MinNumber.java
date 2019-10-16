import java.util.Scanner;

public class MinNumber {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int numCount = Integer.parseInt(myObj.nextLine());
        int counter = 0;
        int smallestNumber = 0;
        int num;
        while (counter < numCount) {
            num = Integer.parseInt(myObj.nextLine());
            if (num < smallestNumber || counter == 0) {
                smallestNumber = num;
            }
            counter ++;
        }
        System.out.println(smallestNumber);
    }
}
