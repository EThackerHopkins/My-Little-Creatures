using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyLittleCreatures
{
    class sup_Creature
    {
        //Programmed by Elliot Thacker-Hopkins, 2014

        //"sup" identifies it as a superclass. C♯ itself does not require this distinction, but it is added for readability.

        //Attributes

        protected string name; //Name of creature

        protected int energy; //Creature's energy
        protected const int minEnergy = 0; //Minimum energy a Creature can have
        protected const int maxEnergy = 20; //Maximum energy a Creature can have

        protected int happiness; //Creature's happiness
        protected const int minHappiness = 0; //Minimum happiness a Creature can have
        protected const int maxHappiness = 20; //Maximum happiness a Creature can have

        protected int hunger; //Creature's hunger
        protected const int minHunger = 0; //Minimum hunger a Creature can have
        protected const int maxHunger = 20; //Maximum hunger a Creature can have

        protected int tiredness; //Creature's tiredness
        protected const int minTiredness = 0; //Minimum tiredness a Creature can have
        protected const int maxTiredness = 20; //Maximum tiredness a Creature can have

        /*WHEN PRINTING STATS TO SCREEN:
         * Energy is Yellow
         * Happiness is Cyan
         * Hunger is Magenta
         * Tiredness is Blue    */

        ////////////////

        //Get methods

        public sup_Creature() //Constructor method
        {
            energy = 10;
            happiness = 10;
            hunger = 8;
            tiredness = 4;

            //Sets default values for attributes in all Creatures. These values change depending on the user's interaction.
        }

        public string getName() //Gets creature's name value
        {
            Console.ForegroundColor = ConsoleColor.White; //Forces text colour to be white whenever name is displayed
            return name;
        }

        public int getEnergy()
        {
            Console.ForegroundColor = ConsoleColor.White; //Forces text colour to be white whenever energy is displayed
            return energy;
        }

        public int getHappiness()
        {
            Console.ForegroundColor = ConsoleColor.White; //Forces text colour to be white whenever happiness is displayed
            return happiness;
        }

        public int getHunger()
        {
            Console.ForegroundColor = ConsoleColor.White; //Forces text colour to be white whenever hunger is displayed
            return hunger;
        }

        public int getTiredness()
        {
            Console.ForegroundColor = ConsoleColor.White; //Forces text colour to be white whenever tiredess is displayed
            return tiredness;
        }

        ////////////////

        //Set methods

        public void setName() //User inputs name method
        {
            Console.Write("Enter your creature's name: ");
            name = Console.ReadLine();

        }

        ////////////////
        
        //Other methods

        public virtual void printStatus()
        {
            Console.WriteLine("\nStatus of {0}:", getName());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nEnergy");
            Console.Write(": {0}", getEnergy()); //Writes Creature's energy to screen

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nHappiness");
            Console.Write(": {0}", getHappiness()); //Writes Creature's happiness to screen

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\nHunger");
            Console.Write(": {0}", getHunger()); //Writes Creature's hunger to screen

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\nTiredness");
            Console.Write(": {0}", getTiredness()); //Writes Creature's tiredness to screen
            Console.WriteLine();
            Console.WriteLine();

            ////////////////
            //Energy checking
            if ((energy < 5) && (energy > minEnergy)) //Check lower energy bounds
            {
                Console.WriteLine("{0} is looking rather sluggish. Try feeding {0} or letting {0} sleep.", getName());
            }
            else if (energy == minHappiness) //If energy is min
            {
                Console.WriteLine("{0}'s energy can't go any lower! {0} is completely drained!", getName());
            }
            else if ((energy > 15) && (energy < maxEnergy)) //Check upper energy bounds
            {
                Console.WriteLine("{0} is really feeling it!", getName());
            }
            else if (energy == maxEnergy) //If energy is max
            {
                Console.WriteLine("{0} is bursting with energy! Try letting {0} play or walk to calm down.", getName());
            }

            ////////////////
            //Happiness checking

            if ((happiness < 5) && (happiness > minHappiness))
            {
                Console.WriteLine("{0} is looking rather unhappy. Try cheering {0} up.", getName());
            }
            else if (happiness == minHappiness)
            {
                Console.WriteLine("{0}'s happiness can't go any lower! {0} is really upset!", getName());
            }
            else if (happiness == maxHappiness)
            {
                Console.WriteLine("{0} is looking really happy!", getName());
            }

            ////////////////
            //Hunger checking

            if ((hunger > 15) && (hunger < maxHunger))
            {
                Console.WriteLine("{0} is looking rather hungry. Try feeding {0}.", getName());
            }
            else if (hunger == maxHunger)
            {
                Console.WriteLine("{0}'s hunger can't go any higher! {0} is starving!", getName());
            }
            else if ((hunger < 5) && (hunger > minHunger))
            {
                Console.WriteLine("{0} is looking rather well-fed. Try walking or playing with\n{0} to burn it off.", getName());
            }
            else if (hunger == minHunger)
            {
                Console.WriteLine("It is seems that {0} is full. Try walking or playing with {0} to help.", getName());
            }

            ////////////////
            //Tiredness checking

            if ((tiredness > 15) && (tiredness < maxTiredness))
            {
                Console.WriteLine("{0} is looking rather tired. Try letting {0} sleep.", getName());
            }
            else if (tiredness == maxTiredness)
            {
                Console.WriteLine("{0}'s tiredness can't go any higher! {0} is exhausted!", getName());
            }
            else if (tiredness == minTiredness)
            {
                Console.WriteLine("{0} is wide awake!", getName());
            }

            /*The reason for writing "[Attribute]" and the Creature's actual atrributes value separately is simple: the get() function
             * for both happiness and energy include a Console.ForegroundColor declaration, setting the text colour to white
             * when the function is called. Because of this, the function overrides the previous text colour set before the Write().
             * Thus, for formatting purposes, it is necessary to separate the function and the text into two separate strings.  */

            //The printStatus is overridden by both the sub_Wufa and sub_Tweta classes.
             
        }

        public virtual void feedCreature() //Feed function
        {
            Console.Clear();

            switch (hunger)
            {
                case minHunger:
                    Console.WriteLine("{0}'s hunger can't go any lower! {0} is full!", getName());
                    break;

                case 1:
                    Console.WriteLine("You fed {0}.", getName());
                    hunger--; //Reduce hunger by 1
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\nHunger");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -1");
                    
                    switch (energy)
                    {
                        case maxEnergy:
                            Console.WriteLine("\n{0}'s energy can't go any higher!", getName());
                            break;

                        default:
                            energy++; //Increase energy by 1
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nEnergy"); //Write stat to screen
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;
                    }

                    switch (happiness)
                    {
                        case maxHappiness:
                            Console.WriteLine("\n{0}'s happiness can't go any higher!", getName());
                            break;

                        default:
                            happiness++; //Increase happiness by 1
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;
                    }

                    break;

                default:
                    Console.WriteLine("You fed {0}.", getName());
                    hunger -= 2; //REduce hunger by 2
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\nHunger");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -2");

                    switch (energy)
                    {
                        case maxEnergy:
                            Console.WriteLine("\n{0}'s energy can't go any higher!", getName());
                            break;

                        default:
                            energy++; //Increase energy by 1
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nEnergy"); //Write stat to screen
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;
                    }

                    switch (happiness)
                    {
                        case maxHappiness:
                            Console.WriteLine("\n{0}'s happiness can't go any higher!", getName());
                            break;

                        default:
                            happiness++; //Increase happiness by 1
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;
                    }

                    break;
            }

            Console.ReadLine();
        }

        public virtual void creatureSleep() //Sleep function
        {
            Console.Clear();

            switch(tiredness)
            {
                case minTiredness:
                    Console.WriteLine("{0}'s tiredness can't go any higher! {0} is wide awake and\nwon't sleep right now.", getName());
                    break;

                case 1:
                    Console.WriteLine("You put {0} to sleep for the night. {0} rested well.", getName());
                    tiredness--; //Decrease tiredness by 1
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nTiredness");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -1");

                    switch (energy)
                    {
                        case maxEnergy:
                            Console.WriteLine("\n{0}'s energy can't go any higher!", getName());
                            break;

                        case 19:
                            energy++; //Increase energy by 1
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nEnergy");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            energy += 2; //Increase energy by 2
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nEnergy");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;
                    }

                    switch (happiness)
                    {
                        case maxHappiness:
                            Console.WriteLine("\n{0}'s happiness can't go any higher!", getName());
                            break;

                        default:
                            happiness++; //Increase happiness by 1
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;
                    }

                    break;

                default:
                    Console.WriteLine("You put {0} to sleep for the night {0} rested well.", getName());
                    tiredness -= 2; //Decrease tiredness by 2
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\nTiredness");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -2");

                    switch (energy)
                    {
                        case maxEnergy:
                            Console.WriteLine("\n{0}'s energy can't go any higher!", getName());
                            break;

                        case 19:
                            energy++; //Increase energy by 1
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nEnergy");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            energy += 2; //Increase energy by 2
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\nEnergy");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;
                    }

                    switch (happiness)
                    {
                        case maxHappiness:
                            Console.WriteLine("\n{0}'s happiness can't go any higher!", getName());
                            break;

                        default:
                            happiness++; //Increase happiness by 1
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;
                    }

                    break;
            }

            Console.ReadLine();

        }

        public virtual void creaturePlay() //Play function
        {
            Console.Clear();

            switch(energy)
            {
                case minEnergy:
                    Console.WriteLine("{0}'s energy can't go any lower! {0} has no energy to\nplay right now.", getName());
                    break;

                case 1:
                    Console.WriteLine("You played with {0}.", getName());
                    energy--; //Decrease energy by 1 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nEnergy");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -1");

                    switch (happiness)
                    {
                        case maxHappiness:
                            Console.WriteLine("\n{0}'s happiness can't go any higher!", getName());
                            break;

                        case 19:
                            happiness++;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            happiness += 2; //Increase happiness by 2
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    switch (hunger)
                    {
                        case maxHunger:
                            Console.WriteLine("\n{0}'s hunger can't go any higher!", getName());
                            break;

                        case 19:
                            hunger++; //Increase hunger by 1
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("\nHunger");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            hunger += 2;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("\nHunger");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    switch (tiredness)
                    {
                        case maxTiredness:
                            Console.WriteLine("\n{0}'s tiredness can't go any higher!", getName());
                            break;

                        case 19:
                            tiredness++; //Increase tiredness by 1
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nTiredness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            tiredness += 2; //Increase tiredness by 2
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nTiredness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    break;

                default:
                    Console.WriteLine("You played with {0}.", getName());
                    energy -= 2;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nEnergy");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -2");

                    switch (happiness)
                    {
                        case maxHappiness:
                            Console.WriteLine("\n{0}'s happiness can't go any higher!", getName());
                            break;

                        case 19:
                            happiness++;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            happiness += 2; //Increase happiness by 2
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    switch (hunger)
                    {
                        case maxHunger:
                            Console.WriteLine("\n{0}'s hunger can't go any higher!", getName());
                            break;

                        case 19:
                            hunger++; //Increase hunger by 1
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("\nHunger");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            hunger += 2;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("\nHunger");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    switch (tiredness)
                    {
                        case maxTiredness:
                            Console.WriteLine("\n{0}'s tiredness can't go any higher!", getName());
                            break;

                        case 19:
                            tiredness++; //Increase tiredness by 1
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nTiredness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            tiredness += 2; //Increase tiredness by 2
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nTiredness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    break;
            }
 
            Console.ReadLine();

        }
    }
}
