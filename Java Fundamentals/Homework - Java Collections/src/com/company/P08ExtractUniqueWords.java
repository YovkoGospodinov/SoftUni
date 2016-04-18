package com.company;

import java.util.Scanner;
import java.util.TreeSet;

public class P08ExtractUniqueWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        String[] words = input.split("[^A-Za-z]+");

        TreeSet<String> uniqueWords = new TreeSet<>();
        for (int i = 0; i < words.length; i++) {
            uniqueWords.add(words[i].toLowerCase());
        }
        for (String uniqueWord : uniqueWords) {
            System.out.printf(uniqueWord + " ");
        }
    }
}
