package org.example;

import java.util.Arrays;

public class RadixSort {
    public static void radixSort(int[] arr) {
        int maxVal = getMaxValue(arr);

        for (int exp = 1; maxVal / exp > 0; exp *= 10) {
            countingSort(arr, exp);
        }
    }

    private static void countingSort(int[] arr, int exp) {
        int[] counts = new int[10];

        for (int num : arr) {
            int digit = (num / exp) % 10;
            counts[digit]++;
        }

        for (int i = 1; i < counts.length; i++) {
            counts[i] += counts[i - 1];
        }

        int[] output = new int[arr.length];
        for (int i = arr.length - 1; i >= 0; i--) {
            int digit = (arr[i] / exp) % 10;
            output[counts[digit] - 1] = arr[i];
            counts[digit]--;
        }

        System.arraycopy(output, 0, arr, 0, arr.length);
    }

    private static int getMaxValue(int[] arr) {
        int maxVal = Integer.MIN_VALUE;
        for (int num : arr) {
            if (num > maxVal) {
                maxVal = num;
            }
        }
        return maxVal;
    }

    public static void main(String[] args) {
        int[] arr = {5, 2, 9, 1, 5, 6};
        radixSort(arr);
        System.out.println(Arrays.toString(arr)); // [1, 2, 5, 5, 6, 9]
    }
}
