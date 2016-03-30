package com.company;

import java.lang.reflect.Array;
import java.util.Calendar;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class P10CardsFrequencies {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split("\\W+");

        Map<String, Integer> cardsMap = new LinkedHashMap<String, Integer>();
        Integer count = 0;
        for (String cardCount : input) {
            count = cardsMap.get(cardCount);
            if (count == null) {
                count = 0;
            }
            cardsMap.put(cardCount, count+ 1);
        }
        for (Map.Entry<String, Integer> keyValuePair : cardsMap.entrySet()) {
            System.out.printf("%s -> %.2f%%", (String)keyValuePair.getKey(), (((double) keyValuePair.getValue() / input.length) * 100));
            System.out.println();
        }
    }
}
