namespace Week5Assignment;

public class UniversityMember
{
   
    private string _memberId;
    private string _name;

    
    protected List<string> ActionLog = new List<string>();

    public int ActionCount => ActionLog.Count();

    public string Name
    {
        get => _name;
        private set => _name = string.IsNullOrEmpty(value) ? throw new Exception("Name cannot be empty") : value ;
        
    }

    public string MemberId
    {
        get => _memberId;
        private set;
    }

    public UniversityMember(string memberId, string name)
    {
        this.Name = name;
        
        this._memberId = memberId;
        
    }

    

    public virtual void PerformDuties()
    {
        if (ActionCount > 5)
        {
            throw new Exception("Reached daily limit");
        }
    }
}

public class Professor : UniversityMember
{
    public Professor(string memberId, string name) : base(memberId, name)
    {
        
    }

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
    }

    public void ConductResearch(string topic)
    {
        ActionLog.Add(topic);
    }
}

public class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string memberId, string name) : base(memberId, name)
    {
    }
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lab work completed");
        
    }
}

public class GraduateStudent : UndergraduateStudent
{
    public GraduateStudent(string memberId, string name) : base(memberId, name)
    {
    }

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Thesis research update");
    }
}


