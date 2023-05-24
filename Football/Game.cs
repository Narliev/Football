using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Goal
    { 
        private int Minute { get; set; }
        private FootballPlayer Player;
        public Goal(int min, FootballPlayer f)
        {
            Player = f;
            Minute = min;
        }
    }
    public class Game
    {
        private Team Team1;
        private Team Team2;
        private List<Referee> Referees;
        private List<Goal> Goals = new List<Goal>();
        public Game(Team t1, Team t2, List<Referee> r)
        {
            Random rand = new Random();
            int goals = rand.Next(0, 5);
            int team,min, player;
            int t1g =0 , t2g = 0;
            for (int i = 0; i < goals; i++)
            {
                team = rand.Next(0, 2);
                if(team==1)
                {
                    min = rand.Next(0, 91);
                    player = rand.Next(0, 12);
                    Goal g = new Goal(min, t1.getPlayer(player-1));
                    Goals.Add(g);
                    t1g++;
                }
                else
                {
                    min = rand.Next(0, 91);
                    player = rand.Next(0, 12);
                    Goal g = new Goal(min, t2.getPlayer(player - 1));
                    Goals.Add(g);
                    t2g++;
                }
            }
            if (t1g>t2g)
            {
                Console.WriteLine("Result: Team1 " + t1g + " : " + t2g +" Team2");
                Console.WriteLine("Winner: Team1 !");
            }
            else if (t1g < t2g)
            {
                Console.WriteLine("Result: Team1 " + t1g + " : " + t2g + " Team2");
                Console.WriteLine("Winner: Team2 !");
            }
            else
            {
                Console.WriteLine("Result: Team1 " + t1g + " : " + t2g + " Team2");
                Console.WriteLine("Winner: Draw !");
            }
        }
    }
}
