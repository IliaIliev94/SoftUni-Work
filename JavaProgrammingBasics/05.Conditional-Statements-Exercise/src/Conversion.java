import java.util.Scanner;

public class Conversion {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double num = Double.parseDouble(myObj.nextLine());
        String inputMetric = myObj.nextLine();
        String outputMetric = myObj.nextLine();

        if (inputMetric.equals("mm")) {
            num = num / 1000;
        }
        else if (inputMetric.equals("cm")) {
            num = num / 100;
        }

        if (outputMetric.equals("mm")) {
            num = num * 1000;
        }
        else if (outputMetric.equals("cm")) {
            num = num * 100;
        }

        System.out.printf("%.3f", num);
    }
}
