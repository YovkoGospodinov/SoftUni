package com.company;

import java.util.Scanner;

public class P02SequenceEqualStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] splittedInput = input.split(" ");

        System.out.print(splittedInput[0]);

        for (int i = 1; i < splittedInput.length; i++) {
            boolean isEqual = splittedInput[i].equals(splittedInput[i - 1]);
            if (isEqual) {
                System.out.print(" " + splittedInput[i]);
            } else {
                System.out.println();
                System.out.print(splittedInput[i]);
            }
        }
    }
}