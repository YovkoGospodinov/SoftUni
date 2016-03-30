package com.company;

import java.util.Scanner;

public class P04LongestIncSequence {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] splittedInput = input.split(" ");
        int[] numbers = new int[splittedInput.length];

        int maxLength = 1;
        int currentLength = 1;
        int longestSeqStartPos = 0;
        int longestSeqEndPos = 0;

        for (int i = 0; i < splittedInput.length; i++) {
            numbers[i] = Integer.parseInt(splittedInput[i]);
        }
        System.out.print(numbers[0]);
        for (int i = 0; i < numbers.length - 1; i++) {
            if (numbers[i] < numbers[i + 1]) {
                System.out.printf(" " + numbers[i + 1]);
                currentLength++;
                if (currentLength > maxLength) {
                    maxLength = currentLength;
                    longestSeqEndPos = i + 1;
                    if (longestSeqEndPos > i) {
                        longestSeqStartPos = (longestSeqEndPos - currentLength) + 1;
                    }
                }
            } else {
                System.out.println();
                System.out.print(numbers[i + 1]);
                currentLength = 1;
            }
        }
        System.out.println();

        System.out.print("Longest: ");
        for (int i = longestSeqStartPos; i <= longestSeqEndPos; i++) {
            System.out.printf(" " + numbers[i]);
        }
    }
}
