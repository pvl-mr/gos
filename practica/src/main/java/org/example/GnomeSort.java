package org.example;

import java.util.Arrays;

public class GnomeSort {
    public static void gnomeSort(int[] arr) {
        int i = 0;
        while (i < arr.length) {
            if (i == 0 || arr[i] >= arr[i - 1]) {
                i++;
            } else {
                int temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
                i--;
            }
        }
    }

    public static void main(String[] args) {
        int[] arr = {5, 3, 8, 4, 2};
        gnomeSort(arr);
        System.out.println(Arrays.toString(arr)); // [2, 3, 4, 5, 8]
    }
}
