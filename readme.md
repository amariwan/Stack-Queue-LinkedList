# Exercice Task CS


Stack und Queue in LinkedList C#

I know there are many people already writing about data structures topics out there, but I believe the best and fast way to learn for me is to write an article about it. For that reason, I decided to have a journal of each data structure topic.

Data structures are crucial topics that you often get asked in the technical interview but also help your problem-solving skills in algorithms. There are many ways of solving an algorithm question to get the result. Sometimes you could solve it the hard or easy way, and it all depends on your data structures knowledge. Or sometimes, the solution is not optimized due to not knowing the fundamental concept of data structures. So, let’s start learning the two most common data structures in computer science Stack and Queue and LinkedList.


# What is a Stack?

The last element added to the stack will be the first element removed from the stack. Last In First Out (LIFO) method mantra is what stack is known. In real life, examples of the stack could be a pile of plates, books, and papers. To get the middle of a collection of the book, you will need to remove the book on top of it first. It means that the last book that comes in a pile will be the first book to get removed from the collection (the top of the book). 

A stack has two main operations that take place only at the beginning of the stack: Push and Pop. The push operation places an element at the top of the stack, while the pop operation removes an element from the top of the stack.

The name stack comes from the analogy to a series of physical objects, e.g. DVDs, books, stacked on top of each other.

A stack has many applications. For example, the easiest way is to reverse a word. To do this, you push a word letter by letter into the stack and get the letters from the stack. or Stacks used where:

- Managing function invocations ,recursion function
- Undo/Redo, (those “control + z” or “command + z”)
- Routing route(the history object) in front end framework such as react

# push()-Method

The push() method can be used to add one or more elements to the end of the array. The push() method returns the value of the length property, which specifies the number of elements in the array.

The following figure illustrates each step in the above script.

![l](img/JavaScript-Stack-Push-Operations.png)

Initially the stack is empty. Each time call the push() method to add a number to the stack. After 5 calls the stack has 5 elements.

# pop()-Method


The pop()method removes the element at the end of the array and returns the element to the caller. If the array is empty, the pop() method returns undefined.

![t](img/JavaScrippt-Stack-Pop.png)

Initially the stack has 5 elements. The pop() method removes the element at the end of the array, i.e. at the top of the stack, one by one. After five operations the stack is empty.

----

Now that we understand the concept let’s implement a stack with an array. There is more that one way of achieving a stack.

Here is my version:


```C#
    class Stack {
        public bool makeBigger;
        public aStack(bool _makeBigger) {
            makeBigger = _makeBigger;
        }

        aArray<string> aAr = new aArray<string>();

        static string[] stack = new string[10];
        static int top = 0;
        public void push(string Wert) {
            if (top >= stack.Length) {
                if (makeBigger == true) {
                    stack = aAr.IncreaseSize(stack, 10);
                    stack[top] = Wert;
                    top++;
                    return;
                }

                throw new Exception("Stack is full");
            }
            stack[top] = Wert;
            top++;

        }

        public string pop() {
            if (top <= 0) {
                throw new Exception("Stack is full");
                return null;
            }
            top--;
            return stack[top];
        }

        public string peek() {
            int temp = top;

            if (top <= 0) {
                throw new Exception("Stack is full");
                return null;
            } else {
                temp = temp - 1;
            }
            return stack[temp];
        }
        public string get(int i) {
            if (top <= 0) {
                throw new Exception("Stack is full");
                return null;
            } else {
                return stack[i];
            }
        }
        public void clean(){
            stack = new string[10];
        }
    }
```