package com.company;

import java.util.Scanner;

public class HitTheTarget {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number = sc.nextInt();

        for (int i = 1; i <= 20 ; i++) {
            for (int j = 1; j <= 20; j++) {
                if (i + j == number) {
                    System.out.println(i + " + " + j + " = " + number);
                }
                else if((i >= j) && ((i - j) == number)) {
                    System.out.println(i + " - " + j + " = " + number);
                }
            }
        }
    }
}
