package org.example;

import java.util.Arrays;

public class CountingSort {
    public static void countingSort(int[] arr, int maxVal) {
        int[] counts = new int[maxVal + 1];

        for (int num : arr) {
            counts[num]++;
        }

        int i = 0;
        for (int j = 0; j < counts.length; j++) {
            while (counts[j] > 0) {
                arr[i++] = j;
                counts[j]--;
            }
        }
    }

    public static void main(String[] args) {
        int[] arr = {5, 2, 9, 1, 5, 6};
        countingSort(arr, 9);
        System.out.println(Arrays.toString(arr)); // [1, 2, 5, 5, 6, 9]
    }
}
