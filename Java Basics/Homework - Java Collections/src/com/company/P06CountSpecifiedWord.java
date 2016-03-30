package com.company;

import java.util.Scanner;

public class P06CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String requestWord = sc.nextLine();
        String[] words = input.split("[^A-Za-z]+");
        int count = 0;
        for (int i = 0; i < words.length; i++) {
            boolean isEqual = (words[i].toLowerCase()).equals(requestWord);
            if (isEqual) {
                count++;
            }
        }
        System.out.println(count);
    }
}
