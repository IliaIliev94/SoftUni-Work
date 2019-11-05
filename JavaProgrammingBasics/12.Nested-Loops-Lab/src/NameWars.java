import java.util.Scanner;

public class NameWars {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        String name;
        int maxName = 0;
        int nameValue;
        String winner = "";

        while (true) {
            nameValue = 0;
            name = myObj.nextLine();
            if (name.equals("STOP")) {
                break;
            }
            for (int i = 0; i < name.length(); i++) {
                nameValue += (int) name.charAt(i);
            }
            if (nameValue > maxName) {
                maxName = nameValue;
                winner = name;
            }
        }
        System.out.printf("Winner is %s - %d!", winner, maxName);
    }
}
