import java.util.Scanner;

public class Matrix {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int a = Integer.parseInt(myObj.nextLine());
        int b = Integer.parseInt(myObj.nextLine());
        int c = Integer.parseInt(myObj.nextLine());
        int d = Integer.parseInt(myObj.nextLine());

        for (int i = a; i <= b; i++) {
            for (int j = a; j <= b; j++) {
                for (int k = c; k <= d; k++) {
                    for (int l = c; l <= d; l++) {
                        if (i + l == j + k && (i != j && k != l)) {
                            System.out.println(i + "" + j);
                            System.out.println(k + "" + l);
                            System.out.println();
                        }
                    }
                }
            }
        }
    }
}
