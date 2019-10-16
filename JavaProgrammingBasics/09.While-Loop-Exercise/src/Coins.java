import java.util.Scanner;

public class Coins {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double change = Double.parseDouble(myObj.nextLine());
        int leva = (int) change;
        int stotinki = (int) (change * 100) % 100;
        int counter = 0;
        while (leva > 0) {
            if (leva >= 2) {
                leva -= 2;
            }
            else {
                leva -= 1;
            }
            counter++;
        }
        while (stotinki > 0) {
            if (stotinki >= 50) {
                stotinki -= 50;
            }
            else if (stotinki >= 20) {
                stotinki -= 20;
            }
            else if (stotinki >= 10) {
                stotinki -= 10;
            }
            else if (stotinki >= 5) {
                stotinki -= 5;
            }
            else if (stotinki >= 2) {
                stotinki -= 2;
            }
            else {
                stotinki -= 1;
            }
            counter++;
        }
        System.out.println(counter);
    }
}
