using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyLittleCreatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyLittleCreatures
            //Programmed by Elliot Thacker-Hopkins, 2014

            bool menuLoop = true;
            ConsoleKeyInfo menuOption;

            Console.WindowHeight = 29; //Set window height of MyLittleCreatures to 29 lines
            
            do
            {
                Console.Clear(); //clears screen of any text displayed in previous loop

                Console.ForegroundColor = ConsoleColor.White;
                //Overrides C♯'s default text colour of grey

                ////////////////

                printTitle();
                Thread.Sleep(500); //Delay of 500 milliseconds (half a second)
                Console.WriteLine("\nMain Menu");


                Console.WriteLine("\nSelect an option:");

                ////////////////

                //Options
                Console.ForegroundColor = ConsoleColor.Green; //Sets text colour to green
                Console.Write("\n[1]");
                Console.ForegroundColor = ConsoleColor.White; //Sets text colour back to white
                Console.Write(" Create ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Wufa");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Cyan; //Sets text colour to cyan
                Console.Write("\n[2]");
                Console.ForegroundColor = ConsoleColor.White; //Sets text colour back to white
                Console.Write(" Create ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Tweta");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Yellow; //Sets text colour to green
                Console.Write("\n[3] Help");

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red; //Sets text colour to green
                Console.Write("\n[x] Exit ");
                Console.ForegroundColor = ConsoleColor.White; //Sets text colour back to white
                Console.Write("My Little Creatures");

                Console.WriteLine();
                Console.WriteLine();

                menuOption = Console.ReadKey(); //Takes menu option from key press input

                ////////////////

                switch (menuOption.KeyChar) //Takes chosen menu option into case statement
                {
                    case '1':
                        sub_Wufa newWufa = new sub_Wufa(); //Creates new Wufa
                        wufaInteraction(newWufa); //Passes newWufa into main interaction function
                        break; //Ends case 1

                    case '2':
                        sub_Tweta newTweta = new sub_Tweta(); //Creates new Tweta
                        twetaInteraction(newTweta); //Passes newTweta into main interaction function
                        break; //Ends case 2

                    case '3':
                        help();
                        break; //Ends case 3

                    case 'x':
                        closeProgram();
                        break;
                }

            }
            while (menuLoop == true); //Loop menu whilst loop flag is set to true

            Console.Clear(); //Clears screen

        }

        public static void printTitle() //Prints "My Little Creatures" to screen
        {
            string Title = "MyLittleCreatures";
            int count;
            int colourCount = 0;

            ConsoleColor[] arr_colours = new ConsoleColor[] {ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Cyan,
                ConsoleColor.Green};

            for (count = 0; count < Title.Length; count++)
            {

                if (colourCount == (arr_colours.Length)) //If the colourCount reaches the end of the colour arrray
                {
                    colourCount = 0; //Reset colourCount to 0
                }

                Console.ForegroundColor = arr_colours[colourCount]; //Set text (foreground) colour from colour array

                if ((count == 2) || (count == 8)) //If the character is "L" or "C"
                {
                    Console.Write(" " + Title.ElementAt(count)); //Write a space as well as the character for formatting
                }
                else
                {
                    Console.Write(Title.ElementAt(count)); //Otherwise print solely the character
                }

                Thread.Sleep(10); //Delay each character by 10 milliseconds (1/100th of a second)

                colourCount++; //Increment colour count through colour array by one
            }

            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-------------------");
        }

        public static void printTitleQuick() //Prints "My Little Creatures" to screen
        {
            string Title = "MyLittleCreatures";
            int count;
            int colourCount = 0;

            ConsoleColor[] arr_colours = new ConsoleColor[] {ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Cyan,
                ConsoleColor.Green};

            for (count = 0; count < Title.Length; count++)
            {

                if (colourCount == (arr_colours.Length)) //If the colourCount reaches the end of the colour arrray
                {
                    colourCount = 0; //Reset colourCount to 0
                }

                Console.ForegroundColor = arr_colours[colourCount]; //Set text (foreground) colour from colour array

                if ((count == 2) || (count == 8)) //If the character is "L" or "C"
                {
                    Console.Write(" " + Title.ElementAt(count)); //Write a space as well as the character for formatting
                }
                else
                {
                    Console.Write(Title.ElementAt(count)); //Otherwise print solely the character
                }

                colourCount++; //Increment colour count through colour array by one
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-------------------");
        }

        public static void wufaInteraction(sub_Wufa newWufa) //Main interface for interacting with the Wufa
        {
            ConsoleKeyInfo nameYN, menuOption; //Used for single key press actions
            bool endWufa = false;

            do
            {
                Console.Clear(); //Clears screen
                newWufa.setName(); //Runs setName function; asks for Wufa's name
                Console.Write("Your Wufa's name is {0}, correct? Y/N ", newWufa.getName()); //
                nameYN = Console.ReadKey(); //Reads input from key press
            }
            while (nameYN.KeyChar != 'y'); //Repeats this whilst the user has pressed y (confirmed that the name is correct)

            do
            {

                do
                {
                    Console.Clear();
                    printTitleQuick();
                    newWufa.printStatus(); //Prints status of Wufa to screen

                    Console.WriteLine("\n\nWhat will you do?");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n[1]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Feed {0}", newWufa.getName());

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n[2]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Put {0} to bed", newWufa.getName());

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[3] ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Play with {0}", newWufa.getName());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n[4]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Take {0} for a walk", newWufa.getName());

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n[5]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Scold {0}!", newWufa.getName());

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n[6]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Give {0} a bone", newWufa.getName());

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n[x]");
                    Console.ForegroundColor = ConsoleColor.White;                    
                    Console.Write(" Exit to the main menu");

                    Console.ForegroundColor = ConsoleColor.Black;
                    menuOption = Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while ((menuOption.KeyChar != '1') && (menuOption.KeyChar != '2') && (menuOption.KeyChar != '3') &&
                (menuOption.KeyChar != '4') && (menuOption.KeyChar != '5') && (menuOption.KeyChar != '6')
                    && (menuOption.KeyChar != 'x'));
                //Loop whilst the key press is none of the valid options; 1, 2, 3, 4, 5, 6, x

                switch (menuOption.KeyChar)
                {

                    case '1':
                        newWufa.feedCreature(); //Run feeding function
                        break;

                    case '2':
                        newWufa.creatureSleep(); //Run sleeping function
                        break;

                    case '3':
                        newWufa.creaturePlay(); //Run playing function
                        break;

                    case '4':
                        newWufa.walk(); //Run walking function
                        break;

                    case '5':
                        newWufa.scold(); //Run scolding function
                        break;

                    case '6':
                        newWufa.giveBone(); //Give Wufa bone
                        break;

                    case 'x':
                        ConsoleKeyInfo yesNo;
                        
                        
                        Console.Clear();
                        Console.WriteLine("Are you sure you wish to stop interacting with {0}?", newWufa.getName());
                        Thread.Sleep(1500);
                        Console.WriteLine("Once you do, you will not be able to see {0} again.", newWufa.getName());
                        //Explains loss of Wufa details once interaction is ended
                        Thread.Sleep(1500);
                        Console.Write("\nLeave {0}? Y/N ", newWufa.getName());
                        
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Black; //Hides character from screen
                            Console.Write("\b");
                            yesNo = Console.ReadKey();
                        }
                        while ((yesNo.KeyChar != 'y') && (yesNo.KeyChar != 'n'));

                        if (yesNo.KeyChar == 'y')
                        {
                            endWufa = true;
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        break;
                }

            }
            while (endWufa == false);

        } //END OF FUNCTION

        public static void twetaInteraction(sub_Tweta newTweta) //Main interface for interacting with the Wufa
        {
            ConsoleKeyInfo nameYN, menuOption; //Used for single key press actions
            bool endTweta = false;

            do
            {
                Console.Clear(); //Clears screen
                newTweta.setName(); //Runs setName function; asks for Wufa's name
                Console.Write("Your Tweta's name is {0}, correct? Y/N ", newTweta.getName()); //
                nameYN = Console.ReadKey(); //Reads input from key press
            }
            while (nameYN.KeyChar != 'y'); //Repeats this whilst the user has pressed y (confirmed that the name is correct)

            do
            {

                do
                {
                    Console.Clear();
                    printTitleQuick();
                    newTweta.printStatus(); //Prints status of Wufa to screen

                    Console.WriteLine("\n\nWhat will you do?");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n[1]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Feed {0}", newTweta.getName());

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n[2]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Put {0} to bed", newTweta.getName());

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n[3] ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Let {0} fly around", newTweta.getName());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n[4] ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Give {0} some seed", newTweta.getName());

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\n[x]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Exit to the main menu");

                    Console.ForegroundColor = ConsoleColor.Black;
                    menuOption = Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while ((menuOption.KeyChar != '1') && (menuOption.KeyChar != '2') && (menuOption.KeyChar != '3') &&
                (menuOption.KeyChar != '4') && (menuOption.KeyChar != 'x'));
                //Loop whilst the key press is none of the valid options; 1, 2, 3, 4, 5, 6, x

                switch (menuOption.KeyChar)
                {

                    case '1':
                        newTweta.feedCreature(); //Run feeding function
                        break;

                    case '2':
                        newTweta.creatureSleep(); //Run sleeping function
                        break;

                    case '3':
                        newTweta.fly(); //Run flying function
                        break;

                    case '4':
                        newTweta.giveSeed(); //Run give seed function
                        break;

                    case 'x':
                        ConsoleKeyInfo yesNo;


                        Console.Clear();
                        Console.WriteLine("Are you sure you wish to stop interacting with {0}?", newTweta.getName());
                        Thread.Sleep(1500);
                        Console.WriteLine("Once you do, you will not be able to see {0} again.", newTweta.getName());
                        //Explains loss of Tweta details once interaction is ended
                        Thread.Sleep(1500);
                        Console.Write("\nLeave {0}? Y/N ", newTweta.getName());

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Black; //Hides character from screen
                            Console.Write("\b");
                            yesNo = Console.ReadKey();
                        }
                        while ((yesNo.KeyChar != 'y') && (yesNo.KeyChar != 'n'));

                        if (yesNo.KeyChar == 'y')
                        {
                            endTweta = true;
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        break;
                }

            }
            while (endTweta == false);

        } //END OF FUNCTION

        public static void help()
        {
            Console.Clear();
            Console.WriteLine("MyLittleCreatures has you interact with either a Wufa or a Tweta. Because you");
            Console.WriteLine("are looking after them, you can feed them, put them sleep, or excercise them.");
            Console.WriteLine("\nWhen looking after your Creature, you will have different options");
            Console.WriteLine("depending on whether they are a Tweta or Wufa.");
            Console.WriteLine("\nWhen interacting with your Creature, the options will be laid out like this:");
            Console.WriteLine("\n[1] Option 1");
            Console.WriteLine("[2] Option 2");
            Console.WriteLine("[3] Option 3");
            Console.WriteLine("\nPress the corresponding key to do that option. For instance, the option marked");
            Console.WriteLine("[1] requires you to press 1.");
            Console.WriteLine("\nHave fun with your Creature!");
            Console.WriteLine("\nPress ENTER to go back to the main menu.");
            Console.ReadLine();
        }

        public static void closeProgram()
        {
            ConsoleKeyInfo closeYN; //Key press Y/N ("yes"/"no") to validate option to close

            do
            {
                Console.Clear();
                Console.WriteLine("Are you sure you wish to close the program? Y/N");
                Console.ForegroundColor = ConsoleColor.Black; //Hides input from screen; improves aesthetics
                closeYN = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White; //Returns text color to white
            }
            while ((closeYN.KeyChar != 'y') && (closeYN.KeyChar != 'n')); //Whilst user has pressed neither "y" or "n"

            switch (closeYN.KeyChar) //Takes value of closeYN into case statement
            {
                case 'y': //if "y"
                    Console.WriteLine("\nThank you for using this program. It will now close."); //Displays closing message
                    Thread.Sleep(3000); //Delay; 3000 milliseconds is 3 seconds
                    Environment.Exit(0); //Ends the program
                    break;

                case 'n': //if "n"
                    break;
                /* This case merely "breaks" because the program will thus loop back into the main menu, meaning that
                 * there is no need for anything else to occur when "n" is pressed. */
            }
        }


    }
}
