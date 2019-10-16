package com.company;
import java.util.Scanner;

public class aquarium {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        int length = Integer.parseInt(myObj.nextLine());
        int width = Integer.parseInt(myObj.nextLine());
        int height = Integer.parseInt(myObj.nextLine());
        double percent = Double.parseDouble(myObj.nextLine());

        int aquariumVolume = height * width * length;
        double aquariumTotalLitres = aquariumVolume * 0.001;
        double aquariumPercent = percent * 0.01;
        double totalLitres = aquariumTotalLitres * (1 - aquariumPercent);
        System.out.printf("%.3f", totalLitres);
    }
}
