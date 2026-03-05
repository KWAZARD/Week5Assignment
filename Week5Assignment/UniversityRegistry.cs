namespace Week5Assignment;

public class UniversityRegistry
{
    private List<UniversityMember> members = new List<UniversityMember>();

    public void AddMember(UniversityMember m)
    {
        members.Add(m);
    }

    public void ExecuteAllDuties()
    {
        foreach (var member in members)
        {
            member.PerformDuties();
        }
    }

    public int GetMemberStatistic()
    {
        int sum = 0;
        foreach (var member in members)
        {
            sum += member.ActionCount;
        }

        return sum;
    }
}