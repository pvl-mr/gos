package org.example;

public class Vertex {
    public char label; // метка (например, 'A')
    public boolean wasVisited;
    // ------------------------------------------------------------
    public Vertex(char lab) // Конструктор
    {
        label = lab;
        wasVisited = false;
    }
}
