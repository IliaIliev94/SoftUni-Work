package com.company;
import java.util.Scanner;

public class InchesToCm {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double inches = Double.parseDouble(myObj.nextLine());
        System.out.printf("%.2f", inches * 2.54);
    }
}
