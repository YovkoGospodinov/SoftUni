package com.company;

import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int width = sc.nextInt();
        int high = sc.nextInt();
        int area = width * high;
        System.out.println(area);
    }
}
