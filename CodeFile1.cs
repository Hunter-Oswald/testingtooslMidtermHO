// hunter oswald 8781756 - testing tools and methodologies midterm
// oct 19th 2022
using System;
using testingtooslMidtermHO;



public class pacmanTournament
{
    // random arrangement of my student ID 8781756
    int randomStudentID = 7881765;

    // array of players
    player[] players = new player[5];

    public static void Main(string[] args)
    {
        string input = "";

        

        // while the user has not exited
        while (input != "5")
        {
            Console.WriteLine("1. Register plauer");
            Console.WriteLine("2. Update score");
            Console.WriteLine("3. Display list of players (highest score to lowest)");
            Console.WriteLine("4. Clear the list of players");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please write the number of the option you'd like: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                // register a player

            } else if(input == "2")
            {
                // update score

            } else if (input == "3")
            {
                // display players high to low

            } else if (input == "4")
            {
                // clear the list

            } else if (input == "5")
            {
                // exit and close app

            } else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    // register method
    public void register(player newP)
    {
        // to keep track of if a slot is found
        int slot = 5;
        bool slotFound = false;

        // see if there's an empty space
        for (int i = 0; i < players.Length; i++)
        {
            if(players[i] == null)
            {

            } else
            {
                slotFound = true;
                if (i <= slot)
                {
                    slot = i;
                }
            }
        }

        // if there's no spot, let the user know
        if (slotFound)
        {
            players[slot] = newP;
            Console.WriteLine("Player successfully registered!");
            // sort!

        } else
        {
            Console.WriteLine("Sorry, there are no available slots!");
        }
    }

    // update score method
    public void updateScore(player existingP, int newScore)
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].playerID == existingP.playerID)
            {
                players[i].score = newScore;
                Console.WriteLine("Score successfully updated!");
            }
        }

        // Sort!

    }

    // display players method
    public void display()
    {
        Console.WriteLine("Players:");
        for (int i = 0; i < players.Length; i++)
        {
            Console.WriteLine(players[i] + " - " + players[i].score);
        }
    }

    // clear list method
    public void listClear()
    {
        for (int i = 0; i < players.Length; i++)
        {
            players[i] = null;
        }

        Console.WriteLine("List successfully cleared.");

    }

    // sorting method
    public void sort()
    {

    }
}