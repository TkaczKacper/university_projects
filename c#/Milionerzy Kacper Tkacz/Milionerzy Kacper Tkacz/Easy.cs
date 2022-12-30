namespace Milionerzy_Kacper_Tkacz
{
    public class Easy : DifficultySettings
    {
        public override int DifficultyLevel()
        {
            return ScoreCalculator.DifficultyScore = 1;
        }
        public override int Time()
        {
            return Game.time = 60;
        }
        public override int Lives()
        {
            return Game.lives = 3;
        }
    }
}
