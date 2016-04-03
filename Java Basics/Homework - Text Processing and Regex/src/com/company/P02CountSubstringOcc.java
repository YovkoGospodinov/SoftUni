package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P02CountSubstringOcc {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine().toLowerCase();
        String searchSubstring = sc.nextLine().toLowerCase();

        int count = 0;

        for (int i = 0; i <= input.length() - searchSubstring.length(); i++) {
            if (searchSubstring.equals(input.substring(i , searchSubstring.length() + i))) {
                count++;
            }
        }

//        Another way of solving the problem using regex, but doesn't work 100% properly, if you have idea for fixing please help!
//        Pattern searchPattern = Pattern.compile(searchSubstring);
//        Matcher matcher = searchPattern.matcher(input);
//
//        while (matcher.find()) {
//            count++;
//        }

        System.out.println(count);
    }
}
