using System;

namespace Frågesport_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            string answer4 = "";
            string answer5 = "";
            int points = 0;

            //Intro

            Console.WriteLine("Hello and welcome to the game show RANDOM QUESTIONS OF VARYING DIFFICULTY!");
            Console.ReadLine();

            Console.WriteLine("As you can see there is something called POINTS. This shows how many points you currently have.");
            Console.WriteLine("Each question answered correctly will result in 1 additional point being added to the POINTS counter.");
            Console.WriteLine("Your goal is to reach 5 points in total. LETS GO!");
            Console.WriteLine("Also remember to turn off caps lock, capital letters are not counted as valid answeres");
            Console.ReadLine();

            //Question 1

            Console.WriteLine("Continue the lyrics!");
            Console.WriteLine("I'M ON A HIGH WAY TO ____");
            Console.WriteLine("a: HEAVEN!");
            Console.WriteLine("b: PURGATORY!");
            Console.WriteLine("c: HELL!");
            answer1 = Console.ReadLine();

            while (answer1 != "c")
            {
                Console.WriteLine("Uh oh, that was an incorrect or invalid answere! Please try again");
                Console.WriteLine("Continue the lyrics!");
                Console.WriteLine("I'M ON A HIGH WAY TO ____");
                Console.WriteLine("a: HEAVEN!");
                Console.WriteLine("b: PURGATORY!");
                Console.WriteLine("c: HELL!");
                answer1 = Console.ReadLine();
            }

            if (answer1 == "c")
            {
                Console.WriteLine("Correct! You have gained 1 additionl point, awesome! Only 1 points left");
                points = points + 1;
                Console.WriteLine("POINTS: " + points);
            }
            Console.ReadLine();

            //Question 2

            Console.WriteLine("Which is the biggest feline animal on earth?");
            Console.WriteLine("a: the tiger");
            Console.WriteLine("b: the lion");
            Console.WriteLine("c: the leopard");
            answer2 = Console.ReadLine();

            while (answer2 != "a")
            {
                Console.WriteLine("Uh oh, that was an incorrect or invalid answere! Please try again");
                Console.WriteLine("Which is the biggest feline animal on earth?");
                Console.WriteLine("a: the tiger");
                Console.WriteLine("b: the lion");
                Console.WriteLine("c: the leopard");
                answer2 = Console.ReadLine();
            }
            if (answer2 == "a")
            {
                Console.WriteLine("Correct! You have gained 1 additionl point, awesome! Only 1 points left");
                points = points + 1;
                Console.WriteLine("POINTS: " + points);
            }
            Console.ReadLine();

            //Question 3

            Console.WriteLine("Question 3: What color is a pear?");
            Console.WriteLine("a: Blue");
            Console.WriteLine("b: Red");
            Console.WriteLine("c: Green");
            answer3 = Console.ReadLine();

            while (answer3 != "c")
            {
                Console.WriteLine("Uh oh, that was an incorrect or invalid answere! Please try again");
                Console.WriteLine("What color is a pear?");
                Console.WriteLine("a: Blue");
                Console.WriteLine("b: Red");
                Console.WriteLine("c: Green");
                answer3 = Console.ReadLine();
            }
            if (answer3 == "c")
            {
                Console.WriteLine("Correct! You have gained 1 additionl point, awesome! Only 1 points left");
                points = points + 1;
                Console.WriteLine("POINTS: " + points);
            }
            Console.ReadLine();

            //Question 4

            Console.WriteLine("Who is the author of and writer to the famous book series Harry Potter?");
            Console.WriteLine("a: J.R.R. Tolkien");
            Console.WriteLine("b: J.K Rowling");
            Console.WriteLine("c: Hirihiko Araki");
            answer4 = Console.ReadLine();

            while (answer4 != "b")
            {
                Console.WriteLine("Uh oh, that was an incorrect or invalid answere! Please try again");
                Console.WriteLine("Who is the author of and writer to the famous book series Harry Potter?");
                Console.WriteLine("a: J.R.R. Tolkien");
                Console.WriteLine("b: J.K Rowling");
                Console.WriteLine("c: Hirihiko Araki");
                answer4 = Console.ReadLine();
            }
            if (answer4 == "b")
            {
                Console.WriteLine("Correct! You have gained 1 additionl point, awesome! Only 1 points left");
                points = points + 1;
                Console.WriteLine("POINTS: " + points);
            }
            Console.ReadLine();

            //Question 5

            Console.WriteLine("What is 8^2 + 6 / 7");
            Console.WriteLine("a: 10");
            Console.WriteLine("b: 15");
            Console.WriteLine("c: 12");
            answer5 = Console.ReadLine();

            while (answer5 != "a")
            {
                Console.WriteLine("Oh, that was an incorrect or invalid answere! Please try again friend.");
                Console.WriteLine("What is 8^2 + 6 / 7");
                Console.WriteLine("a: 10");
                Console.WriteLine("b: 15");
                Console.WriteLine("c: 12");
                answer5 = Console.ReadLine();
            }
            if (answer5 == "a")
            {
                Console.WriteLine("Correct! You have gained 1 additionl point, awesome! Only 1 points left");
                points = points + 1;
                Console.WriteLine("POINTS: " + points);
            }
            Console.ReadLine();

            //Finish

            if (points == 5)
            {
                Console.WriteLine("Hurray! You've reached the goal of 5 points, that i awesome! Great job friend :)");
            }
            Console.ReadLine();
        }
    }
}
