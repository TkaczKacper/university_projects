namespace Milionerzy_Kacper_Tkacz
{
    public class Medium : DifficultySettings
    {
        public override int DifficultyLevel()
        {
            return ScoreCalculator.DifficultyScore = 3;
        }
        public override int Time()
        {
            return Game.time = 30;
        }
        public override int Lives()
        {
            return Game.lives = 2;
        }
    }
}
