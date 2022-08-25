class Stack {
    constructor() {
        this.stack = [];
        this.head = 0;
        this.top = 0;
    }

    Push(Wert) {
        this.stack[this.top] = Wert;
        this.top++;
    }

    Pop() {
        if (this.top <= 0) {
            console.log("Stack ist Leer");
            return null;
        }
        this.top--;
        return this.stack[this.top];
    }

    Peek() {
        var temp = top;

        if (this.top <= 0) {
            console.log("Stack ist Leer");
            return null;
        } else {
            temp = temp - 1;
        }
        return this.stack[temp];
    }
    Get(i) {
        if (top <= 0) {
            console.log("Stack ist Leer");
            return null;
        } else {
            return this.stack[i];
        }
    }
}
let s = new Stack();
for (var i = 0; i < 10; i++) {
    s.Push(i);
    console.log("Stack push(" + i + ")");
}
for (var i = 0; i < 10; i++) {
    console.log("Stack pop: " + s.Pop());
}
