package com.company;

import java.io.*;

public class P3CountCharacterTypes {
    public static void main(String[] args) throws IOException {
        BufferedReader input = new BufferedReader(new FileReader("words.txt"));
        FileWriter output = new FileWriter("count-chars.txt");

        String line;
        int vowels = 0;
        int consunants = 0;
        int punctuation = 0;

        while ((line = input.readLine()) != null) {
            for (int sym = 0; sym < line.length(); sym++) {
                char symbol = Character.toLowerCase(line.charAt(sym));
                switch (symbol) {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowels++;
                        break;
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'v':
                    case 'w':
                    case 'y':
                    case 'z':
                        consunants++;
                        break;
                    case ' ':
                        break;
                    default:
                        punctuation++;
                        break;
                }
            }
        }
        output.write("Vowels: " + vowels + "\r\n");
        output.write("Consonants: " + consunants + "\r\n");
        output.write("Punctuation: " + punctuation + "\r\n");

        input.close();
        output.close();
    }
}

