package com.company;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class P1SumLines {
    public static void main(String[] args) throws IOException {
        BufferedReader input = new BufferedReader(new FileReader("lines.txt"));
        String line;
        int sum = 0;
        while ((line = input.readLine()) != null) {
            for (int i = 0; i < line.length(); i++) {
                int value = line.charAt(i);
                sum += value;
            }
            System.out.println(sum);
            sum = 0;
        }
        input.close();
    }
}

