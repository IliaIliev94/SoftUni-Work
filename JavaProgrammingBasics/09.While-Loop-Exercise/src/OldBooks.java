import java.util.Scanner;

public class OldBooks {
    public static void main(String[] args) {

        Scanner myObj = new Scanner(System.in);
        String favouriteBook = myObj.nextLine();
        int libraryCapacity = Integer.parseInt(myObj.nextLine());
        int counter = 0;
        String book = "";
        boolean isFound = false;
        while (counter < libraryCapacity) {
            book = myObj.nextLine();
            if (book.equals(favouriteBook)) {
                isFound = true;
                break;
            }
            counter++;
        }
        if (isFound) {
            System.out.printf("You checked %d books and found it.", counter);
        }
        else {
            System.out.println("The book you search is not here!");
            System.out.printf("You checked %d books.", counter);
        }
    }
}
