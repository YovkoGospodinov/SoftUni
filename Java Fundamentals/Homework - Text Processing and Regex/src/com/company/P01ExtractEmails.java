package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P01ExtractEmails {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        Pattern searchPattern = Pattern.compile("[a-zA-Z0-9._-]+@[(a-zA-Z-.]+\\b");
        Matcher match = searchPattern.matcher(input);

        while (match.find()) {
            System.out.println(match.group());
        }
    }
}
