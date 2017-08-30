using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleCreatures
{
    class sub_Wufa : sup_Creature //The Wufa subclass inherits attributes and methods from the Creature superclass.
    {
        //Programmed by Elliot Thacker-Hopkins, 2014

        //"sub" identifies it as a subclass. C♯ itself does not require this distinction, but it is added for readability.

        public sub_Wufa() //Constructor method
        {
            boneCount = 0;       

            /*As Creatures' common attributes are already constructed, this constructor exists only to set the default
             * value of boneCount, the unique attribute of Wufas.   */
        }

        //Attributes

        int boneCount; //The number of bones in the Wufa's possession
        const int minBoneCount = 0; //The minimum number of bones a Wufa can have
        const int maxBoneCount = 10; //The maximum number of bones a Wufa can have
        
        ////////////////

        //Get method(s)

        public int getBoneCount()
        {
            Console.ForegroundColor = ConsoleColor.White;
            return boneCount;
        }

        ////////////////

        //Other methods

        public override void printStatus()
        {
            base.printStatus();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nBones");
            Console.Write(": {0}", getBoneCount());
            /*The printStatus() function seen in the Creature superclass is overriden in order to display the common creature
             * information - happiness, energy - as well as the attribute(s) unique to Wufas: boneCount. As with the printStatus
             * function found in the Creature superclass, text colours are overridden.  */
        }

        public virtual void walk() //Walk function
        {
            Console.Clear();

            switch (energy)
            {
                case minEnergy:
                    Console.WriteLine("{0}'s energy can't go any lower! {0} is too exhausted to walk.", getName());
                    break;

                case 1:
                    Console.WriteLine("You took {0} for a walk.", getName());
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
                    Console.WriteLine("You took {0} for a walk.", getName());
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

        public virtual void scold() //Scolding function
        {
            Console.Clear();

            switch(happiness)
            {
                case minHappiness: //If happiness has reached minimum
                    Console.WriteLine("It's happiness can't go any lower!");
                    break;

                case 1: //If happiness is 1
                    happiness--;
                    Console.WriteLine("You scolded {0}.", getName());
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nHappiness");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -1");

                    if (boneCount == minBoneCount)
                    {
                        Console.WriteLine("{0} has no bones to take!", getName());
                    }
                    else if (happiness != minHappiness)
                    {
                        Console.WriteLine("\n\nYou took a bone away from {0} as punishment.", getName());
                        boneCount -= 1; //Take 1 bone from Wufa
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nBones");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(": -1");
                    }

                    break;

                default: //Run thise code if the two previous case are not true
                    happiness -= 2;
                    Console.WriteLine("You scolded {0}.", getName());
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\nHappiness");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(": -2");

                    if (boneCount == minBoneCount)
                    {
                        Console.WriteLine("{0} has no bones to take!", getName());
                    }
                    else if (happiness != minHappiness)
                    {
                        Console.WriteLine("\n\nYou took a bone away from {0} as punishment.", getName());
                        boneCount -= 1; //Take 1 bone from Wufa
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nBones");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(": -1");
                    }

                    break;
            }

            Console.ReadLine();

        }
        
        public virtual void giveBone() //Bone giving function
        {
            if (boneCount != maxBoneCount)
            {
                Console.Clear();
                Console.WriteLine("You gave {0} a bone.", getName());
                boneCount += 1; //Increase number of bones Wufa has by one

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nBones");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": +1");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("{0} has enough bones for now.", getName());
                Console.ReadLine();
            }
        }
    }
}
