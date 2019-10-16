import java.util.Scanner;

public class RectangleAreaAndPerimeter {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double x1 = Double.parseDouble(myObj.nextLine());
        double y1 = Double.parseDouble(myObj.nextLine());
        double x2 = Double.parseDouble(myObj.nextLine());
        double y2 = Double.parseDouble(myObj.nextLine());

        double length = Math.abs(x2 - x1);
        double width = Math.abs(y2 - y1);

        double area = length * width;
        double perimeter = 2 * (length + width);

        System.out.printf("%.2f\n%.2f", area, perimeter);
    }
}
