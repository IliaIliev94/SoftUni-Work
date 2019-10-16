import java.util.Scanner;

public class PersonalTitles {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double age = Double.parseDouble(myObj.nextLine());
        String gender = myObj.nextLine();

        if (gender.equals("m")) {
            if (age >= 16) {
                System.out.println("Mr.");
            }
            else {
                System.out.println("Master");
            }
        }
        else if (gender.equals("f")) {
            if (age >= 16) {
                System.out.println("Ms.");
            }
            else {
                System.out.println("Miss");
            }
        }
    }
}
