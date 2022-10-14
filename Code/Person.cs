public abstract class Person
{
    private string prefix;
    private string name;
    private string surname;
    private string age;
    private string allergy;
    private string religion;
    public Person(string prefix,string name,string surname,string age, string allergy,string religion)
    {
        this.prefix = prefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
    }
    public string GetPrefix()
    {
        return this.prefix;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetSurName()
    {
        return this.surname;
    }
    public string GetAge()
    {
        return this.age;
    }
    public string GetAllergy()
    {
        return this.allergy;
    }
    public string GetReligion()
    {
        return this.religion;
    }
}
