import java.util.Scanner;

public class CharacterSequence {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        String textName = myObj.nextLine();

        for (int i = 0; i < textName.length(); i++) {
            System.out.println(textName.charAt(i));
        }
    }
}
