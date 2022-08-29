class Stack: 
    def __init__(self):
        self.stack = []
        self.head = 0
        self.top = 0 
    
    def push(self, value):
        self.stack[self.top] = value
        self.top + 1
    
    def pop(self):
        if self.top <= 0:
            print("Stack ist Leer")
            return 0 
        self.top - 1
        return self.stack[self.pop]

obj = Stack()
obj.push(1)
obj.pop()