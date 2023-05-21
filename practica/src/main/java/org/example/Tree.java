package org.example;

import java.util.Stack;

public class Tree {
    private Node root; // Единственное поле данных
    public Node find(int key)
    {
        Node current = root; // Начать с корневого узла
        while(current.iData != key) // Пока не найдено совпадение
        {
            if(key < current.iData) // Двигаться налево?
                current = current.leftChild;
            else
                current = current.rightChild; // Или направо?
            if(current == null) // Если потомка нет,
                return null; // поиск завершился неудачей
        }
        return current; // Элемент найден
    }
    public void insert(int id, double dd)
    {
        Node newNode = new Node(); // Создание нового узла
        newNode.iData = id; // Вставка данных
        newNode.dData = dd;
        if(root==null) // Корневой узел не существует
            root = newNode;
        else // Корневой узел занят
        {
            Node current = root; // Начать с корневого узла
            Node parent;
            while(true) // (Внутренний выход из цикла)
            {
                parent = current;
                if(id < current.iData) // Двигаться налево?
                {
                    current = current.leftChild;
                    if(current == null) // Если достигнут конец цепочки
                    { // вставить слева
                        parent.leftChild = newNode;
                        return;
                    }
                }
                else // Или направо?
                {
                    current = current.rightChild;
                    if(current == null) // Если достигнут конец цепочки,
                    { // вставить справа
                        parent.rightChild = newNode;
                        return;
                    }
                }
            }
        }
    }
    public void delete(int id)
    {
    }

    //обход дерева симметричным способом
    private void inOrder(Node localRoot)
    {
        if(localRoot != null)
        {
            inOrder(localRoot.leftChild);
            System.out.print(localRoot.iData + " ");
            inOrder(localRoot.rightChild);
        }
    }

    public Node minimum() // Возвращает узел с минимальным ключом
    {
        Node current, last = null;
        current = root; // Обход начинается с корневого узла
        while(current != null) // и продолжается до низа
        {
            last = current; // Сохранение узла
            current = current.leftChild; // Переход к левому потомку
        }
        return last;
    }

    public Node maximum() // Возвращает узел с максимальным ключом
    {
        Node current, last = null;
        current = root; // Обход начинается с корневого узла
        while(current != null) // и продолжается до низа
        {
            last = current; // Сохранение узла
            current = current.rightChild;; // Переход к правому потомку
        }
        return last;
    }

// Другие методы
    public void displayTree()
    {
        Stack globalStack = new Stack();
        globalStack.push(root);
        int nBlanks = 32;
        boolean isRowEmpty = false;
        System.out.println(
                "......................................................");
        while(isRowEmpty==false)
        {
            Stack localStack = new Stack();
            isRowEmpty = true;
            for(int j=0; j<nBlanks; j++)
                System.out.print(' ');
            while(globalStack.isEmpty()==false)
            {
                Node temp = (Node)globalStack.pop();
                if(temp != null)
                {
                    System.out.print(temp.iData);
                    localStack.push(temp.leftChild);
                    localStack.push(temp.rightChild);
                    if(temp.leftChild != null ||
                            temp.rightChild != null)
                        isRowEmpty = false;
                }
                else
                {
                    System.out.print("--");
                    localStack.push(null);
                    localStack.push(null);
                }
                for(int j=0; j<nBlanks*2-2; j++)
                    System.out.print(' ');
            }
            System.out.println();
            nBlanks /= 2;
            while(localStack.isEmpty()==false)
                globalStack.push( localStack.pop() );
        }
        System.out.println(
                "......................................................");
    }

}
