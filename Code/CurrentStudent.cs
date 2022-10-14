using System;
class CurrentStudent: Person
{
    private string StudentID;
    public CurrentStudent(string prefix,string name,string surname,string age, string allergy,string religion,string studentID)
    : base(prefix,name,surname,age,allergy,religion)
    {
        this.StudentID = studentID;
    }
    public string GetStudentID()
    {
        return this.StudentID;
    }
}