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

    Add(element) {
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

    Get(element) {
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

    Gets() {
        var current = this.head;

        while (current != null) {
            console.log(current.element);
            current = current.next;
        }
        return "leer";
    }
}

var ll = new LinkedList();

for (var i = 0; i < 10; i++) {
    ll.Add(i);
}


console.log(ll.Get(50));
console.log(ll.Gets());