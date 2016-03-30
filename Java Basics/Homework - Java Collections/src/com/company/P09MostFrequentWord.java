package com.company;

import javafx.animation.KeyValue;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class P09MostFrequentWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine().toLowerCase();
        String[] words = input.split("[^A-Za-z]+");
        Integer maxValue = 0;
        Map<String, Integer> countWords = new TreeMap<>();
        for (String word : words) {
            Integer count = countWords.get(word);
            if (count == null) {
                count = 0;
            }
            if (count + 1 > maxValue) {
                maxValue = count + 1;
            }
            countWords.put(word, count + 1);
        }
        for (Map.Entry<String, Integer> keyValues : countWords.entrySet()) {
            if (keyValues.getValue() == maxValue) {
                System.out.printf(keyValues.getKey() + " -> " + keyValues.getValue() + " times\r\n");
            }
        }
    }
}
