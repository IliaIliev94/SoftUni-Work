import java.util.Scanner;

public class Salary {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int openBrowserTabs = Integer.parseInt(myObj.nextLine());
        int salary = Integer.parseInt(myObj.nextLine());
        String website;

        for (int i = 0; i < openBrowserTabs; i++) {
            website = myObj.nextLine();
            if (website.equals("Facebook")) {
                salary -= 150;
            }
            else if (website.equals("Instagram")) {
                salary -= 100;
            }
            else if (website.equals("Reddit")){
                salary -= 50;
            }
            if (salary <= 0) {
                break;
            }
        }
        if (salary > 0) {
            System.out.println(salary);
        }
        else {
            System.out.println("You have lost your salary.");
        }
    }
}
