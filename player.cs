using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testingtooslMidtermHO;

namespace testingtooslMidtermHO
{
    public class player
    {
        public String firstName;
        public String lastName;
        public String playerID;
        public int score;

        player newPlayer(string first, string last, string id, int newscore)
        {
            player newp = new player();
            newp.firstName = first;
            newp.lastName = last;
            newp.playerID = id;
            newp.score = newscore;

            return newp;
        }
    }
 
}


