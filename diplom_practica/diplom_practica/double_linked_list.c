//#include <stdio.h>
//
////to call the malloc function
////use malloc function to create memory for struct node - need allocate memory for it
//#include <stdlib.h> 
//
//struct node {
//	struct node* prev;
//	int data;
//	struct node* next;
//};
//
//struct node* create_node_in_double_linked_list() {
//	struct node* head = malloc(sizeof(struct node));
//	head->prev = NULL;
//	head->data = 19;
//	head->next = NULL;
//	return head;
//}
//
//void print_double_linked_list_nodes(struct node* head) {
//	if (head == NULL) {
//		printf("Linked list is empty");
//	}
//	struct node* ptr = NULL;
//	ptr = head;
//	while (ptr != NULL) {
//		printf("%d ", ptr->data);
//		ptr = ptr->next;
//	}
//	printf("\n");
//}
//
//
//struct node* add_to_beginning_to_linked_list(struct node* head, int data) {
//	struct node* new_node_pointer = malloc(sizeof(struct node));
//	new_node_pointer->prev = NULL;
//	new_node_pointer->data = data;
//	new_node_pointer->next = NULL;
//
//	new_node_pointer->next = head;
//	head->prev = new_node_pointer;
//	head = new_node_pointer;
//	return head;
//}
//
//void add_to_end__double_linked_list(struct node* head, int data) {
//	struct node* new_node_pointer = malloc(sizeof(struct node));
//	new_node_pointer->prev = NULL;
//	new_node_pointer->data = data;
//	new_node_pointer->next = NULL;
//
//	struct node* ptr = head;
//
//	while (ptr->next != NULL) {
//		ptr = ptr->next;
//	}
//
//	ptr->next = new_node_pointer;
//	new_node_pointer->prev = ptr;
//}
//
//void add_to_position_to_double_linked_list(struct node* head, int data, int position) {
//	struct node* new_node_pointer = malloc(sizeof(struct node));
//	new_node_pointer->prev = NULL;
//	new_node_pointer->data = data;
//	new_node_pointer->next = NULL;
//
//	struct node* ptr = head;
//
//	while (position != 1) {
//		ptr = ptr->next;
//		position--;
//	}
//
//	new_node_pointer->next = ptr->next;
//	ptr->next = new_node_pointer;
//	new_node_pointer->prev = ptr;
//	new_node_pointer->next->prev = new_node_pointer;
//}
//
//
//int main_double1() {
//	struct node* head = create_node_in_double_linked_list();
//	print_double_linked_list_nodes(head);
//	head = add_to_beginning_to_linked_list(head, 67);
//	print_double_linked_list_nodes(head);
//	return 0;
//}
//
//int main_double2() {
//	struct node* head = create_node_in_double_linked_list();
//	print_double_linked_list_nodes(head);
//	add_to_end_list(head, 3);
//	add_to_end_list(head, 5);
//	add_to_end_list(head, 30);
//	print_double_linked_list_nodes(head);
//}
//
//int main_double3() {
//	struct node* head = create_node_in_double_linked_list();
//	add_to_end__double_linked_list(head, 3);
//	add_to_end__double_linked_list(head, 5);
//	add_to_end__double_linked_list(head, 30);
//	print_double_linked_list_nodes(head);
//	add_to_position_to_double_linked_list(head, 666, 2);
//	add_to_position_to_double_linked_list(head, 888, 2);
//	print_double_linked_list_nodes(head);
//}