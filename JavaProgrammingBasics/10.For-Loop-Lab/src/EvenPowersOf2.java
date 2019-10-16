import java.util.Scanner;

public class EvenPowersOf2 {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());

        for (int i = 0; i <= n; i += 2) {
            System.out.println((int) Math.pow(2, i));
        }
    }
}
