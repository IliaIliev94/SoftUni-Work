package com.company;
import  java.util.Scanner;

public class dogs {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int dogs = Integer.parseInt(myObj.nextLine());
        int otherAnimals = Integer.parseInt(myObj.nextLine());
        double totalCost = dogs * 2.50 + otherAnimals * 4;
        System.out.printf("%.2f lv.", totalCost);
    }
}
