import java.util.Scanner;

public class MaxNumber {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int numbersCount = Integer.parseInt(myObj.nextLine());
        int largestNumber = 0;
        int num;
        int counter = 0;
        while (counter < numbersCount) {
            num = Integer.parseInt(myObj.nextLine());
            if (num > largestNumber || counter == 0) {
                largestNumber = num;
            }
            counter++;
        }
        System.out.println(largestNumber);
    }
}
