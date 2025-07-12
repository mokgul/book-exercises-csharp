namespace Chapter14;

public class StudentTest
{
    public static void Test()
    {
        Student studentA = new Student("John A. Mark");
        Student studentB = new Student("John B. Mark");
        Student studentC = new Student("John C. Mark");
        
        studentA.Email = "john.a.mark@mail.com";
        studentA.Degree = 4;
        studentA.Number = "12313123";
        studentA.Specialty = Specialty.Electronics;
        studentA.University = University.ElectronicsUniversity;
        
        studentB.Email = "john.b.mark@mail.com";
        studentB.Degree = 4;
        studentB.Number = "12313123";
        studentB.Specialty = Specialty.Medical;
        studentB.University = University.MedicalUniversity;
        
        studentC.Email = "john.c.mark@mail.com";
        studentC.Degree = 4;
        studentC.Number = "12313123";
        studentC.Specialty = Specialty.Other;
        studentC.University = University.OtherUniversity;
        
        studentA.PrintStudentInformation();
        studentB.PrintStudentInformation();
        studentC.PrintStudentInformation();
    }
}