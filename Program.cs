using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using Mission2Again;

public class Program
{
    private static void Main(string[] args)
    {
        int userRolls = 0;
        int[] diceList = new int[userRolls];

        System.Console.Write("Welcome to the dice throwing simulator! \nHow many dice rolls would you like to simulate? ");
        userRolls = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1% of the total number of rolls. \nTotal number of rolls = " + userRolls);

        RollingtheDice rd = new RollingtheDice();

        diceList = rd.ListofRolls(userRolls);


        for (int i = 2; i <= 12; i++)
        {
            int numCount = 0;
            double astCount = 0;
            int roundedAst = 0;
            double percent = 0;
            for (int j = 0; j < userRolls; j++)
            {
                if (diceList[j] == i)
                {
                    numCount++;
                }
            }

            percent = (double)numCount / (double)userRolls;

            astCount = percent * 100;

            roundedAst = (int)Math.Round(astCount);

            System.Console.Write(i + ": ");
            for (int k = 0; k <= roundedAst; k++)
            {
                System.Console.Write("*");
            }
            System.Console.Write("\n");
        }

        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye! ");




    }
}