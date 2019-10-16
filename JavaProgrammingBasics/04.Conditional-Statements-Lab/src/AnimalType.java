import java.util.Scanner;

public class AnimalType {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);

        String animal = myObj.nextLine();

        switch(animal) {
            case "dog":
                System.out.println("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                System.out.println("reptile");
                break;
            default:
                System.out.println("unknown");
        }
    }
}
