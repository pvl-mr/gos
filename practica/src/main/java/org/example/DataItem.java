package org.example;

public class DataItem {
     // (Данных может быть и больше)
        private int iData; // Данные (ключ)
        public DataItem(int ii) // Конструктор
        { iData = ii; }
        public int getKey()
        { return iData; }
}
