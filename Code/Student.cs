using System;
class Student: Person
{
    private string educationalLevel;
    private string school;
    public Student(string prefix,string name,string surname,string age, string educationalLevel, string allergy,string religion,string school)
    : base(prefix,name,surname,age,allergy,religion)
    {
        this.educationalLevel = educationalLevel;
        this.school = school;
    }
    public string GetEducationalLevel()
    {
        return this.educationalLevel;
    }
    public string GetSchool()
    {
        return this.school;
    }
}