package com.company;

import java.util.Scanner;

public class GhettoNumeralSystem {
    public static void main(String[] args) {
//        String[] ghettoNumeralSystem = new String[10];
//        ghettoNumeralSystem[0] = "Gee";
//        ghettoNumeralSystem[1] = "Bro";
//        ghettoNumeralSystem[2] = "Zuz";
//        ghettoNumeralSystem[3] = "Ma";
//        ghettoNumeralSystem[4] = "Duh";
//        ghettoNumeralSystem[5] = "Yo";
//        ghettoNumeralSystem[6] = "Dis";
//        ghettoNumeralSystem[7] = "Hood";
//        ghettoNumeralSystem[8] = "Jam";
//        ghettoNumeralSystem[9] = "Mack";
        String[] ghettoNumeralSystem = new String[] {"Gee", "Bro", "Zuz", "Ma", "Duh", "Yo", "Dis", "Hood", "Jam","Mack"};
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String result = "";
        for (int i = 0; i < input.length(); i++) {
            int number = Character.getNumericValue(input.charAt(i));
            result += ghettoNumeralSystem[number];
        }
        System.out.println(result);
    }
}
