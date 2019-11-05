import java.util.Scanner;

public class Building {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int floors = Integer.parseInt(myObj.nextLine()) * 10;
        int rooms = Integer.parseInt(myObj.nextLine());

        for (int i = floors; i >= 10; i -= 10) {
            for (int j = 0; j < rooms; j++) {
                if (i == floors) {
                    System.out.printf("L%d ", i + j);
                }
                else if (i/10 % 2 != 0) {
                    System.out.printf("A%d ", i + j);
                }
                else {
                    System.out.printf("O%d ", i + j);
                }
            }
            System.out.println();
        }
    }
}
