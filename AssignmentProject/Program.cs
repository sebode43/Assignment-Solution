using System;

namespace AssignmentProject {
    class Program {
        static void Main(string[] args) {
            var sum = 1;
            for (var index = 1; index <= 10; index++) {
                sum *= index;
                }
            Console.WriteLine($"Total is {sum}");

            //alternative solution
            sum = 1;
            var nbr = 1;
            while (nbr <= 10) {
                sum *= nbr;
                nbr++;
                }
            Console.WriteLine($"Total is {sum}");
        }
    }
}
