using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public abstract class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(Person p)
        {
            this.Name = p.Name;
            this.Age = p.Age;
        }
        public string getName()
        {
            return Name;
        }
        public int getAge()
        {
            return Age;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public void setAge(int age)
        {
            Age = age;
        }
    }
    public class Coach : Person
    {
        public Coach(string name, int age) : base(name,age)
        {

        }
        public Coach(Person p) : base(p)
        {

        }
    }
    public class Referee : Person
    {
        public Referee(string name, int age) : base(name, age)
        {

        }
        public Referee(Person p) : base(p)
        {

        }
    }
    public abstract class FootballPlayer : Person
    {
        private double Height { get; set; }
        private int Number { get; set; }
        public FootballPlayer(string name,int age) : base(name,age)
        {

        }
        public FootballPlayer(Person f) : base(f)
        {
        }
        public FootballPlayer(string name, int age, double height, int number) : this(name,age)
        {
            Height = height;
            Number = number;
        }
    }
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int age, double height, int number) : base(name,age,height,number)
        {

        }
    }
    public class Defender : FootballPlayer
    {
        public Defender(string name, int age, double height, int number) : base(name, age, height, number)
        {

        }
    }
    public class Midfield : FootballPlayer
    {
        public Midfield(string name, int age, double height, int number) : base(name, age, height, number)
        {

        }
    }
    public class Striker : FootballPlayer
    {
        public Striker(string name, int age, double height, int number) : base(name, age, height, number)
        {

        }
    }
    public class Team
    {
        private Coach Coach;
        private List<FootballPlayer> FootballPlayers = new List<FootballPlayer>();
        private double AverageAge;

        public Team(Coach coach, List<FootballPlayer> footballPlayers)
        {
            Coach = coach;
            if(setPlayers(footballPlayers))FootballPlayers = footballPlayers;
            else Console.WriteLine("Team must have between 11-22 players!");
            AverageAge = setAverage();
        }
        public bool setPlayers(List<FootballPlayer> footballPlayers)
        {
            bool cool = true;
            if (footballPlayers.Count < 11 && footballPlayers.Count > 22) cool = false;
            return cool;
        }
        public FootballPlayer getPlayer(int index)
        {
            return FootballPlayers[index];
        }
        public double setAverage()
        {
            double average = 0;
            foreach (FootballPlayer footballPlayer in FootballPlayers)
            {
                average += footballPlayer.getAge();
            }
            return average/FootballPlayers.Count;
        }
    }
}
