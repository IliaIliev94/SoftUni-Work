import java.util.Scanner;

public class Combinations {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int num = Integer.parseInt(myObj.nextLine());
        int count = 0;

        for (int i = 0; i <= num; i++) {
            for (int j = 0; j <= num; j++) {
                for (int k = 0; k <= num; k++) {
                    if (i + j + k == num) {
                        count++;
                    }
                }
            }
        }
        System.out.println(count);
    }
}
