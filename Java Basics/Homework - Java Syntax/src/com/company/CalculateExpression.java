package com.company;

import java.util.Scanner;

public class CalculateExpression {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double firstNumber = sc.nextDouble();
        double secondNumber = sc.nextDouble();
        double thirdNumber = sc.nextDouble();

        double baseOne = (Math.pow(firstNumber, 2) + Math.pow(secondNumber, 2)) / (Math.pow(firstNumber, 2) - Math.pow(secondNumber, 2));
        double powerOne = (firstNumber + secondNumber + thirdNumber) / Math.sqrt(thirdNumber);
        double firstResult = Math.pow(baseOne, powerOne);

        double baseTwo = (Math.pow(firstNumber, 2) + Math.pow(secondNumber, 2) - Math.pow(thirdNumber, 3));
        double powerTwo = firstNumber - secondNumber;
        double secondResult = Math.pow(baseTwo, powerTwo);

        double firstAverage = (firstNumber + secondNumber + thirdNumber) / 3.0d;
        double secondAverage = (firstResult + secondResult) / 2.0d;
        double difference = firstAverage - secondAverage;

        System.out.printf("F1 result: %1$.2f; F2 result: %2$.2f; Diff: %3$.2f", firstResult, secondResult, Math.abs(difference));
    }
}
