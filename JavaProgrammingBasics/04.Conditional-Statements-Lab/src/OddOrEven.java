import java.util.Scanner;

public class OddOrEven {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int num = Integer.parseInt(myObj.nextLine());

        if (num % 2 == 0) {
            System.out.println("even");
        }
        else {
            System.out.println("odd");
        }
    }
}
