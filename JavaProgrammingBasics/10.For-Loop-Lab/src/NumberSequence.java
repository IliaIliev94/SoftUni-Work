import java.util.Scanner;

public class NumberSequence {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int numCount = Integer.parseInt(myObj.nextLine());
        int min = Integer.MAX_VALUE;
        int max = Integer.MIN_VALUE;
        int num;

        for (int i = 0; i < numCount; i++) {
            num = Integer.parseInt(myObj.nextLine());
            if (num < min) {
                min = num;
            }
            if (num > max) {
                max = num;
            }
        }
        System.out.printf("Max number: %d\n", max);
        System.out.printf("Min number: %d", min);
    }
}
