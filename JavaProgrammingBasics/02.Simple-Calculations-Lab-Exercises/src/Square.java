package com.company;
import java.util.Scanner;

public class square {
    public static void main (String[] args) {
        Scanner myObj = new Scanner(System.in);
        int side = Integer.parseInt(myObj.nextLine());
        System.out.print(side * side);
    }
}
