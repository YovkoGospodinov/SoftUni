package com.company;

import java.util.Scanner;

public class P05CountAllWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] words = input.split("[^A-Za-z]+");

        System.out.println(words.length);
    }
}
