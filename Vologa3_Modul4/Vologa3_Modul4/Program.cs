using System;

public interface IStudent
{
    double GetAverageScore();
    string GetCourseInfo();
}

public class FirstYearStudent : IStudent
{
    public double AverageScore { get; set; }
    public string Course { get; set; }

    public FirstYearStudent(double averageScore, string course)
    {
        AverageScore = averageScore;
        Course = course;
    }

    public double GetAverageScore()
    {
        return AverageScore;
    }

    public string GetCourseInfo()
    {
        return Course;
    }
}

public class SecondYearStudent : IStudent
{
    public double AverageScore { get; set; }
    public string Course { get; set; }

    public SecondYearStudent(double averageScore, string course)
    {
        AverageScore = averageScore;
        Course = course;
    }

    public double GetAverageScore()
    {
        return AverageScore;
    }

    public string GetCourseInfo()
    {
        return Course;
    }
}

public class ThirdYearStudent : IStudent
{
    public double AverageScore { get; set; }
    public string Course { get; set; }

    public ThirdYearStudent(double averageScore, string course)
    {
        AverageScore = averageScore;
        Course = course;
    }

    public double GetAverageScore()
    {
        return AverageScore;
    }

    public string GetCourseInfo()
    {
        return Course;
    }
}

public class Student
{
    public void vivod_Sudenta() 
    {
        try
        {
            Console.WriteLine("Введите средний балл и курс для первого студента:");
            var firstYearAverageScore = Convert.ToDouble(Console.ReadLine());
            var firstYearCourse = Console.ReadLine();
            if (firstYearAverageScore < 0 || firstYearAverageScore > 10) throw new Exception("Средний балл должен быть числом от 0 до 10.");
            var firstYearStudent = new FirstYearStudent(firstYearAverageScore, firstYearCourse);
            Console.WriteLine($"Средний балл первого студента : {firstYearStudent.GetAverageScore()}, Курс: {firstYearStudent.GetCourseInfo()}");

            Console.WriteLine("Введите средний балл и курс для второго студента:");
            var secondYearAverageScore = Convert.ToDouble(Console.ReadLine());
            var secondYearCourse = Console.ReadLine();
            if (secondYearAverageScore < 0 || secondYearAverageScore > 10) throw new Exception("Средний балл должен быть числом от 0 до 10.");
            var secondYearStudent = new SecondYearStudent(secondYearAverageScore, secondYearCourse);
            Console.WriteLine($"Средний балл второго студента: {secondYearStudent.GetAverageScore()}, Курс: {secondYearStudent.GetCourseInfo()}");

            Console.WriteLine("Введите средний балл и курс для третьего студента:");
            var thirdYearAverageScore = Convert.ToDouble(Console.ReadLine());
            var thirdYearCourse = Console.ReadLine();
            if (thirdYearAverageScore < 0 || thirdYearAverageScore > 10) throw new Exception("Средний балл должен быть числом от 0 до 10.");
            var thirdYearStudent = new ThirdYearStudent(thirdYearAverageScore, thirdYearCourse);
            Console.WriteLine($"Средний балл третьего студента: {thirdYearStudent.GetAverageScore()}, Курс: {thirdYearStudent.GetCourseInfo()}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Введенные данные должны быть числом.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }
    }
    static void Main(string[] args)
    {
        Student student = new Student();
        student.vivod_Sudenta();
    }
}
