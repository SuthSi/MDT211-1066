using System;
class PersonList
{
    private List<CurrentStudent>currentStudentList;
    private List<Student>studentList;
    private List<Teacher>teacherList;

    public PersonList()
    {
        this.currentStudentList = new List<CurrentStudent>();
        this.studentList = new List<Student>();
        this.teacherList = new List<Teacher>();
    }

    public void AddNewCurrentStudent(CurrentStudent currentStudent)
    {
        this.currentStudentList.Add(currentStudent);
    }
    public void AddNewStudent(Student student)
    {
        this.studentList.Add(student);
    }
    public void AddNewTeacher(Teacher teacher)
    {
        this.teacherList.Add(teacher);
    }
    public void TotalCurrentStudent(){
        int countCurrentStudent = currentStudentList.Count;
        Console.WriteLine("Total College CurrentStudent: {0}",countCurrentStudent);
    }
    public void TotalStudent(){
        int countStudent = studentList.Count;
        Console.WriteLine("Total College Student: {0}",countStudent);
    }
    public void TotalTeacher(){
        int countTeacher = teacherList.Count;
        Console.WriteLine("Total College Teacher: {0}",countTeacher);
    }

    public void FetchCurrentStudent()
    {
        foreach(Person person in this.currentStudentList)
        {
            if (person is CurrentStudent)
            {
                Console.WriteLine("Name {0} {1}  {2}",person.GetPrefix(),person.GetName(),person.GetSurName());
            }
        }
    }
    public void FetchStudent()
    {
        foreach(Person person in this.studentList)
        {
            if (person is Student)
            {
                Console.WriteLine("Name {0} {1}  {2}",person.GetPrefix(),person.GetName(),person.GetSurName());
            }
        }
    }
    public void FetchTeacher()
    {
        foreach(Person person in this.teacherList)
        {
            if (person is Teacher)
            {
                Console.WriteLine("Name {0} {1}  {2}",person.GetPrefix(),person.GetName(),person.GetSurName());
            }
        }
    }
}