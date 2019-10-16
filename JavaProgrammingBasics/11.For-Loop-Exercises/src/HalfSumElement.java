import java.util.Scanner;

public class HalfSumElement {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        int num;
        int largestNumber = Integer.MIN_VALUE;
        int sum = 0;

        for (int i = 0; i < n; i++) {
            num = Integer.parseInt(myObj.nextLine());
            if (num > largestNumber) {
                largestNumber = num;
            }
            sum += num;
        }
        sum -= largestNumber;
        if (sum == largestNumber) {
            System.out.println("Yes");
            System.out.printf("Sum = %d", largestNumber);
        }
        else {
            System.out.println("No");
            System.out.printf("Diff = %d", Math.abs(sum - largestNumber));
        }
    }
}
