using Onboarding.Core;
using Xunit;

namespace Onboarding.Tests
{
    public class ChecklistQueryTests
    {
        [Fact]
        public void ForEmployee_ReturnsOnlyOwnDepartmentTasks()
        {
            var tasks = new[]
            {
                new ChecklistTask(1, 101, 10, "Знакомство с CRM", false),
                new ChecklistTask(2, 101, 20, "Закрытие месяца", false)
            };

            var result = ChecklistQuery.ForEmployee(tasks, employeeIdFromToken: 101, departmentId: 10);

            Assert.Single(result);
            Assert.Equal("Знакомство с CRM", result[0].Title);
        }
    }
}
