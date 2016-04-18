package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class OddAndEvenPairs {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] splitInput = input.split(" ");

        while (splitInput.length % 2 != 0) {
            System.out.println("Invalid length");
            input = sc.nextLine();
            splitInput = input.split(" ");
        }
        for (int i = 0; i < splitInput.length - 1; i+= 2) {
            int firstNumber = Integer.parseInt(splitInput[i]);
            int secondNumber = Integer.parseInt(splitInput[i + 1]);
            if ((firstNumber + secondNumber) % 2 != 0) {
                System.out.printf("%d, %d -> different", firstNumber, secondNumber);
                System.out.println();
            }
            else {
                if (firstNumber % 2 == 0){
                    System.out.printf("%d, %d -> both are even", firstNumber, secondNumber);
                    System.out.println();
                }
                else {
                    System.out.printf("%d, %d -> both are odd", firstNumber, secondNumber);
                    System.out.println();
                }
            }
        }
    }
}
