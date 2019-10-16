import java.util.Scanner;

public class VowelsSum {

    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        String textName = myObj.nextLine();
        int sum = 0;
        char isBowel;
        for (int i = 0; i < textName.length(); i++) {
            isBowel = textName.charAt(i);
            switch (isBowel) {
                case 'a':
                    sum += 1;
                    break;
                case 'e':
                    sum += 2;
                    break;
                case 'i':
                    sum += 3;
                    break;
                case 'o':
                    sum += 4;
                    break;
                case 'u':
                    sum += 5;
            }
        }
        System.out.println(sum);
    }
}
