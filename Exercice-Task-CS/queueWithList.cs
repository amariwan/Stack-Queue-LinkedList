using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isGited;

namespace isGited {
    class queueWithList {
        LinkedList it = new LinkedList();

        aArray<string> aAr = new aArray<string>();

        //static string[] array = new string[5];

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
        //private int Move(int counter, int length) {
        //    if (counter > length - 1) {
        //        return 0;
        //    }
        //    return ++counter;
        //}
    }
}