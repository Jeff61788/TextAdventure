﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to my game, 'Arrest'");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            String answer;
            Console.WriteLine("You are driving on the highway in your patrol car and see a swerving car");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("What do you do?");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("1. Do nothing and take the next exit off the highway");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("2. Follow the car until he racks up enough traffic violations to make sure it is worth your time");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("3. Turn on your Lights and sirens and pull the swerving car over immeditately.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("4. Radio in the suspecious activity to dispatcher and advise you are about to make a traffic stop.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Pick your answer...... 1 , 2 , 3 or 4");
            System.Threading.Thread.Sleep(2000);
            Console.Write("answer: ");
            answer = Console.ReadLine();
            Console.Clear();

            switch (answer)
            {
                case "1":
                case "one":
                case "1.":
                    {
                        Console.WriteLine("You did nothing and got off of the next exit");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("The swerving car ended up rear ending another vehicle and caused a 10 car pile.");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("Press 'Enter to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "two":
                case "2.":
                    {
                        Console.WriteLine("Instead of pulling the car over immediately when he was swerving and failed to maintain his lane you waited until he violated numerous traffic violations so you could write him multiple tickets.");
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("The swerving car does not break any other traffic violations, however 10 miles down the road while you are still following him he swerves off the road again this time hitting and killing a pedestrian.");
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("The driver is found to be driving under the influnce of alcohol and you arrest him.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("The guy in the swevering car that hit and killed the pedestrian is charged with a DUI and Manslaughter.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOverTwo();
                        break;
                    }
                case "3":
                case "three":
                case "3.":
                    {
                        Console.WriteLine("You see the swerving car and his inability to saftly maintain his own lane so you immediately turn on your Lights and sirens to pull him over.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("The serving car sees and hears your lights and sirens and increases his speed and tries to run away");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "4":
                case "four":
                case "4.":
                    {
                        Console.WriteLine("You see the swevering car and his inability to maintain his lane so you immediately radio into your dispatach and advice you are about to make a traffic stop.");
                        System.Threading.Thread.Sleep(3500);
                        Console.WriteLine("You then make the decision to turn on your lights and sirens and attempt to pull over this car.");
                        System.Threading.Thread.Sleep(3500);
                        Console.WriteLine("When the car sees your lights and hears your sirens he panics and increases his speed to try and run from you.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again");
                        Console.ReadLine();
                        first();
                        break;
                    }
            }
        }

        public static void second()
        {
            string answer;
            Console.WriteLine("The driver of the swerving car finally pulls over immediately gets out of the car and puts his hands up in the air.");
            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("What do you do?");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("1. CAll for back up and wait until they arrive to take the suspect into custody");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("2. Immediately approach the suspect and try to apprehend him and put him in handcuffs");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("Pick your answer...... 1 or 2");
            System.Threading.Thread.Sleep(1500);
            Console.Write("answer: ");
            answer = Console.ReadLine();
            Console.Clear();

            switch (answer)
            {
                case "1":
                case "one":
                case "1.":
                    {
                        Console.WriteLine("Backup arrives and you and 4 other officers attempt to take the suspect down");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        third();
                        break;

                    }
                case "2":
                case "two":
                case "2.":
                    {
                        Console.WriteLine("You decide not to call and wait for back up and try to take down the suspect by yourself.");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("You approach the suspect very cautiously with handcuffs in your hand and before you can react the suspect lowers his hands from the air and grabs his gun from his waist.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("The suspect fires at you 3 times before you are able to react");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOverThree();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again");
                        Console.ReadLine();
                        second();
                        break;

                    }
            }
        }

        public static void third()
        {
            string answer;
            Console.WriteLine("Backup arrives and you and 4 other officers attempt to take the suspect down");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("The first police office pulls out his handcuffs");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("The other two officers pull out their hand guns");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("What weapon do you draw from your waist to help take down this suspect?");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("1. Night Stick");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("2. Taser");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("3. Gun");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Pick your answer...... 1, 2 or 3");
            System.Threading.Thread.Sleep(1500);
            Console.Write("answer: ");
            answer = Console.ReadLine();
            Console.Clear();

            switch (answer)
            {
                case "1":
                case "one":
                case "1.":
                    {
                        Console.WriteLine("After you pull your night stick from your waist band all four of yall go to take the suspect down.");
                        System.Threading.Thread.Sleep(3500);
                        Console.WriteLine("As soon as the officer gets close enough to put him in hand cuffs the suspects takes off running.");
                        System.Threading.Thread.Sleep(3500);
                        Console.WriteLine("You swing your night stick but the suspect is to far away by this time and you miss");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("With the suspect running from yall with his back towards yall the two officers with their gun drawn are unable to fire at the suspect.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOverFour();
                        break;
                    }
                case "2":
                case "two":
                case "2.":
                    {
                        Console.WriteLine("After you pull your taser from your waist band all four of yall go to take the suspect down.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("all four of yall appraoch the suspect cautiously");
                        System.Threading.Thread.Sleep(2500);
                        Console.WriteLine("The Officer with the handcuffs grabs one of the suspects arms and puts on one cuff");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("But as soon as he goes to put on the second cuff to the other hand the suspect fights to get away");
                        System.Threading.Thread.Sleep(3500);
                        Console.WriteLine("Press 'Enter' to Continue");
                        Console.ReadLine();
                        fourth();
                        break;
                    }
                case "3":
                case "three":
                case "3.":
                    {
                        Console.WriteLine("After you pull your gun from your waist band all four of yall go to take the suspect down.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("As soon as the officer gets close enough to put him in hand cuffs the suspects takes off running.");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("With the suspect running from yall with his back towards yall, you and the other two officers with their guns drawn are unable to fire at the suspect.");
                        System.Threading.Thread.Sleep(3500);
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOverFour();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' tvo try again");
                        Console.ReadLine();
                        third();
                        break;
                    }
            }

        }

        public static void fourth()
        {
            int numberOfShocks;

            Console.WriteLine("While the suspect is resisting the officer you aim your taser at the suspect and fire.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("It's a direct hit but the suspect doesn't go down after the first taser shock.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("How many more times do you try and tase and/or shock the suspect?!?");
            System.Threading.Thread.Sleep(2500);
            Console.Write("Number of shocks: ");
            int.TryParse(Console.ReadLine(), out numberOfShocks);
            Console.Clear();

            while (numberOfShocks < 5)
            {
                Console.WriteLine("That did not work it wasn't enough, suspect is still restisting");
                System.Threading.Thread.Sleep(2500);
                Console.WriteLine("How many more times do you shock him");
                System.Threading.Thread.Sleep(1500);
                Console.Write("Number of shocks: ");
                int.TryParse(Console.ReadLine(), out numberOfShocks);
            }
            Console.WriteLine("The suspect is finally down and the officer finally has both handcuffs on");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
            Console.Clear();
            youWin();
        }

        public static void gameOver()
        {
            Console.WriteLine("The next morning the Police Cheif reviews your dash and determines you were neglegent and should have stopped the vehicle a lot sooner.");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("The Cheif demands you to turn in your badge and gun and fires you on the spot");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("You have Lost the game!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Press 'Enter to try again.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void gameOverTwo()
        {
            Console.WriteLine("Court is held a few days later and the guy in the swerving car getts all charges dropped because it was ruled you, the police officer had plenty of time to stop him and neglected to do so and was ruled intrappment by a police officer.");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("A seperate case was held and because of your, the police officer's, neglect in this case. You are charged with manslaughter and thrown into prison for life.");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("You have Lost the game!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void gameOverThree()
        {
            Console.WriteLine("Two of the three shots hit you one in the Leg and one in the juggular.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("The shot that hit you in the juggular is causing you to bleed out and you do not have anyone around to help you because you did not wait for backup");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("You bleed out and die and the suspect fleeds the seen and is never found.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("You have lost the game!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Press 'Enter to Try again.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void gameOverFour()
        {
            Console.WriteLine("The suspect runs towards the Mexican Boarder and reaches it");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("He climbs over the fence and you no longer have jurisdiction to keep chasing him");
            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("The suspect gets away never to be found again");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("You have Lost the game!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Press 'Enter' to try again.");
            Console.ReadLine();
            Console.Clear();
            first();

        }

        public static void youWin()
        {
            Console.WriteLine("You and the other officers escourt the suspect in your potrol car to take him to jail.");
            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("You take the suspect to jail and book him for a DUI, resisting arrest and evading the police.");
            System.Threading.Thread.Sleep(3500);
            Console.WriteLine("You have susseccfully taken another criminal off the street.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("CONGRADULATIONS!!! YOU WON!!!!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Press 'Enter' to play again");
            Console.ReadLine();
            Console.Clear();
            gameTitle();

        }
    }
}
