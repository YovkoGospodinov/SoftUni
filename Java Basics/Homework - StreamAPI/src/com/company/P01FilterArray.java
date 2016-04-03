package com.company;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P01FilterArray {
    public static boolean isGreaterThanThreeChars(String words) {
        for (char ch : words.toCharArray()) {
            if (words.length() > 3) {
                return true;
            }
        }
        return false;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");

        Arrays.stream(input).filter(P01FilterArray::isGreaterThanThreeChars).forEach(entry -> {
            System.out.print(entry + " ");
        });

//        Standart way of collecting the element in List and printing with forach
//        List<String> words = Arrays.stream(input).filter(P01FilterArray::isGreaterThanThreeChars).collect(Collectors.toList());
//
//        for (String word : words) {
//            System.out.print(word + " ");
//        }
    }
}
