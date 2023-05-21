package org.example;

public class HashTable {
    private DataItem[] hashArray; // Массив ячеек хеш-таблицы
    private int arraySize;
    DataItem nonItem;
    // -------------------------------------------------------------
    public HashTable(int size) // Конструктор
    {
        arraySize = size;
        hashArray = new DataItem[arraySize];
        nonItem = new DataItem(-1); // Ключ удаленного элемента -1
    }
    // -------------------------------------------------------------
    public void displayTable()
    {
        System.out.print("Table: ");
        for(int j=0; j<arraySize; j++)
        {
            if(hashArray[j] != null)
                System.out.print(hashArray[j].getKey() + " ");
            else
                System.out.print("** ");
        }
        System.out.println("");
    }
    // -------------------------------------------------------------
    public int hashFunc(int key)
    {
        return key % arraySize; // Хеш-функция
    }
    public void insert(DataItem item) // Вставка элемента данных
// (Метод предполагает, что таблица не заполнена)
    {
        int key = item.getKey(); // Получение ключа
        int hashVal = hashFunc(key); // Хеширование ключа
// Пока не будет найдена
        while(hashArray[hashVal] != null && // пустая ячейка или -1,
                hashArray[hashVal].getKey() != -1)
        {
            ++hashVal; // Переход к следующей ячейке
            hashVal %= arraySize; // При достижении конца таблицы
        } // происходит возврат к началу
        hashArray[hashVal] = item; // Вставка элемента
    }
    public DataItem delete(int key) // Удаление элемента данных
    {
        int hashVal = hashFunc(key); // Хеширование ключа
        while(hashArray[hashVal] != null) // Пока не будет найдена
// пустая ячейка
        { // Ключ найден?
            if(hashArray[hashVal].getKey() == key)
            {
                DataItem temp = hashArray[hashVal]; // Временное сохранение
                hashArray[hashVal] = nonItem; // Удаление элемента
                return temp; // Метод возвращает элемент
            }
            ++hashVal; // Переход к следующей ячейке
            hashVal %= arraySize; // При достижении конца таблицы
        } // происходит возврат к началу
        return null; // Элемент не найден
    }
    public DataItem find(int key) // Поиск элемента с заданным ключом
// (Метод предполагает, что таблица не заполнена)
    {
        int hashVal = hashFunc(key); // Хеширование ключа
        while(hashArray[hashVal] != null) // Пока не будет найдена
// пустая ячейка
        { // Ключ найден?
            if(hashArray[hashVal].getKey() == key)
                return hashArray[hashVal]; // Да, вернуть элемент
            ++hashVal; // Переход к следующей ячейке
            hashVal %= arraySize; // При достижении конца таблицы
        } // происходит возврат к началу
        return null; // Элемент не найден
    }

}
