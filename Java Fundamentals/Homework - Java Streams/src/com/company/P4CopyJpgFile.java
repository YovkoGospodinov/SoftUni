package com.company;

import java.io.*;

public class P4CopyJpgFile {
    public static void main(String[] args) throws IOException {
        DataInputStream input = new DataInputStream(new BufferedInputStream(new FileInputStream("ascii.jpg")));
        DataOutputStream output = new DataOutputStream(new FileOutputStream("my-copied-picture.jpg"));

        int readingImage;
        while ((readingImage= input.read()) != -1){
            output.write(readingImage);
        }
    }
}
