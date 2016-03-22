package com.company;

import java.util.Scanner;

public class ConvertFromDecimalTo7BaseSystem {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int decimalsystemNumber = sc.nextInt();
        String sevenSystemNumber = Integer.toString(decimalsystemNumber, 7);
        System.out.println(sevenSystemNumber);
    }
}
