package com.company;
import java.util.Scanner;

public class Projects {
    public static void main(String[] args) {
        Scanner myObj = new Scanner(System.in);
        String name = myObj.nextLine();
        int projects = Integer.parseInt(myObj.nextLine());
        int projectHours = projects * 3;

        System.out.printf("The architect %s will need %d hours to complete %d project/s.", name, projectHours, projects);

    }
}
