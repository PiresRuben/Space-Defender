namespace SpaceDefender.Core
{
    public class ScoreCalculator
    {
        public int BaseScore { get; private set; } = 10;
        public float Multiplier { get; private set; } = 1.0f;

        public int Calculate(int kills, int time)
        {
            if (kills <= 0) return 0;
            return (int)(kills * BaseScore * Multiplier);
        }

        public void ApplyCombo(int comboCount)
        {
            if (comboCount <= 1) return;
            Multiplier += (comboCount - 1) * 0.5f;
        }

        public void ResetMultiplier()
        {
            Multiplier = 1.0f;
        }
    }
}