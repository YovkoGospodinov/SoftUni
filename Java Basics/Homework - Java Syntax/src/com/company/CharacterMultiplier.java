package com.company;

import java.util.Scanner;

public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String firstString = sc.next();
        String secondString = sc.next();

        int result = characterMultiplier(firstString, secondString);
        System.out.println(result);
    }
    static int characterMultiplier(String firstString, String secondString) {
        int sum = 0;

        if (firstString.length() == secondString.length()) {
            for (int i = 0; i < firstString.length(); i++) {
                sum += Integer.valueOf(firstString.charAt(i)) * Integer.valueOf(secondString.charAt(i));
//            sum += (int)(firstString.charAt(i)) * (int)(secondString.charAt(i)); another syntax of how we can get the multiply.
            }
        }
        else if (firstString.length() > secondString.length()) {
            for (int i = 0; i < secondString.length(); i++) {
                sum += Integer.valueOf(firstString.charAt(i)) * Integer.valueOf(secondString.charAt(i));
            }
            for (int i = secondString.length(); i < firstString.length(); i++) {
                sum += Integer.valueOf(firstString.charAt(i));
            }
        }
        else {
            for (int i = 0; i < firstString.length(); i++) {
                sum += Integer.valueOf(firstString.charAt(i)) * Integer.valueOf(secondString.charAt(i));
            }
            for (int i = firstString.length(); i < secondString.length(); i++) {
                sum += Integer.valueOf(secondString.charAt(i));
            }
        }
        return sum;
    }
}

