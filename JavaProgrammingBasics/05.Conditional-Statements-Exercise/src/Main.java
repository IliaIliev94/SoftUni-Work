import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
	    Scanner myObj = new Scanner(System.in);
	    int one = Integer.parseInt(myObj.nextLine());
	    int two = Integer.parseInt(myObj.nextLine());
	    int three = Integer.parseInt(myObj.nextLine());

	    int minutes = (one + two + three) / 60;
	    int seconds = (one + two + three) % 60;

	    if (seconds < 10) {
	        System.out.println(minutes + ":0" + seconds);
        }
	    else {
	        System.out.println(minutes + ":" + seconds);
        }
    }
}
