using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int pass;
    private int shoot;

    public Player(string name, int endurance, int sprint, int dribble, int pass, int shoot)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Pass = pass;
        Shoot = shoot;
    }

    public string Name
    {
        get { return name; }

        private set
        { 
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }

    public int Endurance
    {
        get { return endurance; }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            endurance = value;
        }
    }

    public int Sprint
    {
        get { return sprint; }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            sprint = value;
        }
    }

    public int Dribble
    {
        get { return dribble; }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            dribble = value;
        }
    }

    public int Pass
    {
        get { return pass; }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            pass = value;
        }
    }

    public int Shoot
    {
        get { return shoot; }

        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            shoot = value;
        }
    }


    public double Rating
    {
        get
        {
            return (Math.Round((Endurance + Sprint + Dribble + Pass + Shoot) / 5.0,2));
        }
    }

    public override string ToString()
    {
        return $"{Name} - {Rating:f2}";
    }


}

