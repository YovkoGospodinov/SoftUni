package com.company;

import java.util.Scanner;

public class FormattingNumber {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int firstNumber = sc.nextInt();
        double secondNumber = sc.nextDouble();
        double thirdNumber = sc.nextDouble();

        System.out.printf("|%1$-10x|%2$10s|%3$10.2f|%4$-10.3f|", firstNumber, String.format("%10s", Integer.toBinaryString(firstNumber)).replace(' ', '0'), secondNumber, thirdNumber);
    }
}
