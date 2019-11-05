import java.util.Scanner;

public class ChristmasDecoration {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int budget = Integer.parseInt(myObj.nextLine());
        String command = myObj.nextLine();
        int sum = 0;
        while (!command.equals("Stop")) {
            for (int i = 0; i < command.length(); i++) {
                sum += (int) command.charAt(i);
            }
            if (sum > budget) {
                System.out.println("Not enough money!");
                break;
            }
            System.out.println("Item successfully purchased!");
            budget -= sum;
            sum = 0;
            command = myObj.nextLine();
        }
        if (command.equals("Stop")) {
            System.out.printf("Money left: %d", budget);
        }

    }
}
