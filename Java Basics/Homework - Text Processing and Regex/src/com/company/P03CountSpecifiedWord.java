package com.company;

import java.util.Scanner;

public class P03CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split("[^\\w]+");
        String searchedWord = sc.nextLine().toLowerCase();
        int count = 0;

        for (int i = 0; i < input.length; i++) {
            if ((input[i].toLowerCase()).equals(searchedWord)) {
                count++;
            }
        }
        System.out.println(count);
    }
}
