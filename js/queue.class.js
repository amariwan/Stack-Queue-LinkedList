class Queue {
    constructor(makeBigger) {
        this.array = {};
        this.head = 0;
        this.tail = 0;
        this.makeBigger = makeBigger;
    }

    Move(counter, length) {
        if (counter > length - 1) {
            return 0;
        }
        return ++counter;
    }

    Enqueue(element) {
        if (this.Move(this.tail, this.array.length) == this.head) {
            if (this.makeBigger == true) {
                this.array = aAr.IncreaseSize(this.array, 10);
                this.array[this.tail] = element;
                this.tail = Move(this.tail, this.array.length);
                return;
            }
            console.log("Voll");
            return;
        } else {
            this.array[this.tail] = element;
            this.tail = this.Move(this.tail, this.array.length);
        }
    }

    Dequeue() {
        if (this.tail == this.head) {
            return "leer";
        }
        const item = this.array[this.head];
        delete this.array[this.head];
        this.head = this.Move(this.head, this.array.length);
        return item;
    }

    Peek() {
        return this.array[this.head];
    }


    get length() {
        return this.tail - this.head;
    }
    get isEmpty() {
        return this.length === 0;
    }
}

let q = new Queue(false);
for (var i = 0; i < 10; i++) {
    q.Enqueue(i);
    console.log("Queue Enqueue(" + i + ")");

}

console.log(q.Peek());

console.log(q.length);

while (!q.isEmpty) {
    console.log("Queue Dequeue: " + q.Dequeue());
}
