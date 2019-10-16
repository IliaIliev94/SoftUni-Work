package com.company;
import java.util.Scanner;

public class garden {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double area = Double.parseDouble(myObj.nextLine());

        double initialPrice = area * 7.61;
        double discount = initialPrice * 0.18;
        double finalPrice = initialPrice - discount;

        System.out.printf("The final price is: %.2f lv.\n", finalPrice);
        System.out.printf("The discount is: %.2f lv.", discount);
    }
}
