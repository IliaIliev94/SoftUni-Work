import java.util.Scanner;

public class BonusPoints {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int num = Integer.parseInt(myObj.nextLine());
        double bonus = 0;

        if (num <= 100) {
            bonus = 5;
        }
        else if (num > 100 && num < 1000){
            bonus = num * 0.20;
        }
        else {
            bonus = num * 0.10;
        }

        if (num % 2 == 0) {
            bonus += 1;
        }
        if (num % 10 == 5) {
            bonus += 2;
        }

        System.out.println(bonus);
        System.out.println(bonus + num);
    }
}
