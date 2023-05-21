//#include <stdio.h>
//#include <stdlib.h>
//
//typedef struct Node {
//    int value;
//    struct Node* prev;
//    struct Node* next;
//} Node;
//
//
//void insert_sorted(Node** head, int value) {
//    Node* new_node = create_node(value);
//
//    if (*head == NULL) {
//        // если список пустой, новый узел становится головой списка
//        *head = new_node;
//        return;
//    }
//
//    Node* current = *head;
//
//    // ищем место для вставки нового узла
//    while (current != NULL && current->value < value) {
//        current = current->next;
//    }
//
//    if (current == NULL) {
//        // если новое значение больше всех значений в списке, добавляем новый узел в конец
//        Node* tail = *head;
//        while (tail->next != NULL) {
//            tail = tail->next;
//        }
//        tail->next = new_node;
//        new_node->prev = tail;
//    }
//    else if (current == *head) {
//        // если новое значение меньше всех значений в списке, добавляем новый узел в начало
//        new_node->next = *head;
//        (*head)->prev = new_node;
//        *head = new_node;
//    }
//    else {
//        // вставляем новый узел перед текущим узлом
//        new_node->prev = current->prev;
//        new_node->next = current;
//        current->prev->next = new_node;
//        current->prev = new_node;
//    }
//}
//
//
//void print_list(Node* head) {
//    while (head != NULL) {
//        printf("%d ", head->value);
//        head = head->next;
//    }
//    printf("\n");
//}
//
//
//int mainkkkk() {
//    Node* head = NULL;
//
//    insert_sorted(&head, 5);
//    insert_sorted(&head, 2);
//    insert_sorted(&head, 7);
//    insert_sorted(&head, 1);
//    insert_sorted(&head, 9);
//
//    print_list(head);
//
//    return 0;
//}