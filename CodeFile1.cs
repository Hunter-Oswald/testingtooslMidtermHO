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


        pacmanTournament pacman = new pacmanTournament();
        // while the user has not exited
        while (input != "5")
        {
            Console.WriteLine("1. Register player");
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

                Console.Write("Please enter the players first name: ");
                firstname = Console.ReadLine();

                Console.Write("Please enter the players last name: ");
                lastname = Console.ReadLine();

                pacman.register(firstname, lastname, pacman.players);

            } else if(input == "2")
            {
                // update score
                Console.WriteLine("Please enter your player ID: ");
                string newID = "";
                newID = Console.ReadLine();

                Console.WriteLine("Please enter your new score: ");
                string newScore = "";
                newScore = Console.ReadLine();

                
                pacman.updateScore(newID, Convert.ToInt32(newScore), pacman.players);

            } else if (input == "3")
            {
                // display players high to low
                
                pacman.display(pacman.players);

            } else if (input == "4")
            {
                // clear the list
                
                pacman.listClear(pacman.players);

            } else if (input == "5")
            {
                // exit and close app
                System.Environment.Exit(1);

            } else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }

    // register method
    public void register(string first, string last, player[] listOfPlayers)
    {
        // to keep track of if a slot is found
        int slot = 5;
        bool slotFound = false;

        player newplayer = new player();
        newplayer.firstName = first;
        newplayer.lastName = last;
        newplayer.playerID = first[0] + last[0] + generateID();
        newplayer.score = 0;

        // see if there's an empty space
        for (int i = 0; i < listOfPlayers.Length; i++)
        {
            if(listOfPlayers[i] == null)
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
            listOfPlayers[slot] = newplayer;
            Console.WriteLine("Player successfully registered!");
            // sort!
            sort(listOfPlayers);

        } else
        {
            Console.WriteLine("Sorry, there are no available slots!");
        }
    }

    // update score method
    public void updateScore(string existingP, int newScore, player[] listOfPlayers)
    {
        for (int i = 0; i < listOfPlayers.Length; i++)
        {
            if (listOfPlayers[i] != null && listOfPlayers[i].playerID == existingP)
            {
                listOfPlayers[i].score = newScore;
                Console.WriteLine("Score successfully updated!");
            }
        }

        // Sort!
        sort(listOfPlayers);

    }

    // display players method
    public void display(player[] listOfPlayers)
    {
        Console.WriteLine("Players: ");
        for (int i = 0; i < listOfPlayers.Length; i++)
        {
            if (listOfPlayers[i] != null)
            {
                Console.WriteLine(listOfPlayers[i].firstName + " " + listOfPlayers[i].lastName + " - " + listOfPlayers[i].score);
            }
        }
    }

    // clear list method
    public void listClear(player[] listOfPlayers)
    {
        for (int i = 0; i < listOfPlayers.Length; i++)
        {
            listOfPlayers[i] = null;
        }

        Console.WriteLine("List successfully cleared.");

    }

    // sorting method
    public void sort(player[] lplayers)
    {
        // insertion sort
        for (int j = 1; j < lplayers.Length; j++)
        {
            {
                for (int i = j; i > 0; i--)
                {
                    // swap i and i-1
                    if (lplayers[i] != null && lplayers[i - 1] != null)
                    {
                        if (lplayers[i].score < lplayers[i - 1].score)
                        {
                            player temp = lplayers[i];
                            lplayers[i] = lplayers[i - 1];
                            lplayers[i - 1] = temp;
                        }
                    }
                }
            }
        }
    }

    public string generateID()
    {
        return "7881765";
    }
}