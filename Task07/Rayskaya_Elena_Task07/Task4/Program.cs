using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Field
    {
        protected int width;
        protected int height;
        public int WidthField = 300;
        public int HeightField = 200;
        public Field() { }
    }
    class Player : Field
    {
        protected int xPlayer;
        protected int yPlayer;
        protected string playerName;
        protected int characteristic;
        int step = 10;
        public int XPlayer
        {
            get { return xPlayer; }
            set { xPlayer = value; }
        }
        public int YPlayer
        {
            get { return yPlayer; }
            set { yPlayer = value; }
        }
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public int Characteristic
        { get; set; }
        public Player(int x, int y, string name) : base()
        {
            XPlayer = x;
            yPlayer = y;
            PlayerName = name;
            Characteristic = 0;
        }
        Obstacle obstacle = new Obstacle("камень");
        Bonus bonus = new Bonus("яблоко");
        public void Move(int stepLeft, int stepRight, int stepUp, int stepDown)
        {
            if ((stepLeft > 0) && (XPlayer - step > 0) && (XPlayer - step != obstacle.XObstacle))
            {
                XPlayer -= step;
                if (XPlayer - step == bonus.XBonus) { Characteristic++; }
            }
            else if ((stepRight > 0) && (XPlayer + step < WidthField) && (XPlayer + step != obstacle.XObstacle))
            {
                XPlayer += step;
                if (XPlayer + step == bonus.XBonus) { Characteristic++; }
            }
            else if ((stepUp > 0) && (YPlayer + step > 0) && (YPlayer + step != obstacle.YObstacle))
            {
                YPlayer -= step;
                if (YPlayer - step == bonus.YBonus) { Characteristic++; }
            }
            else if ((stepDown > 0) && (YPlayer - step < HeightField) && (YPlayer - step != obstacle.YObstacle))
            {
                YPlayer += step;
                if (XPlayer + step == bonus.YBonus) { Characteristic++; }
            }
        }
    }
    class Bonus : Field
    {
        protected int xBonus;
        protected int yBonus;
        protected string bonusName;
        public int XBonus
        {
            get { return xBonus; }
            set { xBonus = value; }
        }
        public int YBonus
        {
            get { return yBonus; }
            set { yBonus = value; }
        }
        public string BonusName
        {
            get { return bonusName; }
            set { bonusName = value; }
        }
        public Bonus(string name) : base()
        {
            BonusName = name;
        }
        public void CreateOfBonus(int x, int y)
        {
            XBonus = x;
            YBonus = y;
        }
    }
    class Monster : Field
    {
        protected int xMonster;
        protected int yMonster;
        protected string monsterName;
        int step = 10;
        public int XMonster
        {
            get { return xMonster; }
            set { xMonster = value; }
        }
        public int YMonster
        {
            get { return yMonster; }
            set { yMonster = value; }
        }
        public string MonsterName
        {
            get { return monsterName; }
            set { monsterName = value; }
        }
        public Monster(int x, int y, string name) : base()
        {
            XMonster = x;
            YMonster = y;
            MonsterName = name;
        }
        public bool MonsterCaughtUp()
        {
            return false;
        }
        Obstacle obstacle = new Obstacle("камень");
        Bonus bonus = new Bonus("яблоко");
        Player player = new Player(2, 2, "игрок 1");
        public void MoveMonster(int stepLeft, int stepRight, int stepUp, int stepDown)
        {
            if ((stepLeft > 0) && (XMonster - step > 0) && (XMonster - step != obstacle.XObstacle) && (XMonster - step != bonus.XBonus))
            {
                XMonster -= step;
                if (XMonster - step == player.XPlayer) { MonsterCaughtUp(); }
            }
            else if ((stepRight > 0) && (XMonster + step < WidthField) && (XMonster + step != obstacle.XObstacle) && (XMonster - step != bonus.XBonus))
            {
                XMonster += step;
                if (XMonster + step == player.XPlayer) { MonsterCaughtUp(); }
            }
            else if ((stepUp > 0) && (XMonster + step > 0) && (XMonster + step != obstacle.YObstacle) && (YMonster - step != bonus.YBonus))
            {
                XMonster -= step;
                if (XMonster - step == player.YPlayer) { MonsterCaughtUp(); }
            }
            else if ((stepDown > 0) && (XMonster - step < HeightField) && (XMonster - step != obstacle.YObstacle) && (YMonster - step != bonus.YBonus))
            {
                XMonster += step;
                if (XMonster + step == player.YPlayer) { MonsterCaughtUp(); }
            }
        }
        
    }
    class Obstacle : Field
    {
        protected int xObstacle;
        protected int yObstacle;
        protected string obstacleName;
        public int XObstacle
        {
            get { return xObstacle; }
            set { xObstacle = value; }
        }
        public int YObstacle
        {
            get { return yObstacle; }
            set { yObstacle = value; }
        }
        public string ObstacleName
        {
            get { return obstacleName; }
            set { obstacleName = value; }
        }
        public Obstacle(string name) : base()
        {
            ObstacleName = name;
        }
        public void CreateObstacle(int x, int y)
        {
            XObstacle = x;
            YObstacle = y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
