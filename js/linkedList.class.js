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
                console.log(current)
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

    RemoveOF(index) {
        if (index < 0 || index >= this.size)
            return console.log("Bitte geben einen gültigen Index ein");
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


    Gets() {
        var current = this.head;

        while (current != null) {
            console.log(current.element);
            current = current.next;
        }
        return "leer";
    }

    size() {
        let count = 0;
        let node = this.head;
        while (node) {
            count++;
            node = node.next
        }
        return count;
    }

    Clear() {
        this.head = null;

    }

    GetLast() {
        let lastNode = this.head;
        if (lastNode) {
            while (lastNode.next) {
                lastNode = lastNode.next
            }
        }
        return lastNode
    }

    GetFirst() {
        return this.head;
    }

    isEmpty() {
        return this.size == 0;
    }

    size_of_list() {
        console.log(this.size);
    }
}

var ll = new LinkedList();

for (var i = 0; i < 10; i++) {
    ll.Add(i);
}
console.log("is element removed ?" + ll.removeElement(50));

console.log(ll.Get(50));
console.log(ll.Gets());
console.log("ist die Liste leer? " + ll.isEmpty());
