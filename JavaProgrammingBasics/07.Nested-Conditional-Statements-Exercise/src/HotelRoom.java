import java.util.Scanner;

public class HotelRoom {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String month = myObj.nextLine();
        int accommodation = Integer.parseInt(myObj.nextLine());
        double apartmentPrice = 0;
        double studioPrice = 0;

        if (month.equals("May") || month.equals("October")) {
            apartmentPrice = 65 * accommodation;
            studioPrice = 50 * accommodation;
            if (accommodation > 14) {
                studioPrice = studioPrice - studioPrice * 0.30;
            }
            else if (accommodation > 7) {
                studioPrice = studioPrice - studioPrice * 0.05;
            }
        }
        else if (month.equals("June") || month.equals("September")) {
            apartmentPrice = 68.70 * accommodation;
            studioPrice = 75.20 * accommodation;
            if (accommodation > 14) {
                studioPrice = studioPrice - studioPrice * 0.2;
            }
        }
        else {
            apartmentPrice = 77 * accommodation;
            studioPrice = 76 * accommodation;
        }
        if (accommodation > 14) {
            apartmentPrice = apartmentPrice - apartmentPrice * 0.1;
        }
        System.out.printf("Apartment: %.2f lv.\nStudio: %.2f lv.", apartmentPrice, studioPrice);
    }
}
