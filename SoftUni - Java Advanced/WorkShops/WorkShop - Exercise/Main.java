package exercise.CustomLinkedList_Workshop;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

        // addFirst → we only change the head
        doublyLinkedList.addFirst(1); // tail
        doublyLinkedList.addFirst(2);
        doublyLinkedList.addFirst(3); // head

        // addLast → we only change the tail
        doublyLinkedList.addLast(1); // head
        doublyLinkedList.addLast(2);
        doublyLinkedList.addLast(3); // tail

    }
}
