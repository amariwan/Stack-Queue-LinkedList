using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice_Task_CS;

namespace Exercice_Task_CS {
    class queueWithList {
        LinkedList it = new LinkedList();
        static int tail = 0;
        static int head = 0;

        public void Enqueue(string Wert) {
            it.Add(Wert);
            tail++;
        }

        public string Dequeue() {
            string answer = "";
            if (tail == head) {
                return "leer";
            }
            answer = it.Get(head);
            head ++;
            return answer;
        }
    }
}