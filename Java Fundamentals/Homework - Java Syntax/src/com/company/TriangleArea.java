package com.company;

import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int firstPointX = sc.nextInt();
        int firstPointY = sc.nextInt();
        sc.nextLine();
        int secondPointX = sc.nextInt();
        int secondPointY = sc.nextInt();
        sc.nextLine();
        int thirdPointX = sc.nextInt();
        int thirdPointY = sc.nextInt();

        int triangleArea = Math.abs(firstPointX * (secondPointY - thirdPointY) + secondPointX * (thirdPointY - firstPointY) + thirdPointX * (firstPointY - secondPointY)) / 2;
        System.out.println(triangleArea);
    }
}
