import java.util.Scanner;

public class Cinema {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String projectionType = myObj.nextLine();
        int rows = Integer.parseInt(myObj.nextLine());
        int columns = Integer.parseInt(myObj.nextLine());
        double price = 0;
        if (projectionType.equals("Premiere")) {
            price = 12;
        }
        else if (projectionType.equals("Normal")) {
            price = 7.50;
        }
        else {
            price = 5;
        }
        double sum = price * rows * columns;
        System.out.printf("%.2f leva", sum);
    }
}
