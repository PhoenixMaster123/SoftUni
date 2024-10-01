package exercise.CustomLinkedList_Workshop;

import java.util.NoSuchElementException;
import java.util.function.Consumer;

public class DoublyLinkedList {

    class Node {
        int element;
        Node next; // head
        Node prev; // tail

        public Node(int element) {
            this.element = element;
        }
    }

    private Node head;
    private Node tail;
    private int size;

    public void addFirst(int element) {
        Node newNode = new Node(element);

        if(this.size == 0) {
            this.head = this.tail = newNode;
        } else {

            // We are hanging the newNode to the old Node
            newNode.next = this.head;
            // We are hanging old Node prevNode with newNode
            this.head.prev = newNode;
            // We add the new head
            this.head = newNode;
        }
        this.size++;
    }
    public void addLast(int element) {
        Node newNode = new Node(element);

        if(size == 0) {
            this.head = this.tail = newNode;
        } else {
            newNode.prev = this.tail;
            // We are hanging old Node nextNode with newNode
            this.tail.next = newNode;
            this.tail = newNode;
        }
        this.size++;
    }
    public int get(int index) {
        checkIndex(index);
        Node currentNode = this.head;
        for (int i = 0; i < index; i++) {
            currentNode = currentNode.next;
        }
        return currentNode.element;
    }

    private void checkIndex(int index) {
        if(index < 0 || index >= this.size) {
            throw new ArrayIndexOutOfBoundsException("Index out of bounds");
        }
    }

    public int removeFirst() {
        checkEmpty();
        int element = this.head.element;
        this.head = this.head.next;
        if(this.head == null) {
            this.tail = null;
        } else {
            this.head.prev = null;
        }
        this.size--;
        return element;
    }
    public int removeLast() {
        checkEmpty();
        int element = this.tail.element;
        this.tail = this.tail.prev;
        if(this.tail == null) {
            this.head = null;
        } else {
            this.tail.next = null;
        }
        this.size--;
        return element;
    }
    public void forEach(Consumer<Integer> consumer) {
        Node currentNode = this.head;

        while (currentNode != null) {
            consumer.accept(currentNode.element);
            currentNode = currentNode.next;
        }
    }
    public int[] toArray() {
        int[] array = new int[this.size];

        Node currentNode = this.head;
        int counter = 0;
        while (currentNode != null) {
            array[counter++] = currentNode.element;
            currentNode = currentNode.next;
        }
        return array;
    }

    private void checkEmpty() {
        if(this.size == 0) {
            throw new NoSuchElementException("No such element exist");
        }
    }

}
