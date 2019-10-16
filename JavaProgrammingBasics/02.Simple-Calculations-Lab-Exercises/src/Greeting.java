package com.company;
import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner myObj = new Scanner(System.in);
		String firstName = myObj.nextLine();
		String lastName = myObj.nextLine();
		int age = Integer.parseInt(myObj.nextLine());
		String city = myObj.nextLine();

		System.out.printf("You are %s %s, a %d-years old person from %s", firstName, lastName, age, city);
	}
}

