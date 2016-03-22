package com.company;

import java.util.Scanner;

/**
 * Created by Yove on 3/15/2016.
 */
public class SumNumbersFrom1ToN {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();
        int sum = 0;
        for (int i = 1; i <= number; i++) {
            sum += i;
        }
        System.out.println(sum);
    }
}
