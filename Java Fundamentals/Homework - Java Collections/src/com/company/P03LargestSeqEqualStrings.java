package com.company;

import java.util.Scanner;

public class P03LargestSeqEqualStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] splittedInput = input.split(" ");

        int arrayPosition = 0;
        int currentLength = 1;
        int maxLength = 1;

        for (int i = 1; i < splittedInput.length; i++) {
            boolean isEqual = splittedInput[i].equals(splittedInput[i - 1]);
            if (isEqual) {
                currentLength++;
                if (currentLength > maxLength) {
                    maxLength = currentLength;
                    arrayPosition = i;
                }
            }else {
                currentLength = 1;
            }
        }
        for (int i = 0; i < maxLength; i++) {
            System.out.printf(splittedInput[arrayPosition] + " ");
        }
    }
}
