using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Threading.Tasks;

using Exercice_Task_CS;

namespace Exercice_Task_CS {
    class Program {
        static void Main(string[] args) {
            aStack Opd = new aStack(true);
            aStack Opt = new aStack(true);
            Console.Clear();
            Console.WriteLine("Hey there! welcome to Aland Calculator.\n");
            //string input = null;
            //int numericValue;
            //while (input != "=") {
            //    input = Console.ReadLine();
            //    if (int.TryParse(input, out numericValue)) {
            //        Console.WriteLine("the input is accepted Opd " + input);
            //        Opd.push(input);

            //    } else if (input == "%" || input == "/" || input == "*" || input == "+" || input == "-") {
            //        Console.WriteLine("the input is accepted Opt " + input);
            //        Opt.push(input);

            //    } else {
            //        Console.WriteLine("the input is not accepted");
            //    }
            //}
            //int i = 0;

            //while (Opt.get(i) != null) {
            //    Console.WriteLine("the input is accepted Opt " + Opt.get(i));

            //    i++;
            //} while (Opd.get(i) != null) {
            //    Console.WriteLine("the input is accepted Opd " + Opd.get(i));

            //    i++;
            //}
            //while (Opd.peek() != null || Opt.peek() != null) {
            //    string num2 = Opd.pop();
            //    string num1 = Opd.pop();
            //    if (num1 == null || num2 == null) {
            //        Console.WriteLine("fehler");
            //        return;
            //    }
            //    int opd2 = int.Parse(num2);
            //    int opd1 = int.Parse(num1);

            //    if (IsInOpdStackAddition()) {

            //    } else if (IsInOpdStackDivision()) {

            //    }else {

            //    }

            //}

            //bool IsInOpdStackAddition() {
            //    int i = 0;

            //    while (Opt.get(i) != null) {
            //        if (Opt.get(i) == "*") {
            //            return true;
            //        }
            //        i++;
            //    }
            //    return false;
            //}

            //bool IsInOpdStackDivision() {
            //    int i = 0;

            //    while (Opt.get(i) != null) {
            //        if (Opt.get(i) == "/") {
            //            return true;
            //        }
            //        i++;
            //    }
            //    return false;
            //}

            //queue que = new queue(true);
            //map<string, string> point = new map<string, string>();

            //for (int i = 0; i < 10; i++) {
            //    //aSt.push(i);
            //    que.Enqueue($"program {i}");
            //    Console.WriteLine($"program {i}");

            //}

            //for (int i = 0; i < 10; i++) {
            //    Console.WriteLine(que.Dequeue());

            //}



            //try {

            //    for (int i = 0; i < 100; i++) {
            //        try {

            //            aSt.push($"program {i}");

            //        } catch {
            //            throw;

            //        }

            //    }

            //    for (int i = 0; i < 10; i++) {
            //        Console.WriteLine(aSt.pop());
            //    }

            //} catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}


            //while (true) {

            //    Console.WriteLine("Add: 0 \n" +
            //                      "Get: 1 \n" +
            //                      "GetByIndex: 2");
            //    string swith = Console.ReadLine();
            //    switch (swith) {
            //        case "0":
            //            Console.WriteLine("Add \n" +
            //                              "key");
            //            string input = Console.ReadLine();
            //            Console.WriteLine("Value");
            //            string input2 = Console.ReadLine();
            //            Console.WriteLine(point.Add(input, input2));
            //            break;
            //        case "1":
            //            Console.WriteLine("Get \n" +
            //                              "Value");
            //            string value = Console.ReadLine();
            //            try {

            //                Console.WriteLine(point.Get(value).Value);
            //            } catch (Exception ex) {
            //                Console.WriteLine(ex.Message);
            //            }
            //            string s = Console.ReadLine();
            //            break;
            //        case "2":
            //            Console.WriteLine("GetByIndex \n" +
            //                              "Index");
            //            string index = Console.ReadLine();

            //            try {
            //                Console.WriteLine(point.GetByIndex(int.Parse(index)).Key);
            //            } catch (Exception ex) {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;
            //    }
            //}


            // C# value und referenze Types
            // Value-Types: int, float, double, bool, string... Basisdatentypen
            // Reference-Types: objekte, new Klass() 
            //int result = sum(1, 1);
            //Console.WriteLine(result);
            //int retValue = 0;
            //berechnen(1, 1, ref retValue);
            //Console.WriteLine(retValue);


            //static int sum(int z1, int z2) {
            //    return z1 + z2;
            //}

            //static void berechnen(int z1, int z2, ref int retVal) {
            //    int result = z1 + z2;
            //    Console.WriteLine(result);
            //    retVal = result;
            //}


            //Werkstatt<IAuto> allgemeineWerkstatt = new Werkstatt<IAuto>();
            //BenzinAutoWerkstatt<Bugatti> BugattiWerkstatt = new BenzinAutoWerkstatt<Bugatti>();
            //BenzinAutoWerkstatt<IBenzinAuto> benzinAutoWerkstatt = new BenzinAutoWerkstatt<IBenzinAuto>();
            //BenzinAutoWerkstatt<IHybridAuto> benzinAutoWerkstatt1 = new BenzinAutoWerkstatt<IHybridAuto>();


            //Console.WriteLine(statt.Info());
            //Bugatti bugatti = new Bugatti();



            //LinkedList it = new LinkedList();
            //for (int i = 0; i < 10; i++) {
            //    Console.WriteLine(it.Add($"ff{i}"));

            //}
            //Console.WriteLine();
            //Console.WriteLine(it.Get(2));
            //Console.WriteLine();
            //Console.WriteLine(it.Gets());
            //Console.WriteLine();

            //for (int i = 0; i < 15; i++) {
            //    Console.WriteLine(it.Remove($"ff{i}"));
            //}


            //queueWithList quels = new queueWithList();

            //for (int i = 0; i < 100; i++) {
            //    //aSt.push(i);
            //    quels.Enqueue($"program {i}");
            //    Console.WriteLine($"program {i}");

            //}

            //for (int i = 0; i < 120; i++) {
            //    Console.WriteLine(quels.Dequeue());

            //}

            StackWithList StLs = new StackWithList();

            for (int i = 0; i < 10; i++) {
                //aSt.push(i);
                StLs.push($"program {i}");
                Console.WriteLine($"program {i}");

            }

            for (int i = 0; i < 12; i++) {
                Console.WriteLine(StLs.pop());

            }

            //aStack aSt = new aStack(false);


            //try {

            //    for (int i = 0; i < 5; i++) {
            //        try {
            //            aSt.push($"program {i}");
            //            Console.WriteLine($"program {i}  con");
            //        } catch {
            //            throw;
            //        }
            //    }
            //    for (int i = 0; i < 10; i++) {
            //        Console.WriteLine(aSt.pop());
            //    }

            //} catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
