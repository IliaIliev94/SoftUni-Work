import java.util.Scanner;

public class DancingHall {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double hallLength = Double.parseDouble(myObj.nextLine());
        double hallWidth = Double.parseDouble(myObj.nextLine());
        double wardrobeSide = Double.parseDouble(myObj.nextLine());

        double hallArea = (hallLength * 100) * (hallWidth * 100);
        double wardrobeArea = (wardrobeSide * 100) * (wardrobeSide * 100);
        double benchArea = hallArea / 10;
        double freeSpace = hallArea - wardrobeArea - benchArea;
        double dancers = Math.floor(freeSpace / (40 + 7000));
        System.out.printf("%.0f", dancers);

    }
}
