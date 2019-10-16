import java.util.Scanner;

public class OddEvenPosition {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        double num;
        double oddSum = 0;
        double oddMin = Double.MAX_VALUE;
        double oddMax = -Double.MAX_VALUE;
        double evenSum = 0;
        double evenMin = Double.MAX_VALUE;
        double evenMax = -Double.MAX_VALUE;

        for (int i = 1; i <= n; i++) {
            num = Double.parseDouble(myObj.nextLine());
            if (i % 2 == 0) {
                evenSum += num;
                if (num > evenMax) {
                    evenMax = num;
                }
                if (num < evenMin) {
                    evenMin = num;
                }
            }
            else {
                oddSum += num;
                if (num > oddMax) {
                    oddMax = num;
                }
                if (num < oddMin) {
                    oddMin = num;
                }
            }
        }
        System.out.printf("OddSum=%.2f,\n",oddSum);
        if (oddMin != Double.MAX_VALUE) {
            System.out.printf("OddMin=%.2f,\n", oddMin);
        }
        else {
            System.out.println("OddMin=No,");
        }

        if (oddMax != -Double.MAX_VALUE) {
            System.out.printf("OddMax=%.2f,\n", oddMax);
        }
        else {
            System.out.println("OddMax=No,");
        }

        System.out.printf("EvenSum=%.2f,\n", evenSum);
        if (evenMin != Double.MAX_VALUE) {
            System.out.printf("EvenMin=%.2f,\n", evenMin);
        }
        else {
            System.out.println("EvenMin=No,");
        }

        if (evenMax != -Double.MAX_VALUE) {
            System.out.printf("EvenMax=%.2f", evenMax);
        }
        else {
            System.out.println("EvenMax=No");
        }
    }
}
