import java.util.Scanner;

public class Sequence2kPlus1 {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int num = Integer.parseInt(myObj.nextLine());
        int k = 1;
        while (k <= num) {
            System.out.println(k);
            k = 2 * k + 1;
        }
    }
}
