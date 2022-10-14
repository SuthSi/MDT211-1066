using System;
enum Menu
{
    RegistrationPageForTheEvent = 1,
    AttendanceStatistics = 2,
    SignIn = 3
}
enum RegistrationPageForTheEvent
{
    RegisterCurrentStudent = 1,
    RegisterStudent = 2,
    RegisterTeacher = 3,
    BackToMainMenu = 4,
}
enum Userlogin
{
    RegistrationPageForTheEvent = 1,
    ShowAllCurrentStudentSubscriptions = 2,
    ShowAllStudentSubscriptions = 3,
    ShowAllTeacherSubscriptions = 4,
    LogOut = 5,
}
//-------------------------------------------------------------------------------------------------------------------------------------------------
class Program
{
    static PersonList currentStudentList;
    static PersonList studentList;
    static PersonList teacherList;
    public static void Main(string[] args)
    {
        PreparePersonListWhenProgramIsLoad();
        PrintListMenu();
        InputMenuFromKeyboard();

    }
    public static void PrintListMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome participants to the Idia camp program.");
        Console.WriteLine("***************************************************");
        Console.WriteLine("1.Registration Page For The Event");
        Console.WriteLine("2.Show Attendance Statistics");
        Console.WriteLine("3.Sign In");
        Console.WriteLine("***************************************************");
    }
    public static void InputMenuFromKeyboard()
    {
        Console.Write("Please Input Menu: ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }
     static void PresentMenu(Menu menu)
    {
        switch(menu)
        {
            case Menu.RegistrationPageForTheEvent:
                Program.PrintRegistrationPageForTheEventScreen();
                break;
            case Menu.AttendanceStatistics:
                ShowPerson();
                break;
            case Menu.SignIn:
                 InputSignInFromKeyboard();
                 break;
            default:
                break;
        }
    }
    static void PreparePersonListWhenProgramIsLoad()
    {
        Program.currentStudentList = new PersonList();
        Program.studentList = new PersonList();
        Program.teacherList = new PersonList();
    }
    static void BackToMainMenu()
    {
        PrintListMenu();
        InputMenuFromKeyboard();
    }
    static void ShowPerson()
    {
        Console.Clear();
        Program.currentStudentList.TotalCurrentStudent();
        Program.studentList.TotalStudent();
        Program.teacherList.TotalTeacher();
        
        Console.ReadLine();
        Console.Clear();
        BackToMainMenu();

    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    static void InputSignInFromKeyboard() {
            Console.Clear();
            ShowSignIn();

            SignIn signIn = new SignIn(GetEmail(),GetPassword());

            BackToUserloginMenu();
        }
    static void ShowSignIn(){
        Console.WriteLine("Input your email and password to sign in");
        Console.WriteLine("*************************************");
    }
    static string GetEmail() {
        Console.Write("Email :");

        return Console.ReadLine();
    }

    static string GetPassword() {
        Console.Write("Password :");

        return Console.ReadLine();
    }

    //-------------------------------------------------------------------------------------------------------------------------------------------------
    public static void PrintRegistrationPageForTheEventScreen()
    {
        Console.Clear();
        PreparePersonListWhenProgramIsLoad();
        PrintRegistrationPageForTheEvent();
        InputRegistrationPageForTheEventFromKeyboard();
    }
    public static void PrintRegistrationPageForTheEvent()
    {
        Console.Clear();
        Console.WriteLine("***************************************************");
        Console.WriteLine("1.Register Current Student");
        Console.WriteLine("2.Register Student");
        Console.WriteLine("3.Register Teacher");
        Console.WriteLine("4.Back To Main Menu");
        Console.WriteLine("***************************************************");
    }
    public static void InputRegistrationPageForTheEventFromKeyboard()
    {
        Console.Write("Please select a Registration Type: ");
        RegistrationPageForTheEvent registrationPageForTheEvent = (RegistrationPageForTheEvent)(int.Parse(Console.ReadLine()));

        RegistrationPageForTheEventMenu(registrationPageForTheEvent);
    }
    static void RegistrationPageForTheEventMenu(RegistrationPageForTheEvent registrationPageForTheEvent)
    {
        switch(registrationPageForTheEvent)
        {
            case RegistrationPageForTheEvent.RegisterCurrentStudent:
                ShowInputRegisterCurrentStudentScreen();
                break;
            case RegistrationPageForTheEvent.RegisterStudent:
                ShowInputRegisterStudentScreen();
                break;
            case RegistrationPageForTheEvent.RegisterTeacher:
                ShowInputRegistrationNewsTeacherScreen();
                break;
            case RegistrationPageForTheEvent.BackToMainMenu:
                BackToMainMenu();
                break;
            default:
                break;

        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    public static void ShowInputRegisterCurrentStudentScreen()
    {
        Console.Clear();
        Console.WriteLine("Register Current Student");
        Console.WriteLine("************************");
        int totalCurrentStudent = TotalCurrentStudent();

        InputCurrentStudentFromKeyboard(totalCurrentStudent);
    }

    static void PrintHeaderRegisterCurrentStudent()
    {
        Console.WriteLine("Register Current Student");
        Console.WriteLine("************************");
    }
    static int TotalCurrentStudent()
    {
        Console.Write("Input Total Current Student: ");
        
        return int.Parse(Console.ReadLine());
    }
    static void InputCurrentStudentFromKeyboard(int TotalCurrentStudent)
    {
        string[] info= new string[TotalCurrentStudent];
        for(int i=0; i<TotalCurrentStudent; i++)
        {
            Console.Clear();
            PrintHeaderRegisterCurrentStudent();

            CurrentStudent currentstudent = new CurrentStudent(InputNamePrefix(),InputName(),InputSurName(),InputStudentId(),InputAge(),
            InputAllergy(),InputReligion());
            string IsAdmin = InputAdmin();
            if(IsAdmin == "y")
            {
                SignUp signUp = new SignUp(InputEmail(),InputPassword());
            }
            
            Program.currentStudentList.AddNewCurrentStudent(currentstudent);
        }
        BackToMainMenu();
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    public static void ShowInputRegisterStudentScreen()
    {
        Console.Clear();
        Console.WriteLine("Register Student");
        Console.WriteLine("************************");
        int totalStudent = TotalStudent();

        InputStudentFromKeyboard(totalStudent);
    }

    static void PrintHeaderRegisterStudent()
    {
        Console.WriteLine("Register Student");
        Console.WriteLine("************************");
    }
    static int TotalStudent()
    {
        Console.Write("Input Total Student: ");

        return int.Parse(Console.ReadLine());
    }
    static void InputStudentFromKeyboard(int TotalStudent)
    {
        for(int i=0; i<TotalStudent; i++)
        {
            Console.Clear();
            PrintHeaderRegisterStudent();

            Student student = new Student(InputNamePrefix(),InputName(),InputSurName(),InputAge(),InputEducationalLevel(),
            InputAllergy(),InputReligion(),InputSchool());
            Program.studentList.AddNewStudent(student);
        }
        BackToMainMenu();
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    static void ShowInputRegistrationNewsTeacherScreen()
    {
        Console.Clear();
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("********************");
        int totalNewTeacher = TotalNewTeacher();
        InputNewTeacherFromKeyboard(totalNewTeacher);

    }
    static int TotalNewTeacher()
    {
        Console.Write("Input Total new Teacher: ");

        return int.Parse(Console.ReadLine());
    }
     static void PrintHeaderRegisterTeacher()
    {
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("********************");
    }
    static void InputNewTeacherFromKeyboard(int TotalNewTeacher)
    {
        for(int i=0; i<TotalNewTeacher; i++)
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            Teacher teacher = new Teacher(InputNamePrefix(),InputName(),InputSurName(),InputAge(),InputPosition(),InputAllergy(),
            InputReligion());
            Program.teacherList.AddNewTeacher(teacher);

            string HaveCar = InputPersonalCar();
            if(HaveCar == "y")
            {
                InputVehicleRegistration();
            }
            string IsAdmin = InputAdmin();
            if(IsAdmin == "y")
            {
                SignUp signUp = new SignUp(InputEmail(),InputPassword());
            }
            
        }
        BackToMainMenu();
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    static string InputNamePrefix()
    {
        Console.WriteLine("a.Mr. b.Mrs. c.Miss.");
        Console.Write("NamePrefix: ");
        string prefix = Console.ReadLine();
        if (prefix == "a")
            return "Mr.";
        else if (prefix == "b")
            return "Mrs.";
        else
            return "Miss";
    }
    static string InputName()
    {
        Console.Write("Name: ");
        return Console.ReadLine();
    }
    static string InputSurName()
    {
        Console.Write("SurName: ");
        return Console.ReadLine();
    }
    static string InputStudentId()
    {
        Console.Write("StudentID: ");
        return Console.ReadLine();
    }
    static string InputAge()
    {
        Console.Write("Age: ");
        return Console.ReadLine();
    }
     static string InputEducationalLevel()
    {
        Console.WriteLine("a. M.4. b. M.5 c. M.6");
        Console.Write("Class: ");
        string group = Console.ReadLine();
        if (group == "a")
            return "M.4";
        else if (group == "b")
            return "M.5";
        else 
            return "M.6";
    }
     static string InputPosition()
    {
        Console.WriteLine("a.Dean. b.Departmenthead c.Teacher");
        Console.Write("Position: ");
        string Position = Console.ReadLine();
        if (Position == "a")
            return "Dean";
        else if (Position == "b")
            return "Departmenthead";
        else 
            return "Teacher";
    }
    static string InputAllergy()
    {
        Console.Write("Allergy: ");
        return Console.ReadLine();
    }
    static string InputReligion()
    {
        Console.WriteLine("a.Buddhist b.Christ c.Islam d.Other");
        Console.Write("Religion: ");
        string Religion = Console.ReadLine();
        if (Religion == "a")
            return "Buddhist";
        else if (Religion == "b")
            return "Christ";
        else if (Religion == "c")
            return "Islam";
        else 
            return "Other";
    }
    static string InputSchool()
    {
        Console.Write("School: ");
        return Console.ReadLine();
    }
    static string InputPersonalCar()
    {
        Console.Write("Bring a car to join the project? (y/n): ");
        return Console.ReadLine();
    }
    static string InputVehicleRegistration()
    {
        Console.Write("Vehicle registration: ");
        return Console.ReadLine();
    }
    static string InputAdmin()
    {
         Console.Write("Are you an administrator? (y/n): ");
        return Console.ReadLine();
    }
    static string InputEmail()
    {
        Console.Write("Email: ");
        return Console.ReadLine();
    }
    static string InputPassword()
    {
         Console.Write("Password: ");
        return Console.ReadLine();
    }
    static void BackToRegistration()
    {
        PrintRegistrationPageForTheEvent();
        InputRegistrationPageForTheEventFromKeyboard();
    }
    static void BackToUserloginMenu()
    {
        PrintUserlogin();
        InputUserloginFromKeyboard();
    }
    
    //-------------------------------------------------------------------------------------------------------------------------------------------------
    public static void PrintUserloginScreen()
    {
        Console.Clear();
        PreparePersonListWhenProgramIsLoad();
        PrintUserlogin();
        InputUserloginFromKeyboard();
    }
    public static void PrintUserlogin()
    {
        Console.Clear();
        Console.WriteLine("***************************************************");
        Console.WriteLine("1.Registration Page For The Event");
        Console.WriteLine("2.Show All Current Student Subscriptions");
        Console.WriteLine("3.Show All Student Subscriptions");
        Console.WriteLine("4.Show All Teacher Subscriptions");
        Console.WriteLine("5.Log Out");
        Console.WriteLine("***************************************************");
    }
    public static void InputUserloginFromKeyboard()
    {
        Console.Write("Please select a Registration Type: ");
        Userlogin userlogin = (Userlogin)(int.Parse(Console.ReadLine()));

        UserloginMenu(userlogin);
    }
    static void UserloginMenu(Userlogin userlogin)
    {
        switch(userlogin)
        {
            case Userlogin.RegistrationPageForTheEvent:
                Program.PrintRegistrationPageForTheEventScreen();
                break;
            case Userlogin.ShowAllCurrentStudentSubscriptions:
                ShowAllCurrentStudentSubscriptionsScreen();
                break;
            case Userlogin.ShowAllStudentSubscriptions:
                ShowAllStudentSubscriptionsScreen();
                break;
            case Userlogin.ShowAllTeacherSubscriptions:
                ShowAllTeacherSubscriptionsScreen();
                break;
            case Userlogin.LogOut:
                BackToMainMenu();
                break;
            default:
                break;
        }
    }
    static void ShowAllCurrentStudentSubscriptionsScreen() {
        Console.Clear();
        Console.WriteLine("Name of college student in this event");
        Console.WriteLine("************");

        Program.currentStudentList.FetchCurrentStudent();
    }

    static void ShowAllStudentSubscriptionsScreen() {
        Console.Clear();
        Console.WriteLine("-----Collegian Register-----");

        Program.studentList.FetchStudent();
        Console.Write("Press enter button to continue.");
        Console.ReadLine();
        BackToUserloginMenu();
        Program.studentList.FetchStudent();
    }

    static void ShowAllTeacherSubscriptionsScreen() {
        Console.Clear();
        Console.WriteLine("Name of teacher in this event");
        Console.WriteLine("************");

        Program.teacherList.FetchTeacher();
    }

}