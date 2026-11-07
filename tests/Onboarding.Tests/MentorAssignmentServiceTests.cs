using Onboarding.Core;
using Xunit;

namespace Onboarding.Tests
{
    public class MentorAssignmentServiceTests
    {
        [Fact]
        public void Assign_WhenMentorHasThreeNewcomers_ThrowsLimitExceeded()
        {
            var service = new MentorAssignmentService();
            service.Assign(mentorId: 7, employeeId: 101);
            service.Assign(mentorId: 7, employeeId: 102);
            service.Assign(mentorId: 7, employeeId: 103);

            Assert.Throws<MentorLimitExceededException>(() => service.Assign(7, 104));
        }

        [Fact]
        public void Assign_SameNewcomerTwice_DoesNotCountTwice()
        {
            var service = new MentorAssignmentService();
            service.Assign(7, 101);
            service.Assign(7, 101);

            Assert.Equal(1, service.CountNewcomers(7));
        }
    }
}
