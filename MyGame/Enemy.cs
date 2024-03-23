using System;

namespace MyGame
{
    public enum PowerUp
    {
        Health,
        Shield
    }

    public class Enemy
    {
        private static int totalPowerUps;
        private string name;
        private int health;
        private float shield;

        static Enemy()
        {
            totalPowerUps = 0;
        }

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

   
        public int GetHealth()
        {
            return health;
        }

        
        public float GetShield()
        {
            return shield;
        }

    
        public static int GetTotalPowerUps()
        {
            return totalPowerUps;
        }

        
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= (int)damageStillToInflict; 
                if (health < 0)
                    health = 0;
            }
        }

    
        public void PickupPowerUp(PowerUp powerUp, float value)
        {

            if (powerUp == PowerUp.Health)
            {
                health += (int)value;
                if (health > 100)
                    health = 100;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += value;
                if (shield > 100)
                    shield = 100;
            }

            totalPowerUps++; 
        }
    }
}
