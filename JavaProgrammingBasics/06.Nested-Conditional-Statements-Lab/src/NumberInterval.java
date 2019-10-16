import java.util.Scanner;

public class NumberInterval {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int num = Integer.parseInt(myObj.nextLine());

        if (num >= -100 && num <= 100 && num != 0) {
                System.out.println("Yes");
        }
        else {
            System.out.println("No");
        }
    }
}
