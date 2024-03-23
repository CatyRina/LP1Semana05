using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private int health;
        private float shield;

        // Constructor
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            if (newName.Length > 8)
            {
                name = newName.Substring(0, 8);
            }
            else
            {
                name = newName;
            }
        }

        public int GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
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
    }
}
