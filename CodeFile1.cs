// hunter oswald 8781756 - testing tools and methodologies midterm
// oct 19th 2022
using System;
using System.Security.Principal;
using System.Threading;
using testingtooslMidtermHO;



public class pacmanTournament
{
    // array of players
    player[] players = new player[5];

    public static void Main(string[] args)
    {
        string input = "";

        // random arrangement of my student ID 8781756
        string randomStudentID = "7881765";

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
                string firstname;
                string lastname;
                string id;
                string newscore = "";

                Console.Write("Please enter the players first name: ");
                firstname = Console.ReadLine();

                Console.Write("Please enter the players last name: ");
                lastname = Console.ReadLine();

                Console.Write("Please enter your score: ");
                newscore = Console.ReadLine();

                player newplayer = new player();
                newplayer.firstName = firstname;
                newplayer.lastName = lastname;
                newplayer.playerID = firstname[0] + lastname[0] + randomStudentID;
                newplayer.score = Convert.ToInt32(newscore);

                pacmanTournament pacman = new pacmanTournament();
                pacman.register(newplayer);

            } else if(input == "2")
            {
                // update score
                Console.WriteLine("Please enter your player ID: ");
                string newID = "";
                newID = Console.ReadLine();

                Console.WriteLine("Please enter your new score: ");
                string newScore = "";
                newScore = Console.ReadLine();

                pacmanTournament pacman = new pacmanTournament();
                pacman.updateScore(newID, Convert.ToInt32(newScore));

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
            sort();

        } else
        {
            Console.WriteLine("Sorry, there are no available slots!");
        }
    }

    // update score method
    public void updateScore(string existingP, int newScore)
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].playerID == existingP)
            {
                players[i].score = newScore;
                Console.WriteLine("Score successfully updated!");
            }
        }

        // Sort!
        sort();

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
        // insertion sort
        for (int j = 1; j < players.Length; j++)
        {
            for (int i = j; i > 0 && players[i].score < players[i - 1].score; i--)
            {
                // swap i and i-1
                player temp = players[i];
                players[i] = players[i - 1];
                players[i - 1] = temp;
            }
        }
    }
}