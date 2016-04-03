package com.company;

import javafx.util.converter.IntegerStringConverter;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class P02SortArrayStreamAPI {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] inputNumber = sc.nextLine().split(" ");
        String sortingOrder = sc.nextLine().toLowerCase();

        if (sortingOrder.equals("ascending")) {
            Arrays.stream(inputNumber).mapToInt(Integer::parseInt).sorted().forEach(entry -> {
                System.out.printf(entry + " ");
            });
        }else {
            Arrays.stream(inputNumber).mapToInt(Integer::parseInt).boxed().sorted((e1, e2) ->e2.compareTo(e1)).forEach(entry -> System.out.printf(entry + " "));
        }
    }
}
