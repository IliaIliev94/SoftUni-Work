import java.util.Scanner;

public class GreaterNumber {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);

        int first = Integer.parseInt(myObj.nextLine());
        int second = Integer.parseInt(myObj.nextLine());

        if (first > second) {
            System.out.println(first);
        }
        else {
            System.out.println(second);
        }
    }
}
