import java.util.Scanner;

public class SpecialNumbers {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        int digit;
        boolean isSpecial = true;

        for (int i = 1111; i <= 9999; i++) {
            for (int j = i; j > 0; j = j / 10) {
                digit = j % 10;
                if (digit == 0 || n % digit != 0) {
                    isSpecial = false;
                    break;
                }
            }
            if (isSpecial) {
                System.out.print(i + " ");
            }
            isSpecial = true;
        }
    }
}
