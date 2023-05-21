#include <stdio.h>

//to call the malloc function
//use malloc function to create memory for struct node - need allocate memory for it
#include <stdlib.h> 

struct node {
	int data;
	struct node* link;
};

struct node* create_nodes() {
	struct node* head = NULL;
	//to allocate memory for struct node
	//the memory will be allocated for data and lonk part due `sizeof` 
	// malloc return void pointer, which we cast to `struct node*` - good practise, not necceasary
	head = (struct node*)malloc(sizeof(struct node));
	head->data = 45;
	head->link = NULL;

	struct node* current = malloc(sizeof(struct node));
	current->data = 98;
	current->link = NULL;
	head->link = current;

	current = malloc(sizeof(struct node));
	current->data = 3;
	current->link = NULL;

	head->link->link = current;
	return head;
}

int count_of_nodes(struct node* head) {
	int count = 0;
	if (head == NULL) {
		printf("Linked list is empty");
	}
	struct node* ptr = NULL;
	ptr = head;
	while (ptr != NULL) {
		count++;
		ptr = ptr->link;
	}
	printf("%d\n", count);
}


void print_nodes(struct node* head) {
	if (head == NULL) {
		printf("Linked list is empty");
	}
	struct node* ptr = NULL;
	ptr = head;
	while (ptr != NULL) {
		printf("%d ", ptr->data);
		ptr = ptr->link;
	}
	printf("\n");
}


void add_to_end(struct node* head, int data) {
	struct node* pointer_new_node = malloc(sizeof(struct node));
	pointer_new_node->data = data;
	pointer_new_node->link = NULL;

	struct node* ptr = NULL;
	ptr = head;

	while (ptr->link != NULL) {
		ptr = ptr->link;
	}
	ptr->link = pointer_new_node;

}

struct node* add_after(struct node* ptr, int data) {
	struct node* pointer_new_node = malloc(sizeof(struct node));
	pointer_new_node->data = data;
	pointer_new_node->link = NULL;

	ptr->link = pointer_new_node;
	return pointer_new_node;
}

struct node* add_at_begining(struct node* head, int data) {
	struct node* pointer_new_node = malloc(sizeof(struct node));
	pointer_new_node->data = data;
	pointer_new_node->link = NULL;

	pointer_new_node->link = head;
	head = pointer_new_node;
	return head;
}


void add_at_position(struct node* head, int data, int position) {
	struct node* pointer_new_node = malloc(sizeof(struct node));
	pointer_new_node->data = data;
	pointer_new_node->link = NULL;

	struct node* ptr = head;


	while (position != 1) {
		ptr = ptr->link;
		position--;
	}

	pointer_new_node->link = ptr->link;
	ptr->link = pointer_new_node;
}

struct node* delete_from_head(struct node* head) {
	if (head == NULL) {
		printf("List is already empty");
	}
	else {
		struct node* temp = head;
		head = head->link;
		free(temp);
		temp = NULL;
	}
	return head;
}

void delete_last(struct node* head) {
	if (head == NULL) {
		printf("List is already empty");
	} 
	else if (head->link == NULL) {
		free(head);
		head = NULL;
	}
	else {
		struct node* ptr = head;
		while (ptr->link->link != NULL) {
			ptr = ptr->link;
		}
		struct node* temp = ptr->link;
		ptr->link = NULL;
		free(temp);
		temp = NULL;
	}
}

int main1() {
	struct node* head = create_nodes();
	count_of_nodes(head);
	print_nodes(head);
	add_to_end(head, 890);
	count_of_nodes(head);
	print_nodes(head);
}

int main2() {
	struct node* head = NULL;
	head = (struct node*)malloc(sizeof(struct node));
	head->data = 45;
	head->link = NULL;

	struct node* ptr = head;
	ptr = add_after(ptr, 32);
	ptr = add_after(ptr, 90);
	ptr = add_after(ptr, 89);

	print_nodes(head);
}

int main3() {
	struct node* head = NULL;
	head = (struct node*)malloc(sizeof(struct node));
	head->data = 45;
	head->link = NULL;
	//arguments passed by value, so we need to save head 
	head = add_at_begining(head, 3);
	head = add_at_begining(head, 5);
	head = add_at_begining(head, 7);

	print_nodes(head);

	return 0;
}

int main4() {
	struct node* head = NULL;
	head = (struct node*)malloc(sizeof(struct node));
	head->data = 45;
	head->link = NULL;

	struct node* ptr = head;
	ptr = add_after(ptr, 32);
	ptr = add_after(ptr, 90);
	ptr = add_after(ptr, 89);

	add_at_position(head, 666, 2);

	print_nodes(head);
}

int main5() {
	struct node* head = NULL;
	head = (struct node*)malloc(sizeof(struct node));
	head->data = 45;
	head->link = NULL;

	struct node* ptr = head;
	ptr = add_after(ptr, 32);
	ptr = add_after(ptr, 90);
	ptr = add_after(ptr, 89);

	print_nodes(head);

	head = delete_from_head(head);

	print_nodes(head);
}

int main6() {
	struct node* head = NULL;
	head = (struct node*)malloc(sizeof(struct node));
	head->data = 45;
	head->link = NULL;

	//struct node* ptr = head;
	//ptr = add_after(ptr, 32);
	//ptr = add_after(ptr, 90);
	//ptr = add_after(ptr, 89);

	print_nodes(head);

	delete_last(head);

	print_nodes(head);
}