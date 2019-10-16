import java.util.Scanner;

public class AreaOfFigures {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double area;

        String figureType = myObj.nextLine();

        if (figureType.equals("square")) {
            double side = Double.parseDouble(myObj.nextLine());
            area = side * side;
            System.out.printf("%.3f", area);
        }
        else if (figureType.equals("rectangle")) {
            double length = Double.parseDouble(myObj.nextLine());
            double width = Double.parseDouble(myObj.nextLine());
            area = length * width;
            System.out.printf("%.3f", area);
        }
        else if (figureType.equals("circle")) {
            double radius = Double.parseDouble(myObj.nextLine());
            area = Math.PI * radius * radius;
            System.out.printf("%.3f", area);
        }
        else if (figureType.equals("triangle")) {
            double length = Double.parseDouble(myObj.nextLine());
            double height = Double.parseDouble(myObj.nextLine());
            area = length * height / 2;
            System.out.printf("%.3f", area);
        }
    }
}
