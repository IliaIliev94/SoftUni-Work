import java.util.Scanner;

public class GuessPassword {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);

        String password = myObj.nextLine();

        if (password.equals("s3cr3t!P@ssw0rd")) {
            System.out.println("Welcome");
        }
        else {
            System.out.println("Wrong password!");
        }
    }
}
