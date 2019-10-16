import java.util.Scanner;

public class OddEvenSum {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        int num;
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < n; i++) {
            num = Integer.parseInt(myObj.nextLine());
            if (i % 2 == 0) {
                sum1 += num;
            }
            else {
                sum2 += num;
            }
        }
        if (sum1 == sum2) {
            System.out.println("Yes");
            System.out.printf("Sum = %d", sum1);
        }
        else {
            System.out.println("No");
            System.out.printf("Diff = %d", Math.abs(sum1 - sum2));
        }
    }
}
