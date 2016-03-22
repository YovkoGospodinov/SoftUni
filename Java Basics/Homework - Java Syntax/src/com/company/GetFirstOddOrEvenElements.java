package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String firstInputLine = sc.nextLine();
        String secondInputLine = sc.nextLine();
        String[] splitSecondInputLine = secondInputLine.split(" ");

        int n = Integer.parseInt(splitSecondInputLine[1]);

        List<Integer> outputNumbers = getOddOrEvenNumbers(firstInputLine, secondInputLine);

        for (int i = 0; i < n; i++) {
            System.out.print(outputNumbers.get(i) + " ");
        }
    }

    static List getOddOrEvenNumbers(String firstInputLine, String secondInputLine) {
        String[] splitFirstInputLine = firstInputLine.split(" ");
        String[] splitSecondInputLine = secondInputLine.split(" ");
        List<Integer> numbers = new ArrayList<>();

        if (splitSecondInputLine[2].equals("even")) {
            for (int i = 0; i < splitFirstInputLine.length; i++) {
                int singleNumber = Integer.parseInt(splitFirstInputLine[i]);
                if (singleNumber % 2 == 0) {
                    numbers.add(singleNumber);
                }
            }
        } else {
            for (int i = 0; i < splitFirstInputLine.length; i++) {
                int singleNumber = Integer.parseInt(splitFirstInputLine[i]);
                if (singleNumber % 2 != 0) {
                    numbers.add(singleNumber);
                }
            }
        }
        return numbers;
    }
}
