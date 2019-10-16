import java.util.Scanner;

public class RadiansDegreesConverter {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double radians = Double.parseDouble(myObj.nextLine());
        double degrees = radians * 180 / Math.PI;
        System.out.printf("%.0f", degrees);
    }
}
