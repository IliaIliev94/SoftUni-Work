import java.util.Scanner;

public class Password {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String name = myObj.nextLine();
        String pass = myObj.nextLine();
        String logIn = "";
        while (!pass.equals(logIn)) {
            logIn = myObj.nextLine();
        }
        System.out.printf("Welcome %s!", name);
    }
}
