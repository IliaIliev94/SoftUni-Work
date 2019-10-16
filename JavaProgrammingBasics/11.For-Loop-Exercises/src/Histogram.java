import java.util.Scanner;

public class Histogram {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        int num;
        double p1 = 0;
        double p2 = 0;
        double p3 = 0;
        double p4 = 0;
        double p5 = 0;

        for (int i = 0; i < n; i++) {
            num = Integer.parseInt(myObj.nextLine());
            if (num < 200) {
                p1++;
            }
            else if (num >= 200 && num <= 399) {
                p2++;
            }
            else if (num >= 400 && num <= 599) {
                p3++;
            }
            else if (num >= 600 && num <= 799) {
                p4++;
            }
            else {
                p5++;
            }
        }
        System.out.printf("%.2f%%\n", p1/n * 100);
        System.out.printf("%.2f%%\n", p2/n * 100);
        System.out.printf("%.2f%%\n", p3/n * 100);
        System.out.printf("%.2f%%\n", p4/n * 100);
        System.out.printf("%.2f%%", p5/n * 100);
    }
}
