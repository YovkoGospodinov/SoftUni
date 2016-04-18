package com.company;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class P2AllCAPITALS {
    public static void main(String[] args) throws IOException {
        BufferedReader input = new BufferedReader(new FileReader("allcapitals.txt"));

        String line  = "";
        String newLine = "";
        while ((line = input.readLine()) != null) {
            newLine += line.toUpperCase() + "\r\n";
        }
        input.close();

        FileWriter output = new FileWriter("allcapitals.txt");
        output.write(newLine);

        output.close();
    }
}
