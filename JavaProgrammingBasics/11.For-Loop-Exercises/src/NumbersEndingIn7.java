import java.util.Scanner;

public class NumbersEndingIn7 {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        for (int i = 7; i <= 1000; i += 10) {
            System.out.println(i);
        }
    }
}
