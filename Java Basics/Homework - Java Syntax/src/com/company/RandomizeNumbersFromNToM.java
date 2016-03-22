package com.company;

import java.util.*;

public class RandomizeNumbersFromNToM {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int firstNumber = sc.nextInt();
        int secondNumber = sc.nextInt();

        int startNumber = Math.min(firstNumber, secondNumber);
        int greaterNumber = Math.max(firstNumber, secondNumber);
        List<Integer> line = new ArrayList<Integer>();
        for (int i = startNumber; i <= greaterNumber ; i++) {
            line.add(i);
        }
        Collections.shuffle(line);

        for (Integer number : line) {
            System.out.print(number + " ");
        }
    }
}
