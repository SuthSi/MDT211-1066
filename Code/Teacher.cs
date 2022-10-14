using System;
class Teacher: Person
{
    private string position;
    public Teacher(string prefix,string name,string surname,string age,string position, string allergy,string religion)
    : base(prefix,name,surname,age,allergy,religion)
    {
        this.position = position;
    }
    public string GetPosition()
    {
        return this.position;
    }
}