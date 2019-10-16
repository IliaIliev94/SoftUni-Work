import java.util.Scanner;

public class Vacation {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double tripMoney = Double.parseDouble(myObj.nextLine());
        double currentMoney = Double.parseDouble(myObj.nextLine());
        int daysSpending = 0;
        String action = "";
        double amount;
        int counter = 0;
        while (daysSpending < 5 && currentMoney < tripMoney) {
            action = myObj.nextLine();
            amount = Double.parseDouble(myObj.nextLine());
            if (action.equals("save")) {
                daysSpending = 0;
                currentMoney += amount;
            }
            else {
                currentMoney -= amount;
                if (currentMoney < 0) {
                    currentMoney = 0;
                }
                daysSpending++;
            }
            counter++;
        }
        if (daysSpending < 5) {
            System.out.printf("You saved the money for %d days.", counter);
        }
        else {
            System.out.println("You can't save the money.");
            System.out.println(counter);
        }
    }
}
