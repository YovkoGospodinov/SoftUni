package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P06StartEndCapitalLetter {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        Pattern ptrn = Pattern.compile("\\b[A-Z]+[a-zA-Z]*[A-Z]+\\b");
        Matcher match = ptrn.matcher(input);
        while (match.find()) {
            System.out.printf((match.group() + " "));
        }
    }
}
