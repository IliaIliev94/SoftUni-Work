import java.util.Scanner;

public class USDToBGN {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double USD = Double.parseDouble(myObj.nextLine());
        double BGN = USD * 1.79549;
        System.out.printf("%.2f", BGN);
    }
}
