import java.util.Scanner;

public class LeftAndRightSum {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine()) * 2;
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < n; i++) {
            if (i < n/2) {
                sum1 += Integer.parseInt(myObj.nextLine());
            }
            else {
                sum2 += Integer.parseInt(myObj.nextLine());
            }
        }
        if (sum1 == sum2) {
            System.out.printf("Yes, sum = %d", sum1);
        }
        else {
            System.out.printf("No, diff = %d", Math.abs(sum1 - sum2));
        }
    }
}
