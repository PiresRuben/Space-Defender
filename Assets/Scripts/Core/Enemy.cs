namespace SpaceDefender.Core
{
    public enum EnemyType { Basic, Fast, Tank }

    public class Enemy
    {
        public int Health { get; private set; }
        public int PointValue { get; private set; }
        public EnemyType Type { get; private set; }
        public bool IsAlive => Health > 0;

        public Enemy(int health, int pointValue, EnemyType type)
        {
            Health = health;
            PointValue = pointValue;
            Type = type;
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0) return;
            Health -= amount;
            if (Health < 0) Health = 0;
        }

        public int GetReward()
        {
            if (!IsAlive) return 0;
            return PointValue;
        }
    }
}