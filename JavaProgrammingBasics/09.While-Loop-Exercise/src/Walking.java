import java.util.Scanner;

public class Walking {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int totalSteps = 0;
        int stepsTaken;
        String isGoingHome = "";
        while (totalSteps < 10000) {
            isGoingHome = myObj.nextLine();
            if (isGoingHome.equals("Going home")) {
                totalSteps += Integer.parseInt(myObj.nextLine());
                break;
            }
            totalSteps += Integer.parseInt(isGoingHome);
        }
        if (totalSteps < 10000) {
            System.out.printf("%d more steps to reach goal.", 10000 - totalSteps);
        }
        else {
            System.out.println("Goal reached! Good job!");
        }
    }
}
