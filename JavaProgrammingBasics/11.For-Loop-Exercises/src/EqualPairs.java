import java.util.Scanner;

public class EqualPairs {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        int sum1 = 0;
        int sum2 = 0;
        int maxDifference = 0;

        for (int i = 0; i < n; i++) {
            sum1 = Integer.parseInt(myObj.nextLine()) + Integer.parseInt(myObj.nextLine());
            if (sum1 != sum2 && i > 0) {
                if (Math.abs(sum1 - sum2) > maxDifference) {
                    maxDifference = Math.abs(sum1 - sum2);
                }
            }
            sum2 = sum1;
        }
        if (maxDifference == 0) {
            System.out.printf("Yes, value=%d", sum1);
        }
        else {
            System.out.printf("No, maxdiff=%d", maxDifference);
        }
    }
}
