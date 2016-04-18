package com.company;

import java.util.Scanner;

public class PrintCharacterTriangle {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int input = sc.nextInt();
//        String userInput = sc.nextLine(); // According to the term mentioned in the problem to use Integer.parseInt()
//        int input = Integer.parseInt(userInput);// According to the term mentioned in the problem to use Integer.parseInt()
        for (int i = 1; i <= input; i++) {
            for (int j = 0; j < i; j++) {
                System.out.print((char)(97 + j) + " ");
            }
            System.out.println();
        }
        for (int i = input - 1; i > 0 ; i--) {
            for (int j = 0; j < i; j++) {
                System.out.print((char)(97 + j) + " ");
            }
            System.out.println();
        }
    }
}
