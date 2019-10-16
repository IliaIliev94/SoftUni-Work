import java.util.Scanner;

public class PointOnRectangleBorder {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        double x1 = Double.parseDouble(myObj.nextLine());
        double y1 = Double.parseDouble(myObj.nextLine());
        double x2 = Double.parseDouble(myObj.nextLine());
        double y2 = Double.parseDouble(myObj.nextLine());
        double x = Double.parseDouble(myObj.nextLine());
        double y = Double.parseDouble(myObj.nextLine());

        if ((x == x1 || x == x2) && (y >= y1 && y <= y2) || (y == y1 || y == y2) && (x >= x1 && x <= x2)) {
            System.out.println("Border");
        }
        else {
            System.out.println("Inside / Outside");
        }
    }
}
