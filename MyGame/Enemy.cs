using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private int health;
        private int shield;

        public Enemy ( string name )
{
        this.name = name ; 
        health = 100;
        shield = 0;
}

    }
}
