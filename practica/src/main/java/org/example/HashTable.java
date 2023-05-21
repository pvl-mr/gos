package org.example;

public class HashTable {
    private SortedList[] hashArray; // Массив списков
    private int arraySize;
    // -------------------------------------------------------------
    public HashTable(int size) // Конструктор
    {
        arraySize = size;
        hashArray = new SortedList[arraySize]; // Создание массива
        for(int j=0; j<arraySize; j++) // Заполнение массива
            hashArray[j] = new SortedList(); // списками
    }
    // -------------------------------------------------------------
    public void displayTable()
    {
        for(int j=0; j<arraySize; j++) // Для каждой ячейки
        {
            System.out.print(j + ". "); // Вывод номера ячейки
            hashArray[j].displayList(); // Вывод списка
        }
    }

    public int hashFunc(int key) // Хеш-функция
    {
        return key % arraySize;
    }

    /*public static int hashFunc1(String key)
    {
        int hashVal = 0;
        int pow27 = 1; // 1, 27, 27*27 и т. д.
        for(int j=key.length()-1; j>=0; j--) // Справа налево
        {
            int letter = key.charAt(j) - 96; // Получение кода символа
            hashVal += pow27 * letter; // Умножение на степень 27
            pow27 *= 27; // Следующая степень 27
        }
        return hashVal % arraySize;
    }*/

    // -------------------------------------------------------------
    public void insert(Link theLink) // Вставка элемента
    {
        int key = theLink.getKey();
        int hashVal = hashFunc(key); // Хеширование ключа
        hashArray[hashVal].insert(theLink); // Вставка в позиции hashVal
    }
    // -------------------------------------------------------------
    public void delete(int key) // Удаление элемента
    {
        int hashVal = hashFunc(key); // Хеширование ключа
        hashArray[hashVal].delete(key); // Удаление
    }
    // -------------------------------------------------------------
    public Link find(int key) // Поиск элемента
    {
        int hashVal = hashFunc(key); // Хеширование ключа
        Link theLink = hashArray[hashVal].find(key); // Поиск
        return theLink; // Метод возвращает найденный элемент
    }

}
