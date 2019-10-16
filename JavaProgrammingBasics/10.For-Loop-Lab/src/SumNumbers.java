import java.util.Scanner;

public class SumNumbers {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int numberCount = Integer.parseInt(myObj.nextLine());
        int sum = 0;

        for (int i = 0; i < numberCount; i++) {
            sum += Integer.parseInt(myObj.nextLine());
        }
        System.out.println(sum);
    }
}
