import java.util.Scanner;

public class NumbersNTo1 {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());

        for (int i = n; i > 0; i--) {
            System.out.println(i);
        }
    }
}
