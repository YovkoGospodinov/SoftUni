package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P04CountAllWords {
    public static void main(String[] args) {
        int countWords = 0;
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        Pattern ptrn = Pattern.compile("[\\w]+");
        Matcher match = ptrn.matcher(input);

        while (match.find()) {
            countWords++;
        }
        System.out.println(countWords);
    }
}
