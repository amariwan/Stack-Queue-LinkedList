class aStack {
    constructor() {
        this.stack = {};
        this.head = 0;
        this.top = 0;
    }

    push(Wert) {
        if (this.top >= stack.length) {
            console.log("Stack ist voll");
        }
        this.stack[this.top] = Wert;
        this.top++;
    }

    pop() {
        if (this.top <= 0) {
            console.log("Stack ist Leer");
            return null;
        } else {
            this.top--;
        }
        return this.stack[this.top];
    }

    peek() {
        var temp = top;

        if (this.top <= 0) {
            console.log("Stack ist Leer");
            return null;
        } else {
            temp = temp - 1;
        }
        return this.stack[temp];
    }
    get(i) {
        if (top <= 0) {
            console.log("Stack ist Leer");
            return null;
        } else {
            return this.stack[i];
        }
    }
}
