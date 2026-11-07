namespace Onboarding.Core
{
    public record ChecklistTask(int Id, int EmployeeId, int DepartmentId, string Title, bool IsDone);

    public static class ChecklistQuery
    {
        /// <summary>ONB-112: задачи отбираются по сотруднику из токена и по его отделу.</summary>
        public static IReadOnlyList<ChecklistTask> ForEmployee(
            IEnumerable<ChecklistTask> tasks, int employeeIdFromToken, int departmentId) =>
            tasks.Where(t => t.EmployeeId == employeeIdFromToken && t.DepartmentId == departmentId)
                 .ToList();
    }
}
