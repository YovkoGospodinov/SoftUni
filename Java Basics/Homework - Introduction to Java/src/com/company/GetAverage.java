package com.company;

import java.util.Scanner;

public class GetAverage {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        float firstNumber = sc.nextFloat();
        float secondNumber = sc.nextFloat();
        float thirdNumber = sc.nextFloat();

        getAverage(firstNumber, secondNumber, thirdNumber);
    }

    public static void getAverage(float firstNumber, float secondNumber, float thirdNumber) {
        float averageNumber = (firstNumber + secondNumber + thirdNumber) / 3.0f;
        System.out.printf("%.2f", averageNumber);
        System.out.println();
    }
}
