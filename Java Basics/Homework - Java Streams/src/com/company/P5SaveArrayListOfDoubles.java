package com.company;

import java.io.*;
import java.util.*;

public class P5SaveArrayListOfDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        ArrayList<Double> doubles = new ArrayList<>();
        for (double i = 0; i < 50 ; i++) {
            doubles.add(i);
        }
        ObjectOutputStream output = new ObjectOutputStream(new FileOutputStream ("doubles.list"));
        for (int i = 0; i < doubles.size() ; i++) {
            output.writeDouble(doubles.get(i));
        }
        output.flush();
        output.close();

        ObjectInputStream input = new ObjectInputStream(new FileInputStream("doubles.list"));
        for (int i = 0; i < doubles.size(); i++) {
            System.out.printf(input.readDouble() + ", ");
        }
        input.close();
    }
}
