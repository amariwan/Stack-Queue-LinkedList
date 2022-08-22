using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Task_CS {
    class StackWithList {
        
        LinkedList it = new LinkedList();
        static int top = 0;
        
        public void push(string Wert) {
            it.Add(Wert);
            top++;

        }

        public string pop() {
            if (top <= 0) {
                //throw new Exception("Stack ist leer");
                return null;
            } else {
                top--;
            }
            return it.Get(top);
        }

        public string peek() {
            int temp = top;

            if (top <= 0) {
                //throw new Exception("Stack ist leer");
                return null;
            } else {
                temp = temp - 1;
            }
            return it.Get(temp);
        }
        public string get(int i) {
            if (top <= 0) {
                //throw new Exception("Stack ist leer");
                return null;
            } else {
                return it.Get(i);
            }
        }
    }
}
