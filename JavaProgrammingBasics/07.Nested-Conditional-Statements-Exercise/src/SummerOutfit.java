import java.util.Scanner;

public class SummerOutfit {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int degrees = Integer.parseInt(myObj.nextLine());
        String dayTime = myObj.nextLine();
        String outfit;
        String shoes;
        if (degrees >= 10 && degrees <= 18) {
            switch (dayTime) {
                case "Morning":
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    break;
                case "Afternoon":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
                default:
                    outfit = "Shirt";
                    shoes = "Moccasins";
            }
        }
        else if (degrees > 18 && degrees <= 24) {
            switch (dayTime) {
                case "Morning":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
                case "Afternoon":
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    break;
                default:
                    outfit = "Shirt";
                    shoes = "Moccasins";
            }
        }
        else {
            switch (dayTime) {
                case  "Morning":
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    break;
                case "Afternoon":
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    break;
                default:
                    outfit = "Shirt";
                    shoes = "Moccasins";
            }
        }
        System.out.printf("It's %d degrees, get your %s and %s.", degrees, outfit, shoes);
    }
}
