package com.company;

import java.util.Scanner;

public class Convert7BaseToDecimalSystem {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String sevenBaseNumber = sc.nextLine();
        Integer decimalSystemNumber = Integer.valueOf(sevenBaseNumber, 7);
        System.out.println(decimalSystemNumber);
    }
}
