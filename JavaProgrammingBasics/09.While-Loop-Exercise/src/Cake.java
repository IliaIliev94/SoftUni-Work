import java.util.Scanner;

public class Cake {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int cakeHeight = Integer.parseInt(myObj.nextLine());
        int cakeWidth = Integer.parseInt(myObj.nextLine());
        int cakeSize = cakeHeight * cakeWidth;
        int cakePiece;
        String command = "";
        int counter = 0;
        while (cakeSize > 0) {
            command = myObj.nextLine();
            if (command.equals("STOP")) {
                break;
            }
            cakePiece = Integer.parseInt(command);
            cakeSize -= cakePiece;
        }
        if (command.equals("STOP") && cakeSize > 0) {
            System.out.printf("%d pieces are left.", cakeSize);
        }
        else {
            System.out.printf("No more cake left! You need %d pieces more.", Math.abs(cakeSize));
        }
    }
}
