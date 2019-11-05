import java.util.Scanner;

public class SumPrimeNonPrime {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        String command = myObj.nextLine();
        int sumPrime = 0;
        int sumComposite = 0;
        int n;
        boolean isPrime = true;
        while (!command.equals("stop")) {
            n = Integer.parseInt(command);
            if (n < 0) {
                System.out.println("Number is negative.");
            }
            else {
                for (int i = 2; i <= n/2; i++) {
                    if (n % i == 0) {
                        isPrime = false;
                    }
                }
                if (isPrime) {
                    sumPrime += n;
                }
                else {
                    sumComposite += n;
                }
                isPrime = true;
            }
            command = myObj.nextLine();
        }
        System.out.println("Sum of all prime numbers is: " + sumPrime);
        System.out.println("Sum of all non prime numbers is: " + sumComposite);
    }
}
