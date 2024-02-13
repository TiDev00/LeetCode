class Node{
    int value;
    Node next;

    Node(int value){
        this.value = value;
        this.next = null;
    }
}

class MyLinkedList {
    Node head;
    Node tail;
    int length;

    public MyLinkedList() {
        this.head = this.tail = null;
        this.length = 0;
    }
    
    public Node traverse(int index){
        int position = 0;
        Node currentNode = this.head;
        while(position != index){
            currentNode = currentNode.next;
            position++;
        }
        return currentNode;
    }
    
    public int get(int index) {
        if(index < 0 || index >= this.length){
            return -1;
        }
        Node currentNode = traverse(index);
        return currentNode.value;
    }
    
    public void addAtHead(int value) {
        Node newNode = new Node(value);
        if(this.head == null){
            this.head = this.tail = newNode;
        }
        else{
            newNode.next = this.head;
            this.head = newNode;
        }
        this.length++;
    }
    
    public void addAtTail(int value) {
        Node newNode = new Node(value);
        if(this.head == null){
            this.head = this.tail = newNode;
        }
        else{
            this.tail.next = newNode;
            this.tail = newNode;
        }
        this.length++;
    }
    
    public void addAtIndex(int index, int value) {
        if(index < 0 || index > this.length) {
            return;
        }
        if(index == 0) {
            addAtHead(value);
            return;
        }
        if(index == length){
            addAtTail(value);
            return;
        }
        Node newNode = new Node(value);
        Node previousNode = traverse(index - 1);
        newNode.next = previousNode.next;
        previousNode.next = newNode;
        this.length++;
    }
    
    public void deleteAtIndex(int index) {
        if (this.head == null || index < 0 || index >= this.length) {
            return;
        }
        if (index == 0) {
            this.head = this.head.next;
            if (this.length == 1) {
                this.tail = null;
            }
        } else {
            Node previousNode = traverse(index - 1);
            Node currentNode = previousNode.next;
            previousNode.next = currentNode.next;
            if (index == this.length - 1) {
                this.tail = previousNode;
            }
        }
        this.length--;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.get(index);
 * obj.addAtHead(val);
 * obj.addAtTail(val);
 * obj.addAtIndex(index,val);
 * obj.deleteAtIndex(index);
 */