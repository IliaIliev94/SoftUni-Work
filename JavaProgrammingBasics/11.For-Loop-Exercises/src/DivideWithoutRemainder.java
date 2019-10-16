import java.util.Scanner;

public class DivideWithoutRemainder {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        int num;
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;

        for (int i = 0; i < n; i++) {
            num = Integer.parseInt(myObj.nextLine());
            if (num % 2 == 0) {
                p1++;
            }
            if (num % 3 == 0) {
                p2++;
            }
            if (num % 4 == 0) {
                p3++;
            }
        }
        System.out.printf("%.2f%%\n", p1/n * 100);
        System.out.printf("%.2f%%\n", p2/n * 100);
        System.out.printf("%.2f%%", p3/n * 100);
    }
}
