class Node:
    def __init__(self, value):
        self.value = value
        self.next = None

class MyLinkedList:

    def __init__(self):
        self.head = self.tail = None
        self.length = 0
        
    def traverse(self, index: int) -> Node:
        position = 0
        current_node = self.head
        while position != index:
            current_node = current_node.next
            position += 1
        return current_node

    def get(self, index: int) -> int:
        
        if index < 0 or index >= self.length:
            return -1
        current_node = self.traverse(index)
        return current_node.value

    def addAtHead(self, value: int) -> None:
        new_node = Node(value)
        if not self.head:
            self.head = self.tail = new_node
        else:
            new_node.next = self.head
            self.head = new_node
        self.length += 1

    def addAtTail(self, value: int) -> None:
        new_node = Node(value)
        if not self.head:
            self.head = self.tail = new_node
        else:
            self.tail.next = new_node
            self.tail = new_node
        self.length += 1

    def addAtIndex(self, index: int, value: int) -> None:
        if index < 0 or index > self.length:
            return
        if index == 0:
            self.addAtHead(value)
            return
        if index == self.length:
            self.addAtTail(value)
            return
        new_node = Node(value)
        previous_node = self.traverse(index - 1)
        new_node.next = previous_node.next
        previous_node.next = new_node
        self.length += 1


    def deleteAtIndex(self, index: int) -> None:
        if index < 0 or index >= self.length:
            return
        if index == 0:
            self.head = self.head.next
            if self.length == 1:
                self.tail = None
        else:
            previous_node = self.traverse(index - 1)
            current_node = previous_node.next
            previous_node.next = current_node.next
            if index == self.length - 1:
                self.tail = previous_node
        self.length -= 1

# Your MyLinkedList object will be instantiated and called as such:
# obj = MyLinkedList()
# param_1 = obj.get(index)
# obj.addAtHead(val)
# obj.addAtTail(val)
# obj.addAtIndex(index,val)
# obj.deleteAtIndex(index)