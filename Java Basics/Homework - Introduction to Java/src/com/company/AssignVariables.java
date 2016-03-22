package com.company;

public class AssignVariables {
    public static void main(String[] args) {
        boolean boolVariable = false;
        String stringVariable = "Palo Alto, CA";
        short shortVariable = 32767;
        int intVariable = 2000000000;
        double doubleVariable = 0.1234567891011d;
        float floatVariable = 0.5f;
        long longVariable = 919827112351L;
        byte byteVariable = 127;
        char charVariable = 'c';

//        short wrongAssignedVariable = 32768; //IntelliJ don't allow you to declare variable with wrong type without cast.
        short wrongAssignedVariable = (short) 32768; //With the cast will overflow the type.
        System.out.println(wrongAssignedVariable);
    }
}
