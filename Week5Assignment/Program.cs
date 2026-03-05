namespace Week5Assignment;

class Program
{
    static void Main()
    {
        
        UniversityRegistry universityRegistry = new UniversityRegistry();

       
        Professor professor = new Professor("123", "Misha");
        UndergraduateStudent undergraduateStudent = new UndergraduateStudent("12", "Rostik");
        GraduateStudent graduateStudent = new GraduateStudent("1", "abeme");

        universityRegistry.AddMember(professor);
        universityRegistry.AddMember(undergraduateStudent);
        universityRegistry.AddMember(graduateStudent);
        
        universityRegistry.ExecuteAllDuties();

        Console.WriteLine(universityRegistry.GetMemberStatistic());
      
    }
}
