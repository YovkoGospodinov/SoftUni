package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P05ExtractWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        Pattern ptrn = Pattern.compile("[a-zA-Z]+");
        Matcher match = ptrn.matcher(input);

        while (match.find()) {
            System.out.printf(match.group() + " ");
        }
    }
}
