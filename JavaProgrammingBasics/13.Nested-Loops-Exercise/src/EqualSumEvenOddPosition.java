import java.util.Scanner;

public class EqualSumEvenOddPosition {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int numOne = Integer.parseInt(myObj.nextLine());
        int numTwo = Integer.parseInt(myObj.nextLine());
        String n;
        int sumOdd = 0;
        int sumEven = 0;

        for (int i = numOne; i <= numTwo; i++) {
            n = String.valueOf(i);
            for (int j = 0; j < n.length(); j++) {
                if (j % 2 == 0) {
                    sumOdd += Character.getNumericValue(n.charAt(j));
                }
                else {
                    sumEven += Character.getNumericValue(n.charAt(j));
                }
            }
            if (sumEven == sumOdd) {
                System.out.print(n + " ");
            }
            sumEven = 0;
            sumOdd = 0;
        }
    }
}
