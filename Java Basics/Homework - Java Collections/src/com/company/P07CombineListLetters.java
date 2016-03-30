package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class P07CombineListLetters {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String firstLine = sc.nextLine();
        String secondLine = sc.nextLine();

        List<Character> listOne = new ArrayList<>();
        List<Character> listTwo = new ArrayList<>();

        for (int i = 0; i < firstLine.length(); i++) {
            listOne.add(firstLine.charAt(i));
        }

        for (int i = 0; i <secondLine.length() ; i++) {
            char currentChar = secondLine.charAt(i);
            if (!listOne.contains(currentChar)) {
                listOne.add(' ');
                listOne.add(currentChar);
            }
        }
        for (Character character : listOne) {
            System.out.print(character);
        }
    }
}
