namespace Onboarding.Core
{
    public static class QuizResult
    {
        /// <summary>Тест пройден, если набран проходной балл.</summary>
        public static bool IsPassed(int score, int passScore) => score >= passScore;
    }
}
