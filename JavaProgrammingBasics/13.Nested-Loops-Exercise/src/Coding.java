import java.util.Scanner;

public class Coding {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int number = Integer.parseInt(myObj.nextLine());
        int digit;
        char symbol;

        while (number > 0) {
            digit = number % 10;
            symbol = (char) (digit + 33);
            if (digit == 0) {
                System.out.print("ZERO");
            }
            else {
                for (int i = 0; i < digit; i++) {
                    System.out.print(symbol);
                }
            }
            System.out.println();
            number = number / 10;
        }

    }
}
