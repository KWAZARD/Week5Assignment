namespace Week5Assignment;

class Program
{
    static void Main()
    {
        UniversityRegistry universityRegistry = new UniversityRegistry();
        Professor professor = new Professor("123", "Rostik");
        UndergraduateStudent undergraduateStudent = new UndergraduateStudent("0", "Meme");
        GraduateStudent graduateStudent = new GraduateStudent("12", "Misha");
        universityRegistry.AddMember(professor);
        universityRegistry.AddMember(graduateStudent);//тут виходить 2 перформи бо він наслідує клас UndergraduateStudent(було вказано в завданні так зробити)
        universityRegistry.AddMember(undergraduateStudent);
        

        universityRegistry.ExecuteAllDuties();
        
            
        
        

        Console.WriteLine(universityRegistry.GetMemberStatistic());
        
    }
    
}