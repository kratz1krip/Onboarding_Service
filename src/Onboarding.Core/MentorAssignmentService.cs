namespace Onboarding.Core
{
    public class MentorLimitExceededException : Exception
    {
        public MentorLimitExceededException(int mentorId)
            : base($"У наставника {mentorId} уже максимальное число новичков.") { }
    }

    /// <summary>Назначает новичкам наставников с учетом ограничения нагрузки.</summary>
    public class MentorAssignmentService
    {
        public const int MaxNewcomersPerMentor = 3;
        private readonly Dictionary<int, HashSet<int>> _newcomersByMentor = new();

        public void Assign(int mentorId, int employeeId)
        {
            if (!_newcomersByMentor.TryGetValue(mentorId, out var newcomers))
                _newcomersByMentor[mentorId] = newcomers = new HashSet<int>();

            if (newcomers.Count >= MaxNewcomersPerMentor && !newcomers.Contains(employeeId))
                throw new MentorLimitExceededException(mentorId);

            newcomers.Add(employeeId);
        }

        public int CountNewcomers(int mentorId) =>
            _newcomersByMentor.TryGetValue(mentorId, out var n) ? n.Count : 0;
    }
}
