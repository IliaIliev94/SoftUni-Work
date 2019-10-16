package com.company;
import java.util.Scanner;

public class circle {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        double radius = Double.parseDouble(myObj.nextLine());
        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;
        System.out.printf("%.2f\n%.2f", area, perimeter);
    }
}
