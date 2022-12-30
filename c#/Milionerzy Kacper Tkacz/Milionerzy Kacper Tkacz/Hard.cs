namespace Milionerzy_Kacper_Tkacz
{
    public class Hard : DifficultySettings
    {
        public override int DifficultyLevel()
        {
            return ScoreCalculator.DifficultyScore = 10;
        }
        public override int Time()
        {
            return Game.time = 10;
        }
        public override int Lives()
        {
            return Game.lives = 1;
        }
    }
}
