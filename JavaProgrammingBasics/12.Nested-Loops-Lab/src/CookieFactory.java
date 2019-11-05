import java.util.Scanner;

public class CookieFactory {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        int batches = Integer.parseInt(myObj.nextLine());
        boolean hasSugar = false;
        boolean hasFlour = false;
        boolean hasEggs = false;
        String ingredient = "";

        for (int i = 1; i <= batches; i++) {
            while (!ingredient.equals("Bake!")) {
                ingredient = myObj.nextLine();
                if (ingredient.equals("Bake!") && (!hasEggs || !hasFlour || !hasSugar)) {
                    System.out.println("The batter should contain flour, eggs and sugar!");
                    ingredient = myObj.nextLine();
                }
                switch (ingredient) {
                    case "sugar":
                        hasSugar = true;
                        break;
                    case "flour":
                        hasFlour = true;
                        break;
                    case "eggs":
                        hasEggs = true;
                        break;
                }
            }
            System.out.println("Baking batch number " + i + "...");
            hasEggs = false;
            hasFlour = false;
            hasSugar = false;
            ingredient = "";
        }
    }
}
