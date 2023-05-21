#include <stdio.h>
#include <stdlib.h> 
#include <string.h>




struct Person {
	char* name;
	int age;
	char* address;
};

struct node {
	struct node* prev;
	struct Person data;
	struct node* next;
};


void print_double_linked_list(struct node* head) {
	if (head == NULL) {
		printf("Linked list is empty");
	}
	struct node* ptr = NULL;
	ptr = head;
	while (ptr != NULL) {
		printf("%s ", ptr->data.name);
		ptr = ptr->next;
	}
	printf("\n");
}



struct node* add(struct node* head, struct Person data) {
	struct node* new_node_pointer = malloc(sizeof(struct node));
	new_node_pointer->prev = NULL;
	new_node_pointer->data = data;
	new_node_pointer->next = NULL;

	struct node* ptr = head;

	if (ptr == NULL) {
		// ���� ������ ������, ����� ���� ���������� ������� ������
		head = new_node_pointer;
		return head;
	}

	// ���� ����� ��� ������� ������ ����
	while (ptr != NULL && strcmp(ptr->data.name, data.name) < 0) {
		ptr = ptr->next;
	}

	if (ptr == NULL) {
		// ���� ����� �������� ������ ���� �������� � ������, ��������� ����� ���� � �����
		struct node* temp = head;
		while (temp->next != NULL) {
			temp = temp->next;
		}
		temp->next = new_node_pointer;
		new_node_pointer->prev = temp;
		return head;
	}
	else if (ptr == head) {
		// ���� ����� �������� ������ ���� �������� � ������, ��������� ����� ���� � ������
		new_node_pointer->next = head;
		head->prev = new_node_pointer;
		head = new_node_pointer;
		return head;
	}
	else {
		// ��������� ����� ���� ����� ������� �����
		new_node_pointer->prev = ptr->prev;
		new_node_pointer->next = ptr;
		ptr->prev->next = new_node_pointer;
		ptr->prev = new_node_pointer;
		return head;
	}


}


int main() {
	

	//struct Person p;

	//printf("Enter age: ");
	//scanf_s("%d", &p.age);

	//printf("Enter address: ");
	//scanf_s("%s", p.address);

	//printf("Enter name: ");
	//scanf_s("%s", p.name);

	//printf("\nYou entered:\n");
	//printf("Age: %d\n", p.age);
	//printf("Address: %s\n", p.address);
	//printf("Name: %s\n", p.name);


	//while (1) {
	//	struct Person p;

	//	printf("Enter age: ");
	//	scanf_s("%d", &p.age);

	//	printf("Enter address: ");
	//	scanf_s("%s", p.address);

	//	printf("Enter name: ");
	//	scanf_s("%s", p.name);

	//
	//}

	struct Person person1 = { "Bob", 25, "123 Main St" };
	struct Person person2 = { "Akice", 30, "456 Elm St" };
	struct Person person3 = { "Lohn", 40, "789 Oak St" };
	struct Person person4 = { "John", 40, "789 Oak St" };
	struct Person person5 = { "Ref", 40, "789 Oak St" };
	struct node* head = add(NULL, person1);
	print_double_linked_list(head);
	head = add(head, person2);
	print_double_linked_list(head);
	head = add(head, person3);
	head = add(head, person4);
	head = add(head, person5);

	//head = add(head, 4);
	print_double_linked_list(head);
	return 0;


}



