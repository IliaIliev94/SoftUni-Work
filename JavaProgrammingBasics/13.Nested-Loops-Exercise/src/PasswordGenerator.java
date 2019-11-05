import java.util.Scanner;

public class PasswordGenerator {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        int L = Integer.parseInt(myObj.nextLine());
        for (int i = 1; i < n; i++) {
            for (int j = 1; j < n; j++) {
                for (char a = 'a'; a < 'a' + (char) L; a++) {
                    for (char b = 'a'; b < 'a' + (char) L; b++) {
                        for (int k = 1; k <= n; k++) {
                            if ( k > i && k > j) {
                                System.out.printf("%d%d%c%c%d ", i, j, a, b, k);
                            }
                        }
                    }
                }
            }
        }
    }
}
