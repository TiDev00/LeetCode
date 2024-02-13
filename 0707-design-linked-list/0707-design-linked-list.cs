class Node{
    public int value;
    public Node next;

    public Node(int value){
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
    
    public Node Traverse(int index){
        int position = 0;
        Node currentNode = this.head;
        while(position != index){
            currentNode = currentNode.next;
            position++;
        }
        return currentNode;
    }
    
    public int Get(int index) {
        if(index < 0 || index >= this.length){
            return -1;
        }
        Node currentNode = Traverse(index);
        return currentNode.value;
    }
    
    public void AddAtHead(int value) {
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
    
    public void AddAtTail(int value) {
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
    
    public void AddAtIndex(int index, int value) {
        if(index < 0 || index > this.length) {
            return;
        }
        if(index == 0) {
            AddAtHead(value);
            return;
        }
        if(index == length){
            AddAtTail(value);
            return;
        }
        Node newNode = new Node(value);
        Node previousNode = Traverse(index - 1);
        newNode.next = previousNode.next;
        previousNode.next = newNode;
        this.length++;
    }
    
    public void DeleteAtIndex(int index) {
        if (this.head == null || index < 0 || index >= this.length) {
            return;
        }
        if (index == 0) {
            this.head = this.head.next;
            if (this.length == 1) {
                this.tail = null;
            }
        } else {
            Node previousNode = Traverse(index - 1);
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
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */