import java.util.Scanner;

public class CharityCampaign {

    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);

        int campaignDuration = Integer.parseInt(myObj.nextLine());
        int bakers = Integer.parseInt(myObj.nextLine());
        int cakes = Integer.parseInt(myObj.nextLine());
        int corrugations = Integer.parseInt(myObj.nextLine());
        int pancakes = Integer.parseInt(myObj.nextLine());

        double cakesSum = cakes * 45;
        double corrugationsSum = corrugations * 5.80;
        double pancakesSum = pancakes * 3.20;

        double dailySum = (cakesSum + corrugationsSum + pancakesSum) * bakers;
        double campaignSum = dailySum * campaignDuration;
        double profit = campaignSum - (campaignSum * 1/8);
        System.out.printf("%.2f", profit);
    }
}
