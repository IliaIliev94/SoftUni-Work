import java.util.Scanner;

public class EqualSumsLeftRightPosition {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int numOne = Integer.parseInt(myObj.nextLine());
        int numTwo = Integer.parseInt(myObj.nextLine());
        int sumLeft = 0;
        int sumRight = 0;
        int sumMiddle = 0;
        int n;

        for (int i = numOne; i <= numTwo; i++) {
            n = i;
            for (int j = 0; n > 0; j++) {
                if (j == 0 || j == 1) {
                    sumLeft += n % 10;
                    n /= 10;
                }
                else if (j == 3 || j == 4) {
                    sumRight += n % 10;
                    n /= 10;
                }
                else {
                    sumMiddle += n % 10;
                    n /= 10;
                }
            }
            if (sumLeft == sumRight) {
                System.out.print(i + " ");
            }
            else {
                if (sumLeft > sumRight) {
                    sumRight += sumMiddle;
                    if (sumLeft == sumRight) {
                        System.out.print(i + " ");
                    }
                }
                else {
                    sumLeft += sumMiddle;
                    if (sumLeft == sumRight) {
                        System.out.print(i + " ");
                    }
                }
            }
            sumLeft = 0;
            sumRight = 0;
            sumMiddle = 0;
        }
    }
}
