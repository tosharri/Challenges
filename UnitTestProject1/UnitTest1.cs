using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Week1Challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string firstName = "Toni";
            string lastName = "Harris";
            int age = 29;
            //declare an array that includes
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age%7);

        }
        [TestMethod]
        public void Array()
        {
            string[] movie = { "Batman", "Die Hard", "Inception", "Little Women" };

        }
        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();  //using the generic collection of items (ctrl + '.')
            DateTime now = DateTime.Now;
            listOfDates.Add(now);
            listOfDates.Add(new DateTime(2020,12,25));
            listOfDates.Add(new DateTime(2020, 10, 6));
            listOfDates.Add(new DateTime(2020, 6, 16));
        }
        [TestMethod]
        public void howMuchSleepTime()
        {
            Console.WriteLine("How many hours of sleep do you get per night?";
            int hours = 4;
            if (hours >= 10)
            {
                Console.WriteLine("Wow that's a lot of sleep");
            }
            else if (hours > 8 && hours < 10){
                Console.WriteLine("You should be well rested");
            }
            else if (hours >=8 && hours > 4)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
            
        }
        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay";
            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "Good":
                    Console.WriteLine("A Good day is way better than a bad one");
                    break;
                case "Okay":
                    Console.WriteLine("Hopefully it will get better from here");
                    break;
                case "bad":
                    Console.WriteLine("aww, there's always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("wow I don't know what to say");
                    break;
            }
        }
        [TestMethod]
        public void maryPoppins()
        {
            string name = "supercalifragilisticexpialidocious";
            foreach(char letter in name)
            {
                Console.WriteLine(letter);
            }
            foreach(char letter in name)
            {
                if (letter = 'i') Console.WriteLine("I");
                else Console.WriteLine("Not an 'I'");
            }
        }

    }
}
