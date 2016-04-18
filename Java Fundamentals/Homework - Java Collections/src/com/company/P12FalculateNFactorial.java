package com.company;

import java.math.BigInteger;
import java.util.Scanner;

public class P12FalculateNFactorial {
    private static BigInteger fact(int num) {
        if (num == 0 || num == 1) {
            return BigInteger.ONE;
        }
        return fact(num - 1).multiply(BigInteger.valueOf(num));
    }

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int number = console.nextInt();
        System.out.println(fact(number));
    }
}
