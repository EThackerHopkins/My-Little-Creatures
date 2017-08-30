using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleCreatures
{
    class sub_Tweta : sup_Creature //The Tweta subclass inherits attributes and methods from the Creature superclass.
    {
        //Programmed by Elliot Thacker-Hopkins, 2014

        //"sub" identifies it as a subclass. C♯ itself does not require this distinction, but it is added for readability.

        //Attributes

        int seedCount; //Amount of seed in Tweta's possession
        const int minSeedCount = 0; //Minimum amount of seed a Tweta can have
        const int maxSeedCount = 10; //Maximum amount of seed a Tweta can have

        //Get methods

        public int getSeedCount()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return seedCount;
        }

        ////////////////

        //Other methods

        public override void printStatus()
        {
            base.printStatus();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nSeed");
            Console.Write(": {0}", getSeedCount());
            /*The printStatus() function seen in the Creature superclass is overriden in order to display the common creature
             * information - happiness, energy - as well as the attribute(s) unique to Wufas: boneCount. As with the printStatus
             * function found in the Creature superclass, text colours are overridden.  */
        }

        public virtual void fly() //Fly function
        {
            Console.Clear();

            switch (energy)
            {
                case minEnergy:
                    Console.WriteLine("{0}'s energy can't go any lower! {0} is too exhausted to fly.", getName());
                    break;

                case 1:
                    Console.WriteLine("You let {0} fly around for a while.", getName());
                    energy -= 1; //Decrease energy by 1
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nEnergy");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -1");

                    switch (happiness)
                    {
                        case maxHappiness:
                            Console.WriteLine("\n{0}'s happiness can't go any higher!");
                            break;

                        case 19:
                            happiness++;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            happiness += 2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    switch (hunger)
                    {
                        case maxHunger:
                            Console.WriteLine("\n{0}'s hunger can't go any higher!");
                            break;

                        case 19:
                            hunger++;
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
                            Console.WriteLine("{0}'s tiredness can't go any higher!");
                            break;

                        case 19:
                            tiredness++;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nTiredness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            tiredness += 2;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nTiredness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    break;

                default:
                    Console.WriteLine("You let {0} fly around for a while.", getName());
                    energy -= 2; //Decrease energy by 2
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nEnergy");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -2");

                    switch (happiness)
                    {
                        case maxHappiness:
                            Console.WriteLine("\n{0}'s happiness can't go any higher!");
                            break;

                        case 19:
                            happiness++;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            happiness += 2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("\nHappiness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +2");
                            break;
                    }

                    switch (hunger)
                    {
                        case maxHunger:
                            Console.WriteLine("\n{0}'s hunger can't go any higher!");
                            break;

                        case 19:
                            hunger++;
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
                            Console.WriteLine("{0}'s tiredness can't go any higher!");
                            break;

                        case 19:
                            tiredness++;
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nTiredness");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(": +1");
                            break;

                        default:
                            tiredness += 2;
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

        public virtual void giveSeed() //Seed giving function
        {
            if (seedCount != maxSeedCount)
            {
                Console.Clear();
                Console.WriteLine("You gave {0} some seed.", getName());
                seedCount += 1; //Increase seed amount Tweta has by one

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nSeed");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": +1");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} has enough seed for now.", getName());
                Console.ReadLine();
            }
        }


    }
}