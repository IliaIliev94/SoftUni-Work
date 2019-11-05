import java.util.Scanner;

public class NumberPyramid {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int n = Integer.parseInt(myObj.nextLine());
        int count = 1;

        outer:
        for (int rows = 1; rows <= n; rows++) {
            for (int columns = 1; columns <= rows; columns++) {
                System.out.print(count + " ");
                count++;
                if (count > n) {
                    break outer;
                }
            }
            System.out.println();
        }
    }
}
