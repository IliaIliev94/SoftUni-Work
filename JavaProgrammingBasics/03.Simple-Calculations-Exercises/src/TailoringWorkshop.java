import java.util.Scanner;

public class TailoringWorkshop {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int rectangularTables = Integer.parseInt(myObj.nextLine());
        double rectangularTablesLength = Double.parseDouble(myObj.nextLine());
        double rectangularTablesWidth = Double.parseDouble(myObj.nextLine());
        double tableclothArea = rectangularTables * (rectangularTablesLength + 2 * 0.30) * (rectangularTablesWidth + 2 * 0.30);
        double quadsArea = rectangularTables * (rectangularTablesLength / 2) * (rectangularTablesLength / 2);
        double USDPrice = tableclothArea * 7 + quadsArea * 9;
        double BGNPrice = USDPrice * 1.85;
        System.out.printf("%.2f USD\n%.2f BGN", USDPrice, BGNPrice);

    }
}
