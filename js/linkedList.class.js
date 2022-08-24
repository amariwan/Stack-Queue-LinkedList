class Node {
    constructor(element) {
        this.element = element;
        this.next = null
    }
}
class LinkedList {
    constructor() {
        this.head = null;
        this.size = 0;
    }
 
    add(element) {
        var node = new Node(element);
        var current;
        if (this.head == null)
            this.head = node;
        else {
            current = this.head;
            while (current.next) {
                current = current.next;
            }
            current.next = node;
        }
        this.size++;
    }

    removeFrom(index) {
        if (index < 0 || index >= this.size)
            return console.log("Please Enter a valid index");
        else {
            var curr, prev, it = 0;
            curr = this.head;
            prev = curr;
            if (index === 0) {
                this.head = curr.next;
            } else {
                while (it < index) {
                    it++;
                    prev = curr;
                    curr = curr.next;
                }
                prev.next = curr.next;
            }
            this.size--;
            return curr.element;
        }
    }

    removeElement(element) {
        var current = this.head;
        var prev = null;
        while (current != null) {
            if (current.element === element) {
                if (prev == null) {
                    this.head = current.next;
                } else {
                    prev.next = current.next;
                }
                this.size--;
                return current.element;
            }
            prev = current;
            current = current.next;
        }
        return -1;
    }
 
 
    indexOf(element) {
        var count = 0;
        var current = this.head;
 
        while (current != null) {
            if (current.element === element)
                return count;
            count++;
            current = current.next;
        }
 
        return -1;
    }
 
    isEmpty() {
        return this.size == 0;
    }
 
    size_of_list() {
        console.log(this.size);
    }
 
 
    printList() {
        var curr = this.head;
        var str = "";
        while (curr) {
            str += curr.element + " ";
            curr = curr.next;
        }
        console.log(str);
    }
 
}
 
var ll = new LinkedList();
 
console.log(ll.isEmpty());
 
ll.add(10);
 
ll.printList();
 
console.log(ll.size_of_list());
 
ll.add(20);
ll.add(30);
ll.add(40);
ll.add(50);
 
ll.printList();
 
console.log("is element removed ?" + ll.removeElement(50));
 
ll.printList();
 
console.log("Index of 40 " + ll.indexOf(40));
 
ll.insertAt(60, 2);
 
ll.printList();
 
console.log("is List Empty ? " + ll.isEmpty());
 
console.log(ll.removeFrom(3));
 
ll.printList();